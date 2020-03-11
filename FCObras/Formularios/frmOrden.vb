Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmOrden
    Private _oIDEmpesa As Integer
    Private _oNombreEmpresa As String
    Private _oIDSucursal As Integer
    Private _oUsaComercial As Boolean
    Private _oRutaDoc As String
    Private _oIDDoc As Integer

    Private dInicioSDK As Boolean

    Private O_Obras As clObra
    Private D_Obras As Collection
    Private D_IDObra As Integer
    Private D_LOAD As Boolean
    Private D_DicInsumosAsoc As Dictionary(Of String, String)

    Private D_Documento As New clDocumento

    Private D_CodConceNo As String
    Private D_NomConceNo As String

    Private D_CodConceAuto As String
    Private D_NomConceAuto As String

    Private D_CodConceAutoGen As String
    Private D_NomConceAutoGen As String

    Private D_CodAlmacen As String
    Private D_NomAlmacen As String

    Private D_DtInsumos As DataTable
    Private D_DtPro As New DataTable

    Private loadInsumo As Boolean

    Private D_dicUnidades As New Dictionary(Of Integer, String)
    Public Property OIDSucursal As Integer
        Get
            Return _oIDSucursal
        End Get
        Set(value As Integer)
            _oIDSucursal = value
        End Set
    End Property

    Public Property OUsaComercial As Boolean
        Get
            Return _oUsaComercial
        End Get
        Set(value As Boolean)
            _oUsaComercial = value
        End Set
    End Property

    Public Property ORutaDoc As String
        Get
            Return _oRutaDoc
        End Get
        Set(value As String)
            _oRutaDoc = value
        End Set
    End Property

    Public Property OIDEmpesa As Integer
        Get
            Return _oIDEmpesa
        End Get
        Set(value As Integer)
            _oIDEmpesa = value
        End Set
    End Property

    Public Property ONombreEmpresa As String
        Get
            Return _oNombreEmpresa
        End Get
        Set(value As String)
            _oNombreEmpresa = value
        End Set
    End Property

    Public Property OIDDoc As Integer
        Get
            Return _oIDDoc
        End Get
        Set(value As Integer)
            _oIDDoc = value
        End Set
    End Property

    Private Sub FrmOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toltip.SetToolTip(btAddDoc, "Agrega documento a la orden")
        toltip.SetToolTip(btnNuevo, "Limpia para crear nueva orden")
        toltip.SetToolTip(btnEliminar, "Elimar la orden mostrada")
        toltip.SetToolTip(btnRefrescar, "Refrescar el estatus de la orden")
        toltip.SetToolTip(btnVista, "Vista preeliminar de la orden para enviar al usuario que autoriza")
        toltip.SetToolTip(btnNotificar, "Reenvia la notificacion al usuario que autoriza")
        If _oUsaComercial = True Then

        Else
            dInicioSDK = InicizalizaSDK_ADW()
        End If
        If dInicioSDK = False Then Me.Close()

        txtempresa.Text = _oNombreEmpresa

        Carga_Unidades()
        O_Obras = New clObra
        O_Obras.Idsucursal = _oIDSucursal
        D_Obras = O_Obras.Carga_Obras
        D_LOAD = True


        Limpiar_Orden()
        Carga_Obras()
        Carga_ProveedoresADW()
        Carga_Monedas()
        Carga_Conceptos()
        Carga_series()

        D_LOAD = False

        Carga_AsociacionesInsumos()
        If _oIDDoc <> 0 Then
            Carga_Orden()
        End If
    End Sub

    Private Sub Carga_series()
        Dim dQue As String, dt As New DataTable
        Dim row As DataRow = dt.NewRow()

        dQue = "SELECT codigo_insumo, nombre_insumo FROM zConsInsumos"
        Using cCom = New SqlDataAdapter(dQue, DConexiones("CON"))
            cCom.Fill(dt)
        End Using
        row("codigo_insumo") = ""
        row("nombre_insumo") = ""
        dt.Rows.Add(row)
        cbSerie.DataSource = dt
        cbSerie.DisplayMember = "codigo_insumo"
        cbSerie.ValueMember = "codigo_insumo"
        cbSerie.SelectedValue = ""
    End Sub

    Private Sub Datos_obra()
        Dim obra As clObra

        For Each obra In D_Obras
            If obra.Id = D_IDObra Then
                D_NomConceAuto = ""
                D_CodConceAuto = ""
                If obra.Idalmacen <> 0 Then
                    Get_Almacen(obra.Idalmacen, D_CodAlmacen, D_NomAlmacen)
                End If
                If obra.Idconcepto <> 0 Then
                    Get_Concepto(obra.Idconcepto, D_CodConceAuto, D_NomConceAuto)
                    txtconcepto.Text = D_NomConceAuto
                    txtconcepto.Tag = D_CodConceAuto
                Else
                    txtconcepto.Text = D_NomConceAutoGen
                    txtconcepto.Tag = D_CodConceAutoGen
                End If
                Exit For
            End If
        Next
    End Sub


    Private Sub Carga_AsociacionesInsumos()
        Dim dQue As String
        D_DicInsumosAsoc = New Dictionary(Of String, String)

        dQue = "SELECT codigoinsumo,codigoadw FROM zConsInsumosAsoc WHERE idsucursal=" & _oIDSucursal & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    If Not D_DicInsumosAsoc.ContainsKey(dCr("codigoinsumo")) Then
                        D_DicInsumosAsoc.Add(dCr("codigoinsumo"), dCr("codigoadw"))
                    End If
                Loop
            End Using
        End Using
    End Sub

    Private Sub Carga_Unidades()
        Dim dQue As String, dkey As Integer, ditem As String

        dQue = "SELECT  id,clave_unidad FROM zConsUnidades"
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    dkey = dCr("id")
                    ditem = dCr("clave_unidad")
                    If Not D_dicUnidades.ContainsKey(dkey) Then
                        D_dicUnidades.Add(dkey, ditem)
                    End If
                Loop
            End Using
        End Using
    End Sub

    Private Sub Carga_Obras()
        Dim obra As clObra
        Dim dt As DataTable
        Dim dr As DataRow

        dt = New DataTable("obras")
        dt.Columns.Add("id")
        dt.Columns.Add("nombre")

        dr = dt.NewRow
        dr(0) = 0
        dr(1) = "SELECCIONE LA OBRA"
        dt.Rows.Add(dr)

        For Each obra In D_Obras
            dr = dt.NewRow
            dr(0) = obra.Id
            dr(1) = obra.Nombreobra
            dt.Rows.Add(dr)
        Next obra

        cbObra.DataSource = dt
        cbObra.DisplayMember = "nombre"
        cbObra.ValueMember = "id"
    End Sub

    Private Sub dgMov_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMov.CellClick
        Dim frm As New frmInsumos, cuenta As clCuenta, dUnidad As String
        If D_IDObra = 0 Or D_Documento.Iddoc <> 0 Then Exit Sub
        If (CInt(e.ColumnIndex.ToString) >= 0) And e.RowIndex >= 0 Then
            If Me.dgMov.Columns(e.ColumnIndex).Name = "movbus" And cbSerie.Text <> "" Then

                frm.DtInsumos = D_DtInsumos
                frm.Codigo_in = cbSerie.Text
                frm.ShowDialog()
                cuenta = frm.Dcuent
                If cuenta.Id <> 0 Then
                    loadInsumo = True
                    ' If Existe_Cuenta(cuenta.Id, cuenta.Idcuentapadre) = False Then
                    dUnidad = IIf(D_dicUnidades.ContainsKey(cuenta.Unidad), D_dicUnidades.Item(cuenta.Unidad), "")
                    With dgMov.Rows(e.RowIndex)
                        '  .Cells("movcodigopadre").Value = cuenta.Codigocuentapadre
                        .Cells("movCodigo").Value = cuenta.Codigo
                        .Cells("movcuenta").Value = cuenta.Nombrecuenta
                        ' .Cells("movcantidadPen").Value = cuenta.Cantidadpendiente
                        .Cells("movUni").Value = dUnidad
                        .Cells("movidcuen").Value = cuenta.Id
                        .Cells("movPre").Value = 0
                        .Cells("movporiva").Value = 0
                        .Cells("moviva").Value = 0
                        .Cells("movporretiva").Value = 0
                        .Cells("movretiva").Value = 0
                        .Cells("movporretisr").Value = 0
                        .Cells("movretisr").Value = 0

                        .Cells("movidcuentapadre").Value = 0
                        .Cells("movimporteTo").Value = 0
                        loadInsumo = False
                        AbreForm_CantInsumo(e.RowIndex)
                    End With
                    ' End If
                End If
                frm.Dispose()
            Else
                If Me.dgMov.Columns(e.ColumnIndex).Name = "movbus" Then
                    MsgBox("Seleccione el insumo.", vbInformation, "validación")

                End If
            End If
        End If
    End Sub

    Private Sub CbObra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbObra.SelectedIndexChanged
        If D_LOAD = True Then Exit Sub
        D_IDObra = CInt(cbObra.SelectedValue)
        Limpiar_Orden()
        txtconcepto.Text = D_NomConceAutoGen
        txtconcepto.Tag = D_CodConceAutoGen

        If D_IDObra <> 0 Then
            Limpiar_Orden()
            Carga_Insumos(D_IDObra)
            Datos_obra()
            SerieFol_Omision(txtconcepto.Tag)
        End If
    End Sub

    Private Sub Carga_Insumos(ByVal cIDObra As Integer)
        Dim dQue As String
        D_DtInsumos = New DataTable
        dQue = "SELECT c.id,codigo,nombre_cuenta,unidad,codigo_insumo FROM zConsCuentas c INNER JOIN zConsInsumos i on c.idinsumo=i.id 
                        WHERE id_obra=" & cIDObra & " AND tipoinsumo=1"
        Using cCom = New SqlDataAdapter(dQue, DConexiones("CON"))
            cCom.Fill(D_DtInsumos)
        End Using
    End Sub

    Private Function Existe_Cuenta(ByVal idCuenta As Integer, ByVal idPadre As Integer) As Boolean
        Dim resp As Boolean

        resp = False
        For Each fila As DataGridViewRow In dgMov.Rows
            If fila.Cells("movidcuen").Value = idCuenta And fila.Cells("movidcuentapadre").Value = idPadre Then
                resp = True
            End If
        Next
        Return resp
    End Function

    Private Sub Limpiar_Orden()
        D_Documento = New clDocumento
        panelAciones.Enabled = False
        txtTipocambio.Text = 1
        txtFolio.Text = 0
        cbSerie.SelectedValue = ""
        txtCodigo.Text = ""
        dgMov.Rows.Clear()
        txtNombre.Text = ""
        txtObervaciones.Text = ""
        dtFecha.Value = Date.Now
        Bloquear_Documento(True)

        dgMov.ReadOnly = False
        lbenviado.Text = "Enviado al Proveedor:"
        lbEstatus.Text = "Estatus:"
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar_Orden()
        SerieFol_Omision(txtconcepto.Tag)
    End Sub

    Private Sub txtTipocambio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipocambio.KeyPress
        PALNUMEROS(e, 2, txtTipocambio)
    End Sub

    Private Sub txtFolio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFolio.KeyPress
        PALNUMEROS(e, 0, txtFolio)
    End Sub

    Private Sub btnbusca_Click(sender As Object, e As EventArgs) Handles btnbusca.Click
        If D_Documento.Iddoc <> 0 Then Exit Sub
        Dim frm As New frmProveedores
        frm.P_dtPro = D_DtPro
        frm.ShowDialog()
        If frm.P_Codigo <> "" Then
            txtCodigo.Text = frm.P_Codigo
            txtNombre.Text = frm.P_Nombre
        End If
        frm.Dispose()
    End Sub

    Private Sub Carga_ProveedoresADW()
        Dim fQue As String

        fQue = "SELECT CCODIGOC01 as Codigo,CRAZONSO01 as Nombre FROM MGW10002 WHERE CTIPOCLI01=2 OR CTIPOCLI01=3"
        Using cCom = New Odbc.OdbcDataAdapter(fQue, FC_CONFOX)
            cCom.Fill(D_DtPro)
        End Using
    End Sub

    Private Sub Carga_Monedas()
        Dim dt As New DataTable
        Dim fQue As String
        fQue = "SELECT cidmoneda,cplural FROM MGW10034"
        Using cCom = New Odbc.OdbcDataAdapter(fQue, FC_CONFOX)
            cCom.Fill(dt)
        End Using

        cbMoneda.DataSource = dt
        cbMoneda.DisplayMember = "cplural"
        cbMoneda.ValueMember = "cidmoneda"
    End Sub

    Private Sub Carga_Conceptos()
        Dim dt As New DataTable
        Dim dQue As String

        dQue = "SELECT  idconcepto,tipo FROM zConsConceptos 
                        WHERE idsucursal=" & _oIDSucursal & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    If dCr("tipo") = 0 Then
                        Get_Concepto(dCr("idconcepto"), D_CodConceNo, D_NomConceNo)
                    ElseIf dCr("tipo") = 1 Then
                        Get_Concepto(dCr("idconcepto"), D_CodConceAutoGen, D_NomConceAutoGen)
                        txtconcepto.Text = D_NomConceAutoGen
                        txtconcepto.Tag = D_CodConceAutoGen
                        SerieFol_Omision(D_CodConceAutoGen)
                    End If
                Loop
            End Using
        End Using
    End Sub

    Private Sub txtCodigo_LostFocus(sender As Object, e As EventArgs) Handles txtCodigo.LostFocus
        If txtCodigo.Text <> "" And D_Documento.Iddoc = 0 Then
            If Valida_codigoPro() = "" Then
                MsgBox("El codigo del proveedor no Existe", vbInformation, "Validación")
            Else
                txtNombre.Text = Valida_codigoPro()
            End If
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        txtNombre.Text = ""
    End Sub

    Private Function Valida_codigoPro() As String
        Valida_codigoPro = ""
        For x = 0 To D_DtPro.Rows.Count - 1
            For t = 0 To 1
                If Trim(D_DtPro.Rows(x).Item("Codigo").ToString) = txtCodigo.Text Then
                    Valida_codigoPro = Trim(D_DtPro.Rows(x).Item("Nombre").ToString)
                    Exit Function
                End If
            Next
        Next
    End Function

    Private Function Valida_InsumosAsoc() As Boolean
        Dim resp As Boolean, codigoinsumo As String
        resp = True
        For Each fila As DataGridViewRow In dgMov.Rows
            If fila.Cells("movCodigo").Value <> "" Then
                codigoinsumo = fila.Cells("movCodigo").Value
                fila.Cells("movcodadw").Value = ""
                If D_DicInsumosAsoc.ContainsKey(codigoinsumo) Then
                    fila.Cells("movcodadw").Value = D_DicInsumosAsoc.Item(codigoinsumo)
                Else
                    resp = False
                    Exit For
                End If
            End If
        Next
        Return resp
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim movimiento As clMovimiento, destatusenviado As Integer, dTienMov As Boolean
        dTienMov = False
        If D_Documento.Iddoc = 0 Then
            If Valida_InsumosAsoc() = False Then
                Dim frm As New frmAsocProductos
                frm.A_idempresa = _oIDEmpesa
                frm.A_idsucursal = _oIDSucursal
                frm.A_idobra = D_IDObra
                frm.ShowDialog()
                Carga_AsociacionesInsumos()
                Exit Sub
            End If
            If Valida_Orden() = True Then
                With D_Documento
                    .Idobra = D_IDObra
                    .Fechadocto = Format(dtFecha.Value, Formato_FechaMes)
                    .Serie = cbSerie.SelectedValue
                    .Folio = txtFolio.Text
                    .Codconcepto = txtconcepto.Tag
                    .Codcliente = txtCodigo.Text
                    .Idmoneda = cbMoneda.SelectedValue
                    .Tipocambio = IIf(txtTipocambio.Text = "", 1, txtTipocambio.Text)
                    .Referencia = cbObra.Text
                    .Observaciones = txtObervaciones.Text

                    For Each fila As DataGridViewRow In dgMov.Rows
                        movimiento = New clMovimiento
                        If fila.Cells("movPre").Value <> 0 And fila.Cells("movcodadw").Value <> "" And fila.Cells("movTota").Value <> 0 Then
                            dTienMov = True
                            If fila.Cells("movprecioT").Style.BackColor <> Color.White Then
                                movimiento.Validado = 1
                            ElseIf fila.Cells("movimporteTo").Style.BackColor <> Color.White Then
                                movimiento.Validado = 2
                            End If
                            movimiento.Idprecio = fila.Cells("movidprecio").Value
                            movimiento.Total = fila.Cells("movTota").Value
                            movimiento.Cantidaddisponible = fila.Cells("movcantidadPen").Value
                            movimiento.Totalpresupuesto = fila.Cells("movimporteTo").Value

                            movimiento.Codpro = fila.Cells("movcodadw").Value
                            movimiento.Precio = fila.Cells("movPre").Value
                            movimiento.CodAlmacen = IIf(D_CodAlmacen = "", 1, D_CodAlmacen)
                            movimiento.Unidades = fila.Cells("movcant").Value
                            movimiento.Impuesto1 = fila.Cells("moviva").Value
                            movimiento.Porcenimpuesto1 = fila.Cells("movporiva").Value
                            movimiento.Retencion1 = fila.Cells("movretisr").Value
                            movimiento.Porcenretencion1 = fila.Cells("movporretisr").Value
                            movimiento.Retencion2 = fila.Cells("movretiva").Value
                            movimiento.Porcenretencion2 = fila.Cells("movporretiva").Value
                            .DColMovimientos.Add(movimiento)
                        End If

                    Next

                    If dTienMov = False Then
                        MsgBox("El documento no tiene movimientos.", vbExclamation, "Validación")
                        Exit Sub
                    End If
                    If _oUsaComercial = True Then

                    Else
                        Genera_DocumentoADW(_oRutaDoc, D_Documento, False)
                    End If
                    If .Iddoc <> 0 Then
                        destatusenviado = Verifica_Validacion()
                        Guarda_DocCampos(destatusenviado, IIf(ckanticipo.Checked = True, 1, 0), IIf(destatusenviado = 0, -3, 1))
                        Guarda_DocMovCampos(CInt(D_Documento.Iddoc), D_Documento.DColMovimientos, destatusenviado)
                        Actualiza_Pendientes()
                        Bloquear_Documento(False)
                        MsgBox("Documento creado correctamente.", vbInformation, "Validación")
                        lbenviado.Text = lbenviado.Text & " No"
                        lbEstatus.Text = lbEstatus.Text & IIf(destatusenviado = 0, " Autorizado Automatico", " Pendiente")
                        btnGuardar.Enabled = False
                        btnEliminar.Enabled = True
                        panelAciones.Enabled = True
                    End If
                End With
            End If
        End If
    End Sub

    Private Sub Guarda_DocMovCampos(ByVal iddocADw As Integer, ByVal colMov As Collection, ByVal estatus As Integer)
        Dim dQue As String, movimiento As clMovimiento, idmov As Integer

        For Each movimiento In colMov
            idmov = CInt(movimiento.Idmov)
            dQue = "INSERT INTO zConsDoc_MovCampos(iddocadw,idmovadw,validado,
                    idasocprecio,cantidaddisponible,cantidad,precio,total,totalpresupuesto,estado)VALUES(@iddoc,@idmov,
                        @valida,@idprecio,@cantidaddisponible,@canti,@precio,@total,@totalpresupuesto,@estatus)"
            Using dCom = New SqlCommand(dQue, DConexiones("CON"))
                dCom.Parameters.AddWithValue("iddoc", iddocADw)
                dCom.Parameters.AddWithValue("idmov", idmov)
                dCom.Parameters.AddWithValue("valida", movimiento.Validado)
                dCom.Parameters.AddWithValue("idprecio", movimiento.Idprecio)
                dCom.Parameters.AddWithValue("cantidaddisponible", movimiento.Cantidaddisponible)
                dCom.Parameters.AddWithValue("canti", movimiento.Unidades)
                dCom.Parameters.AddWithValue("precio", movimiento.Precio)
                dCom.Parameters.AddWithValue("total", movimiento.Total)
                dCom.Parameters.AddWithValue("totalpresupuesto", movimiento.Totalpresupuesto)
                dCom.Parameters.AddWithValue("estatus", estatus)
                dCom.ExecuteNonQuery()
            End Using
        Next
    End Sub

    Private Sub Actualiza_Pendientes()
        Dim dQue As String, dIDPrecio As Integer, dCantidad As Integer, dTotal As Double

        For Each row As DataGridViewRow In dgMov.Rows
            If row.Cells("movPre").Value <> 0 And row.Cells("movcodadw").Value <> "" And
                row.Cells("movTota").Value <> 0 And row.Cells("movidprecio").Value <> 0 Then
                dIDPrecio = row.Cells("movidprecio").Value
                dCantidad = row.Cells("movcant").Value
                dTotal = row.Cells("movTota").Value
                dQue = "UPDATE zConsAsociacionesPrecios SET 
                        cantidad_pendiente=cantidad_pendiente-@cantidad,
                            importe_pendiente=importe_pendiente-@importe WHERE id=@id"
                Using dCom = New SqlCommand(dQue, DConexiones("CON"))
                    dCom.Parameters.AddWithValue("cantidad", dCantidad)
                    dCom.Parameters.AddWithValue("importe", dTotal)
                    dCom.Parameters.AddWithValue("id", dIDPrecio)
                    dCom.ExecuteNonQuery()
                End Using
            End If
        Next
    End Sub

    Public Function Verifica_Validacion() As Integer
        Dim resp As Integer

        resp = 0
        For Each fila As DataGridViewRow In dgMov.Rows
            If fila.Cells("movprecioT").Style.BackColor <> Color.White Or fila.Cells("movimporteTo").Style.BackColor <> Color.White Then
                resp = 1
            End If
        Next
        Return resp
    End Function

    Private Sub Guarda_DocCampos(ByVal dEstado As Integer, ByVal dAnticipo As Integer, ByVal dValidado As Integer)
        Dim dQue As String

        dQue = "INSERT INTO zConsDocCampos(idusuario,idsucursal,iddocadw,fecha,idobra,enviado_prove,estado,
                        esanticipo,validado)VALUES(@iduser,@idsuc,@iddoc,@fecha,@idobra,
                        @enviado,@estado,@anticipo,@validado)"
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            dCom.Parameters.AddWithValue("iduser", GL_cUsuario.Iduser)
            dCom.Parameters.AddWithValue("idsuc", _oIDSucursal)
            dCom.Parameters.AddWithValue("iddoc", D_Documento.Iddoc)
            dCom.Parameters.AddWithValue("fecha", Date.Now.Date)
            dCom.Parameters.AddWithValue("idobra", D_IDObra)
            dCom.Parameters.AddWithValue("enviado", 0)
            dCom.Parameters.AddWithValue("estado", dEstado)
            dCom.Parameters.AddWithValue("anticipo", dAnticipo)
            dCom.Parameters.AddWithValue("validado", dValidado)
            dCom.ExecuteNonQuery()
        End Using
    End Sub

    Private Function Valida_Orden() As Boolean
        Dim resp As Boolean
        resp = True
        If cbObra.SelectedIndex = 0 Then
            MsgBox("No se ha seleccionado la obra", vbInformation, "Validación")
            resp = False
            'ElseIf cbConceptos.Text = "" Then
            '    MsgBox("No se ha seleccionado Concepto", vbInformation, "Validación")
            '    resp = False
        ElseIf txtCodigo.Text = "" Or txtNombre.Text = "" Then
            MsgBox("El codigo del del Proveedor es incorrecto", vbInformation, "Validación")
            txtCodigo.Select()
            resp = False
        ElseIf txtFolio.Text = 0 Then
            MsgBox("El folio es incorrecto", vbInformation, "Validación")
            txtFolio.Select()
            resp = False
        ElseIf cbMoneda.SelectedValue <> 1 And txtTipocambio.Text <= 1 Then
            MsgBox("El tipo de cambio es incorrecto", vbInformation, "Validación")
            txtFolio.Select()
            resp = False
        End If
        If dgMov.Rows.Count > 0 Then

        Else
            MsgBox("El documento no tiene movimientos.", vbInformation, "Validación")
            resp = False
        End If
        If _oUsaComercial = True Then
        Else
            If Existe_FolioADW(txtFolio.Text, cbSerie.SelectedValue) = True Then
                MsgBox("El Folio: " & txtFolio.Text & " con serie: " & cbSerie.SelectedValue & "ya existe.", vbInformation, "Validación")
                resp = False

            End If
        End If
        Return resp
    End Function

    Private Function Existe_FolioADW(ByVal vfolio As Integer, ByVal vSerie As String) As Boolean
        Dim fQue As String, resp As Boolean

        resp = False
        fQue = "SELECT * FROM MGW10008 WHERE cseriedo01 = '" & Trim(vSerie) & "' AND cfolio = " & Trim(vfolio) & ""
        Using fCom = New Odbc.OdbcCommand(fQue, FC_CONFOX)
            Using fCr = fCom.ExecuteReader
                fCr.Read()
                If fCr.HasRows Then
                    resp = True
                End If
            End Using
        End Using
        Return resp
    End Function



    Private Sub frmOrden_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If dInicioSDK = True Then
            If _oUsaComercial = True Then
                CerrarEmpresa_Comercial()
            Else
                CerrarEmpresa_ADW()
            End If
        End If
    End Sub

    Private Sub dgMov_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgMov.CellValueChanged
        Dim cantidad As Integer, precio As Double, iva As Double, retiva As Double, retisr As Double
        Dim totalimp As Double, poriva As Double, porretiva As Double, portetisr As Double
        Dim dColor As Integer
        If D_Documento.Iddoc <> 0 Then Exit Sub

        If e.ColumnIndex = 3 And e.RowIndex >= 0 And loadInsumo = False Then
            AbreForm_CantInsumo(e.RowIndex)
        End If

        If e.ColumnIndex >= 8 And e.RowIndex >= 0 AND e.ColumnIndex <> 20 Then
            With dgMov.Rows(e.RowIndex)
                dColor = 0
                cantidad = IIf(IsNothing(.Cells("movcant").Value), 0, .Cells("movcant").Value)
                precio = IIf(IsNothing(.Cells("movPre").Value), 0, .Cells("movPre").Value)
                iva = IIf(IsNothing(.Cells("moviva").Value), 0, .Cells("moviva").Value)
                retiva = IIf(IsNothing(.Cells("movretiva").Value), 0, .Cells("movretiva").Value)
                retisr = IIf(IsNothing(.Cells("movretisr").Value), 0, .Cells("movretisr").Value)
                If Me.dgMov.Columns(e.ColumnIndex).Name = "movcant" Or
                    Me.dgMov.Columns(e.ColumnIndex).Name = "movPre" Or Me.dgMov.Columns(e.ColumnIndex).Name = "moviva" Then


                ElseIf Me.dgMov.Columns(e.ColumnIndex).Name = "movporiva" Then
                    poriva = IIf(IsNothing(.Cells("movporiva").Value), 0, .Cells("movporiva").Value)
                    .Cells("moviva").Value = (precio * (poriva / 100)) * cantidad
                    iva = .Cells("moviva").Value
                ElseIf Me.dgMov.Columns(e.ColumnIndex).Name = "movporretiva" Then
                    porretiva = IIf(IsNothing(.Cells("movporretiva").Value), 0, .Cells("movporretiva").Value)
                    .Cells("movretiva").Value = (precio * (porretiva / 100)) * cantidad
                    retiva = .Cells("movretiva").Value
                ElseIf Me.dgMov.Columns(e.ColumnIndex).Name = "movporretisr" Then
                    portetisr = IIf(IsNothing(.Cells("movporretisr").Value), 0, .Cells("movporretisr").Value)
                    .Cells("movretisr").Value = (precio * (portetisr / 100)) * cantidad
                    retiva = .Cells("movretisr").Value
                End If
                totalimp = iva - retiva - retisr
                dgMov.Rows(e.RowIndex).Cells("movTota").Value = cantidad * precio + iva - retiva - retisr
                If .Cells("movTota").Value > .Cells("movimporteTo").Value And dColor = 0 Then
                    dgMov.Rows(e.RowIndex).Cells("movimporteTo").Style.BackColor = Color.Orange
                    dColor = 2
                Else
                    dgMov.Rows(e.RowIndex).Cells("movimporteTo").Style.BackColor = Color.White
                End If

                If .Cells("movPre").Value > .Cells("movprecioT").Value And dColor = 0 Then
                    dgMov.Rows(e.RowIndex).Cells("movprecioT").Style.BackColor = Color.Orange
                    dColor = 2
                Else
                    dgMov.Rows(e.RowIndex).Cells("movprecioT").Style.BackColor = Color.White
                End If

                If dColor <> 0 Then
                    txtconcepto.Text = D_NomConceNo
                    txtconcepto.Tag = D_CodConceNo
                    SerieFol_Omision(D_CodConceNo)
                Else
                    dgMov.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
                    If D_NomConceAuto <> "" And D_CodConceAuto <> "" And Verifica_Validacion() = 0 Then
                        txtconcepto.Text = D_NomConceAuto
                        txtconcepto.Tag = D_CodConceAuto
                    Else
                        txtconcepto.Text = D_NomConceAutoGen
                        txtconcepto.Tag = D_CodConceAutoGen
                    End If
                    SerieFol_Omision(txtconcepto.Tag)
                End If
                Suma_importes()
            End With
        End If
    End Sub

    Private Sub Suma_importes()
        Dim Total As Double, SubTotal As Double, totalImpuestos As Double

        For Each row As DataGridViewRow In Me.dgMov.Rows
            SubTotal += Val(row.Cells("movcant").Value * row.Cells("movPre").Value)
            totalImpuestos += Val(row.Cells("moviva").Value - row.Cells("movretiva").Value - row.Cells("movretisr").Value)
            Total += Val(row.Cells("movTota").Value)
        Next
        txtSubtotal.Text = Format(SubTotal, Format_Moneda)
        txttotalImpuestos.Text = Format(totalImpuestos, Format_Moneda)
        txtTotal.Text = Format(Total, Format_Moneda)

    End Sub

    Private Sub AbreForm_CantInsumo(ByVal index As Integer)
        Dim dCod As String, resp As Integer, cuenta As clCuenta, dunidad As String
        Dim cont As Integer, esNuevafil As Boolean, idprecio As Integer, preciounitadrio As Double
        dCod = dgMov.Rows(index).Cells("movCodigo").Value
        resp = Existe_Codigo(dCod)
        If resp > 0 Then
            Dim frm As New frmCantidadInsumos
            dgMov.Rows(index).Cells("movidcuen").Value = resp
            frm.I_idcuenta = dgMov.Rows(index).Cells("movidcuen").Value
            frm.I_idobra = D_IDObra
            frm.ShowDialog()
            dunidad = dgMov.Rows(index).Cells("movUni").Value
            loadInsumo = True
            cont = 2
            If frm.I_dicCuentas.Count > 0 Then
                esNuevafil = dgMov.Rows(dgMov.CurrentRow.Index).IsNewRow
                If esNuevafil = True Then
                    With dgMov.Rows(index)
                        .Cells("movidcuen").Value = 0
                        .Cells("movidcuentapadre").Value = 0
                        .Cells("movcodigopadre").Value = ""
                        .Cells("movCodigo").Value = ""
                        .Cells("movcuenta").Value = ""

                        .Cells("movcantidadPen").Value = 0
                        .Cells("movUni").Value = ""
                        .Cells("movcant").Value = 0


                        .Cells("movPre").Value = 0
                        .Cells("movporiva").Value = 0
                        .Cells("moviva").Value = 0
                        .Cells("movporretiva").Value = 0
                        .Cells("movretiva").Value = 0
                        .Cells("movporretisr").Value = 0

                        .Cells("movretisr").Value = 0


                        .Cells("movimporteTo").Value = 0
                    End With
                End If
                For Each cuenta In frm.I_dicCuentas
                    If Existe_Cuenta(cuenta.Id, cuenta.Idcuentapadre) = False Then
                        Get_Precio(cuenta.Id, cuenta.Idcuentapadre, dtFecha.Value, idprecio, preciounitadrio)
                        With cuenta
                            dgMov.Rows.Add(.Id, .Idcuentapadre, .Codigocuentapadre,
                                        .Codigo, .Nombrecuenta, "", .Cantidadpendiente,
                                        dunidad, .Cantidad, 0, 0, 0, 0, 0, 0, 0, 0, cuenta.Importependiente, 0, preciounitadrio, "", idprecio)
                        End With

                    End If
                Next
                loadInsumo = False
            End If
            frm.Dispose()
        Else
            MsgBox("El codigo no existe", vbExclamation, "Validación")
        End If
    End Sub

    Private Sub Validar_NumerosGrid(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        Dim Celda As DataGridViewCell = Me.dgMov.CurrentCell()

        If Celda.ColumnIndex = 8 Or Celda.ColumnIndex = 9 Then

            If e.KeyChar = "."c And Celda.ColumnIndex >= 9 Then

                If InStr(Celda.EditedFormattedValue.ToString, ".", CompareMethod.Text) > 0 Then

                    e.Handled = True
                Else

                    e.Handled = False
                End If
            Else

                If Len(Trim(Celda.EditedFormattedValue.ToString)) > 0 Then

                    If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(8) Then

                        e.Handled = False
                    Else

                        e.Handled = True
                    End If
                Else

                    If e.KeyChar = "0"c Then

                        e.Handled = True
                    Else

                        If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(8) Then

                            e.Handled = False
                        Else

                            e.Handled = True
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dgMov_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgMov.EditingControlShowing
        If D_Documento.Iddoc <> 0 Then Exit Sub
        AddHandler e.Control.KeyPress, AddressOf Validar_NumerosGrid
    End Sub

    Private Sub dgMov_KeyDown(sender As Object, e As KeyEventArgs) Handles dgMov.KeyDown
        Dim li_index As Integer
        If D_Documento.Iddoc <> 0 Then Exit Sub
        If e.KeyCode = Keys.Delete And Not (Me.dgMov.Rows(dgMov.CurrentRow.Index).IsNewRow) Then

            e.Handled = True
            If MsgBox("Se va eliminar el movimiento." & vbCrLf _
                    & "¿Desea eliminar el movimiento seleccionado?", vbYesNoCancel, "Validación") = vbYes Then
                li_index = CType(sender, DataGridView).CurrentRow.Index
                dgMov.Rows.RemoveAt(li_index)
            End If
        End If
    End Sub


    Private Sub Bloquear_Documento(ByVal bloquea As Boolean)
        txtCodigo.Enabled = bloquea
        cbSerie.Enabled = bloquea
        txtFolio.Enabled = bloquea
        txtObervaciones.Enabled = bloquea
        cbMoneda.Enabled = bloquea
        txtTipocambio.Enabled = bloquea
        dtFecha.Enabled = bloquea
        btnGuardar.Enabled = bloquea
    End Sub

    Private Function Existe_Codigo(ByVal dcodigo As String) As Integer
        Dim resp As Integer
        For x = 0 To D_DtInsumos.Rows.Count - 1
            If UCase(D_DtInsumos.Rows(x).Item("codigo")) = UCase(dcodigo) Then
                resp = D_DtInsumos.Rows(x).Item("id")
                Exit For
            End If
        Next
        Return resp
    End Function

    Private Sub dtFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtFecha.ValueChanged
        If dgMov.Rows.Count > 0 Then
            restable_precios()
        End If
    End Sub

    Private Sub restable_precios()
        Dim idCuenta As Integer, idCuentaPadre As Integer, idprecio As Integer, preciounitario As Double
        For Each row As DataGridViewRow In dgMov.Rows
            If row.Cells("movcodigopadre").Value <> "" Then
                idCuenta = row.Cells("movidcuen").Value
                idCuentaPadre = row.Cells("movidcuentapadre").Value
                Get_Precio(idCuenta, idCuentaPadre, dtFecha.Value, idprecio, preciounitario)
                row.Cells("movidprecio").Value = idprecio
                row.Cells("movprecioT").Value = preciounitario
            End If
        Next
    End Sub

    Private Sub SerieFol_Omision(ByVal codConcepto As String)
        Dim fQue As String
        fQue = "SELECT CSERIEPO01,CNOFOLIO FROM MGW10006 WHERE CCODIGOC01='" & codConcepto & "'"
        Using fCom = New Odbc.OdbcCommand(fQue, FC_CONFOX)
            Using fCr = fCom.ExecuteReader
                fCr.Read()
                If fCr.HasRows Then
                    'txtSerie.Text = Trim(fCr("CSERIEPO01"))
                    txtFolio.Text = fCr("CNOFOLIO")
                End If
            End Using
        End Using
    End Sub

    Private Sub Carga_Orden()
        Dim dQue As String, estado As Integer

        dQue = "SELECT enviado_prove,estado,esanticipo,validado,idobra FROM zConsDocCampos 
                    WHERE iddocadw=" & _oIDDoc & " AND idsucursal=" & _oIDSucursal & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCr = dCom.ExecuteReader
                dCr.Read()

                If dCr.HasRows Then
                    D_IDObra = dCr("idobra")
                    cbObra.SelectedValue = D_IDObra
                    D_Documento.Iddoc = _oIDDoc
                    panelAciones.Enabled = True
                    btnEliminar.Enabled = True
                    dgMov.ReadOnly = True
                    lbenviado.Text = lbenviado.Text & IIf(dCr("enviado_prove") = 1, " Si", " No")
                    If dCr("estado") = 0 Then
                        estado = 3
                        lbEstatus.Text = lbEstatus.Text & " Autorizado Automatico"
                    Else
                        estado = dCr("estado")
                        lbEstatus.Text = lbEstatus.Text & " " & Get_Estatus(dCr("estado"))
                    End If
                    If Carga_Documento() = True Then
                        Carga_Movimientos()
                    Else
                        MsgBox("El Documento no existe.", vbExclamation, "Validación")
                    End If
                End If
            End Using
        End Using
        Bloquear_Documento(False)
        Bloquea_BotonesOrden(estado)
        Suma_importes()
    End Sub

    Private Function Carga_Documento() As Boolean
        Dim fQue As String, resp As Boolean
        resp = False
        fQue = "SELECT M06.CCODIGOC01 as codCon,M06.CNOMBREC01,M08.CFECHA,M02.CCODIGOC01,
                               M02.CRAZONSO01,M08.CSERIEDO01,M08.CFOLIO,M08.CIDMONEDA,
                               M08.CTIPOCAM01,M08.COBSERVA01 FROM MGW10008 M08 
                                INNER JOIN MGW10006 M06 ON M08.CIDCONCE01=M06.CIDCONCE01
                                INNER JOIN MGW10002 M02 ON M08.CIDCLIEN01=M02.CIDCLIEN01
                                WHERE M08.CIDDOCUM01=" & _oIDDoc & ""
        Using fCom = New Odbc.OdbcCommand(fQue, FC_CONFOX)
            Using fCr = fCom.ExecuteReader
                fCr.Read()
                If fCr.HasRows Then
                    resp = True
                    txtconcepto.Text = Trim(fCr("CNOMBREC01"))
                    txtconcepto.Tag = Trim(fCr("codCon"))
                    txtCodigo.Text = Trim(fCr("CCODIGOC01"))
                    txtNombre.Text = Trim(fCr("CRAZONSO01"))
                    cbSerie.SelectedValue = Trim(fCr("CSERIEDO01"))
                    txtFolio.Text = fCr("CFOLIO")
                    cbMoneda.SelectedValue = fCr("CIDMONEDA")
                    txtTipocambio.Text = Format(fCr("CTIPOCAM01"), Format_Moneda)
                    txtObervaciones.Text = Trim(fCr("COBSERVA01"))
                End If
            End Using
        End Using
        Return resp
    End Function

    Private Sub Carga_Movimientos()
        Dim dQue As String, fQue As String, idmov As Integer
        Dim dUnidad As String, dNombrecuenta As String

        dQue = "SELECT z.idmovadw,z.validado,z.idasocprecio,z.cantidad,z.precio,z.total,z.cantidaddisponible,
                z.totalpresupuesto,z.estado,p.id_cuenta,p.id_cuentapadre,p.codigo_cuenta,p.codigo_cuentapadre,p.unidad,p.precio as precioUni
                FROM zConsDoc_MovCampos z INNER JOIN zConsAsociacionesPrecios p ON z.idasocprecio=p.id
                WHERE iddocadw=" & _oIDDoc & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    idmov = dCr("idmovadw")
                    dUnidad = ""
                    dNombrecuenta = Get_nombreInsumo(dCr("codigo_cuenta"))
                    If D_dicUnidades.ContainsKey(dCr("unidad")) Then
                        dUnidad = D_dicUnidades.Item(dCr("unidad"))
                    End If
                    fQue = "SELECT CPRECIO,CUNIDADES,CPORCENT01,cimpuesto1,cporcent05,
                                    cretenci02,cporcent04,cretenci01,CTOTAL 
                            FROM MGW10010 WHERE CIDMOVIM01=" & idmov & ""
                    Using fCom = New Odbc.OdbcCommand(fQue, FC_CONFOX)
                        Using fCr = fCom.ExecuteReader
                            fCr.Read()
                            If fCr.HasRows Then
                                dgMov.Rows.Add(dCr("id_cuenta"), dCr("id_cuentapadre"),
                                      dCr("codigo_cuentapadre"), dCr("codigo_cuenta"),
                                      dNombrecuenta, 0, dCr("cantidaddisponible"), dUnidad, dCr("cantidad"), dCr("precio"),
                                      fCr("CPORCENT01"), fCr("cimpuesto1"),
                                      fCr("cporcent05"), fCr("cretenci02"),
                                      fCr("cporcent04"), fCr("cretenci01"), fCr("CTOTAL"), dCr("totalpresupuesto"), 0, dCr("precioUni"), "", dCr("idasocprecio"))
                            Else
                                ''pendiente
                            End If
                        End Using
                    End Using
                Loop
            End Using
        End Using
        Pinta_filas()
    End Sub

    Private Sub Pinta_filas()

        For Each row As DataGridViewRow In dgMov.Rows
            If row.Cells("movPre").Value > row.Cells("movprecioT").Value Then
                row.Cells("movprecioT").Style.BackColor = Color.Orange
            End If
            If row.Cells("movTota").Value > row.Cells("movimporteTo").Value Then
                row.Cells("movimporteTo").Style.BackColor = Color.Orange
            End If
        Next
    End Sub

    Private Sub Bloquea_BotonesOrden(ByVal estado As Integer)
        If estado = 3 Then
            btnEnviar.Enabled = True
        ElseIf estado = 1 Then
            btnEnviar.Enabled = False
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If D_Documento.Iddoc <> 0 Then
            If _oUsaComercial = True Then
            Else
                If MsgBox("Se eliminara el documento " & vbCrLf & txtconcepto.Text &
                            vbCrLf & "Folio: " & txtFolio.Text & " Serie: " &
                            cbSerie.Text, vbYesNoCancel, "Validación") = vbYes Then
                    Borrar_DocumentoADW(_oRutaDoc, CInt(D_Documento.Iddoc), False)
                    Borra_CamposExtras(CInt(D_Documento.Iddoc))
                    Limpiar_Orden()
                End If
            End If
            End If
    End Sub



    Private Function Get_nombreInsumo(ByVal dCodigo As String) As String
        Dim resp As String
        resp = ""
        For x = 0 To D_DtInsumos.Rows.Count - 1
            If dCodigo = D_DtInsumos.Rows(x).Item("codigo") Then
                resp = D_DtInsumos.Rows(x).Item("nombre_cuenta")
                Exit For
            End If
        Next
        Return resp
    End Function

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        MsgBox("Refesca la orden", vbInformation, "Pendiente")
    End Sub

    Private Sub btnVista_Click(sender As Object, e As EventArgs) Handles btnVista.Click
        MsgBox("Abre la orden preeliminar", vbInformation, "Pendiente")
    End Sub

    Private Sub btnNotificar_Click(sender As Object, e As EventArgs) Handles btnNotificar.Click
        MsgBox("Notifica de nuevo a quien autoriza", vbInformation, "Pendiente")
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        MsgBox("Enviar la orden al proveedor", vbInformation, "Pendiente")
    End Sub

    Private Sub btAddDoc_Click(sender As Object, e As EventArgs) Handles btAddDoc.Click
        MsgBox("Abre formulario para seleccionar documento.", vbInformation, "Pendiente")
    End Sub
End Class
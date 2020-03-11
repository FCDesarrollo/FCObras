Imports System.Data.SqlClient

Public Class frmAsocProductos
    Private D_Empresas As Collection
    Private D_Load As Boolean
    Private D_IDEmpresa As Integer
    Private D_IDSucursal As Integer
    Private D_IDObra As Integer
    Private D_Obras As Collection
    Private D_UsaComercial As Boolean

    Private _a_idempresa As Integer
    Private _a_idsucursal As Integer
    Private _a_idobra As Integer


    Private D_DvPro As DataView
    Private D_DvIns As DataView

    Public Property A_idsucursal As Integer
        Get
            Return _a_idsucursal
        End Get
        Set(value As Integer)
            _a_idsucursal = value
        End Set
    End Property

    Public Property A_idempresa As Integer
        Get
            Return _a_idempresa
        End Get
        Set(value As Integer)
            _a_idempresa = value
        End Set
    End Property

    Public Property A_idobra As Integer
        Get
            Return A_idobra
        End Get
        Set(value As Integer)
            _a_idobra = value
        End Set
    End Property

    Private Sub frmAsocProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.toltip.SetToolTip(btnDesa, "DesAsocia el Insumo seleccionado con el Producto ADW")
        Me.toltip.SetToolTip(btnadd, "Asocia el Insumo con el Producto Seleccionado")
        D_Empresas = New Collection
        D_Load = True
        D_Empresas = Carga_empresas()
        Llena_ComboEmpresa(D_Empresas, cbempresas)
        D_Load = False

        If _a_idempresa <> 0 Then
            D_IDEmpresa = _a_idempresa
            cbempresas.SelectedValue = D_IDEmpresa
            cbempresas.Enabled = False
            D_IDSucursal = _a_idsucursal
            cbsucursales.SelectedValue = D_IDSucursal
            cbsucursales.Enabled = False
            D_IDObra = _a_idobra
            cbObra.SelectedValue = D_IDObra
        End If
    End Sub

    Private Sub cbsucursales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsucursales.SelectedIndexChanged
        If D_Load = True Then Exit Sub
        D_IDSucursal = CInt(cbsucursales.SelectedValue)
        Limpia()

        If D_IDSucursal > 0 Then
            Cambio_Sucursal()
        End If

    End Sub

    Private Sub Cambio_Sucursal()
        Dim empresa As clEmpresa, sucursal As clSucursal, O_Obras As clObra
        For Each empresa In D_Empresas
            If empresa.Idempresa = D_IDEmpresa Then
                For Each sucursal In empresa.ColSucursales
                    If sucursal.Idsucursal = D_IDSucursal Then
                        D_UsaComercial = IIf(sucursal.Usacomercial = 1, True, False)
                        O_Obras = New clObra
                        O_Obras.Idsucursal = D_IDSucursal
                        D_Obras = O_Obras.Carga_Obras
                        D_Load = True
                        Carga_Obras()
                        D_Load = False

                        If D_UsaComercial = False Then
                            FC_ConexionFOX(sucursal.BddAdw)

                        Else
                            ''PENDIENTE
                        End If
                        Exit For
                    End If
                Next sucursal
                Exit For
            End If
        Next empresa
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

    Private Sub Carga_Insumos()
        Dim dQue As String, dData As New DataTable, filAsociado As String
        D_DvIns = New DataView
        dQue = "select c.id,c.codigo,c.nombre_cuenta,a.codigoadw FROM zConsCuentas c 
		        INNER JOIN zConsObras o ON c.id_obra=o.id
		        LEFT JOIN zConsInsumosAsoc a ON c.id=a.idcuenta 
		        WHERE c.tipoinsumo=1 and o.idsucursal=" & D_IDSucursal & " and c.id_obra=" & D_IDObra & ""
        Using dCom = New SqlDataAdapter(dQue, DConexiones("CON"))
            dCom.Fill(dData)
        End Using

        D_DvIns = dData.DefaultView
        With dgCodigos
            .DataSource = D_DvIns

            .Columns("id").Visible = False
            .Columns("codigo").Width = 120
            .Columns("codigo").HeaderText = "Codigo Insumo"
            .Columns("nombre_cuenta").Width = 150
            .Columns("nombre_cuenta").HeaderText = "Nombre"
            .Columns("codigoadw").Width = 120
            .Columns("codigoadw").HeaderText = "Codigo ADW"
        End With
        filAsociado = IIf(rbasoc.Checked, "codigoadw<>''", "codigoadw is null or codigoadw=''")
        D_DvIns.RowFilter = filAsociado
    End Sub

    Private Sub Carga_ProductosADW()
        Dim fQue As String, dData As New DataTable
        D_DvPro = New DataView
        fQue = "SELECT STRTRAN(CCODIGOP01,' ','') as CodigoADW,STRTRAN(CNOMBREP01,' ','') as Nombre FROM MGW10005 WHERE CIDPRODU01>0"
        Using fCom = New Odbc.OdbcDataAdapter(fQue, FC_CONFOX)
            fCom.Fill(dData)
        End Using

        D_DvPro = dData.DefaultView
        dgProductos.DataSource = D_DvPro

        dgProductos.Columns("CodigoADW").HeaderText = "Codigo ADW"
        dgProductos.Columns("CodigoADW").Width = 120
        dgProductos.Columns("Nombre").Width = 150
    End Sub

    Private Sub Cambio_Empresa()
        Dim empresa As clEmpresa
        dgCodigos.Rows.Clear()
        dgProductos.Rows.Clear()
        cbsucursales.DataSource = Nothing
        cbsucursales.Items.Clear()
        For Each empresa In D_Empresas
            If empresa.Idempresa = D_IDEmpresa Then
                If IsNothing(DConexiones) Then FC_GetCons()
                DConexiones("CON").ChangeDatabase(empresa.BddCont)
                D_Load = True
                Llena_ComboSucursal(empresa.ColSucursales, cbsucursales)
                D_Load = False
                Exit For
            End If
        Next empresa
    End Sub

    Private Sub cbempresas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbempresas.SelectedIndexChanged
        If D_Load = True Then Exit Sub
        Limpia()
        D_IDEmpresa = CInt(cbempresas.SelectedValue)
        If D_IDEmpresa > 0 Then
            Cambio_Empresa()
        End If
    End Sub

    Private Sub txtbusadw_TextChanged(sender As Object, e As EventArgs) Handles txtbusadw.TextChanged
        If Not IsNothing(D_DvPro) Then
            D_DvPro.RowFilter = "Nombre LIKE '%" & txtbusadw.Text & "%' or CodigoADW LIKE '%" & txtbusadw.Text & "%'"
        End If

    End Sub

    Private Sub cbObra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbObra.SelectedIndexChanged
        If D_Load = True Then Exit Sub
        D_IDObra = CInt(cbObra.SelectedValue)
        Limpia()

        If D_IDObra <> 0 Then
            If D_UsaComercial = False Then
                Carga_Insumos()
                Carga_ProductosADW()
            End If
        End If
    End Sub

    Private Sub Limpia()
        dgProductos.DataSource = Nothing
        dgCodigos.DataSource = Nothing
        D_DvPro = Nothing
        D_DvIns = Nothing
        txtBus.Text = ""
        txtbusadw.Text = ""
    End Sub

    Private Sub rbsinasoc_CheckedChanged(sender As Object, e As EventArgs) Handles rbsinasoc.CheckedChanged
        Dim filAsociado As String
        If Not IsNothing(D_DvIns) Then
            filAsociado = IIf(rbasoc.Checked, "codigoadw<>''", "codigoadw is null or codigoadw=''")
            D_DvIns.RowFilter = filAsociado
        End If
    End Sub

    Private Sub rbasoc_CheckedChanged(sender As Object, e As EventArgs) Handles rbasoc.CheckedChanged
        Dim filAsociado As String
        If Not IsNothing(D_DvIns) Then
            filAsociado = IIf(rbasoc.Checked, "codigoadw<>''", "codigoadw is null or codigoadw=''")
            D_DvIns.RowFilter = filAsociado
        End If
    End Sub

    Private Sub txtBus_TextChanged(sender As Object, e As EventArgs) Handles txtBus.TextChanged
        Dim filAsociado As String
        If Not IsNothing(D_DvIns) Then
            filAsociado = IIf(rbasoc.Checked, "codigoadw<>''", "(codigoadw is null or codigoadw='')")
            D_DvIns.RowFilter = filAsociado & " and (codigo LIKE '%" & txtBus.Text & "%' or nombre_cuenta LIKE '%" & txtBus.Text & "%')"
        End If
    End Sub

    Private Sub Asocia_Insumo()
        Dim dQue As String, aIDCuenta As Integer, aCodInsumo As String, aCodADW As String
        If dgCodigos.CurrentRow Is Nothing Then
            MsgBox("No ha seleccionado Insumo", vbInformation, "Validación")
            Exit Sub
        End If
        If dgProductos.CurrentRow Is Nothing Then
            MsgBox("No ha seleccionado Producto ADW", vbInformation, "Validación")
            Exit Sub
        End If
        aIDCuenta = dgCodigos.Item(0, dgCodigos.CurrentRow.Index).Value
        aCodInsumo = dgCodigos.Item(1, dgCodigos.CurrentRow.Index).Value
        aCodADW = dgProductos.Item(0, dgProductos.CurrentRow.Index).Value
        Try
            dQue = "INSERT INTO zConsInsumosAsoc(idcuenta,idsucursal,codigoinsumo,codigoadw)
                        VALUES(@idcuenta, @idsucursal, @codigoinsumo, @codigoadw)"
            Using dCom = New SqlCommand(dQue, DConexiones("CON"))
                dCom.Parameters.AddWithValue("idcuenta", aIDCuenta)
                dCom.Parameters.AddWithValue("idsucursal", D_IDSucursal)
                dCom.Parameters.AddWithValue("codigoinsumo", aCodInsumo)
                dCom.Parameters.AddWithValue("codigoadw", aCodADW)
                dCom.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Error al asociar Insumo-Producto. " & vbCrLf & ex.Message, vbInformation, "Validación")
        End Try

    End Sub

    Private Sub DesAsocia_Insumo()
        Dim dQue As String, aIDCuenta As Integer
        If dgCodigos.CurrentRow Is Nothing Then
            MsgBox("No ha seleccionado Insumo", vbInformation, "Validación")
            Exit Sub
        End If
        aIDCuenta = dgCodigos.Item(0, dgCodigos.CurrentRow.Index).Value
        dQue = "DELETE FROM zConsInsumosAsoc WHERE idcuenta=@idcuenta AND idsucursal=@idsucursal"
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            dCom.Parameters.AddWithValue("idcuenta", aIDCuenta)
            dCom.Parameters.AddWithValue("idsucursal", D_IDSucursal)
            dCom.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Asocia_Insumo()
        Carga_Insumos()
    End Sub

    Private Sub btnDesa_Click(sender As Object, e As EventArgs) Handles btnDesa.Click
        DesAsocia_Insumo()
        Carga_Insumos()
    End Sub
End Class
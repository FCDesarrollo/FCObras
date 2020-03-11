Imports System.Data.SqlClient

Public Class frmConfig
    Private Con As New SqlConnection
    Private sBanLoad As Integer

    ''VARIABLES PARA CONCEPTOS
    Private D_load As Boolean
    Private colEmpresas As Collection
    Private id_Empresa As Integer
    Private id_Sucursal As Integer
    Private usa_comercial As Boolean
    Private d_DtConceptos As New DataTable

    Private conInfo As String = "Intalación " & vbCrLf & "Guarda la configuración Principal para los Modulos."
    Private Sub FrmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tooltip.SetToolTip(Me.btnADD, "Agregar Empresa")
        tooltip.SetToolTip(Me.btnDel, "Elima la empresa seleccionada")
        tooltip.SetToolTip(Me.btAddCon, "Agregar Concepto")
        tooltip.SetToolTip(Me.btDelCon, "Elima el concepto seleccionado")
        Dim arrDatos() As String
        sBanLoad = 0
        Carga_TipoCon()
        'If My.Settings.ProductoRegistrado = False And My.Settings.Serial = "" Then
        '    btnActiva.Visible = True
        'Else
        '    btnActiva.Visible = False
        'End If

        arrDatos = FC_GetDatos()
        Me.TBSql.Text = arrDatos(0)
        Me.TBUID.Text = arrDatos(1)
        Me.TBSA.Text = arrDatos(2)

        TBBDDGen.Text = FC_DATABASE

        txtSDK.Text = FC_RutaSDKAdmin
        txtEmpresas.Text = FC_RutaEmpresasAdmin

        If Trim(Join(arrDatos)) <> "" Then
            If VerificaTablas() = True Then
                'dgModulos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                mpConfig.SelectedIndex = 1
            End If
        End If
    End Sub

    Private Sub BtnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim frm As New frmEmpresasCont
        frm.ShowDialog()
        frm.Dispose()
        Carga_empresas_configuradas()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtRazon.Text = "" Or txtRfc.Text = "" Then
            linfo2.Visible = True
        Else
            fCError = FC_Conexion()
            If fCError <> 0 Then Exit Sub
            GL_cParam = New clParametros
            GL_cParam.Api = mApi
            GL_cParam.Userapi = FCConstruccion.UserAdmin
            GL_cParam.Passapi = FCConstruccion.PassAdmin
            GL_cParam.RDescarga = FC_RutaModulos
            GL_cParam.Ufecha = Strings.Format(Formato_FechaYear, Date.Now)
            GL_cParam.Nomclien = txtRazon.Text
            GL_cParam.Rfclien = txtRfc.Text
            GL_cParam.Equipo = ""

            If GL_cParam.SaveParam = True Then
                linfo2.Visible = False
                mpConfig.SelectedIndex = 2
            End If
        End If
    End Sub

    Public Sub Carga_TipoCon()
        Dim dt As DataTable
        Dim dr As DataRow

        dt = New DataTable("tipos")
        dt.Columns.Add("id")
        dt.Columns.Add("nombre")

        dr = dt.NewRow
        dr(0) = 0
        dr(1) = "NO AUTORIZADO"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr(0) = 1
        dr(1) = "AUTORIZADO"
        dt.Rows.Add(dr)

        cbtipo.DataSource = dt
        cbtipo.DisplayMember = "nombre"
        cbtipo.ValueMember = "id"
    End Sub


    Private Sub MpConfig_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mpConfig.SelectedIndexChanged
        If mpConfig.SelectedIndex = 1 And (sBanLoad = 0 Or sBanLoad = 2 Or sBanLoad = 1) Then
            If VerificaTablas() = False Then
                MsgBox("Faltan Tablas por crear volver a darle Instalar para crearlas.", vbInformation, "Validación")
                linfo.Text = "Faltan Tablas por crear volver a darle Instalar para crearlas."
                mpConfig.SelectedIndex = 0
            Else
                GL_cParam = New clParametros
                GL_cParam.loadParam()
                Me.txtRazon.Text = GL_cParam.Nomclien
                Me.txtRfc.Text = GL_cParam.Rfclien
                Carga_UnidadesEInsumos()
                sBanLoad = 1
            End If
        ElseIf mpConfig.SelectedIndex = 2 And (sBanLoad = 1 Or sBanLoad = 2) Then
            If GL_cParam.ValidaParametros = False Then
                linfo2.Visible = True
                mpConfig.SelectedIndex = 1
            Else
                Carga_empresas_configuradas()
                sBanLoad = 2
            End If
        ElseIf mpConfig.SelectedIndex = 3 And (sBanLoad = 1 Or sBanLoad = 2) Then
            If GL_cParam.ValidaParametros = False Then
                linfo2.Visible = True
                mpConfig.SelectedIndex = 1
            Else
                D_load = True
                Carga_EmpresasConceptos()
                D_load = False
                sBanLoad = 2
            End If
        Else
            mpConfig.SelectedIndex = 0
        End If
    End Sub

    Private Sub Carga_UnidadesEInsumos()
        Dim dQue As String
        dgUnidades.Rows.Clear()
        dgInsumos.Rows.Clear()
        dQue = "SELECT  id,clave_unidad,nombre_unidad FROM ConsUnidades"
        Using dCom = New SqlCommand(dQue, FC_Con)
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    dgUnidades.Rows.Add(dCr("id"), dCr("clave_unidad"), dCr("nombre_unidad"))
                Loop
            End Using
        End Using

        dQue = "SELECT  id, codigo_insumo, nombre_insumo FROM ConsInsumos"
        Using dCom = New SqlCommand(dQue, FC_Con)
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    dgInsumos.Rows.Add(dCr("id"), dCr("codigo_insumo"), dCr("nombre_insumo"))
                Loop
            End Using
        End Using
    End Sub

    Private Sub Carga_EmpresasConceptos()

        colEmpresas = Carga_empresas()
        Llena_ComboEmpresa(colEmpresas, cbempresas)
    End Sub

    Private Sub Carga_empresas_configuradas()
        Dim dQue As String, dcont As Integer
        fCError = FC_Conexion()
        If fCError <> 0 Then Exit Sub
        dgEmpresas.Rows.Clear()
        dQue = "SELECT IdEmpresa,Empresa,ctBDD FROM ConsEmpresas"
        Using dCom = New SqlCommand(dQue, FC_Con)
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    dcont = Get_NumSucursales(dCr("IdEmpresa"))
                    dgEmpresas.Rows.Add(dCr("IdEmpresa"), dCr("Empresa"), dCr("ctBDD"), dcont)
                Loop
            End Using
        End Using
        dgEmpresas.ClearSelection()
    End Sub

    Private Function Get_NumSucursales(ByVal dIDEmpresa As Integer) As Integer
        Dim numSuc As Integer, nQue As String

        nQue = "SELECT COUNT(*) as num FROM ConsRutasADW WHERE IDEmpresa=" & dIDEmpresa & ""
        Using nCom = New SqlCommand(nQue, FC_Con)
            Using nCr = nCom.ExecuteReader
                nCr.Read()
                If nCr.HasRows Then
                    numSuc = nCr("num")
                End If
            End Using
        End Using

        Get_NumSucursales = numSuc
    End Function

    Private Sub BtInstala_Click(sender As Object, e As EventArgs) Handles BtInstala.Click
        Dim lError As Long, cQue As String

        'validaciones
        If Trim(TBSql.Text) = "" Or Trim(TBSA.Text) = "" Or Trim(Me.TBUID.Text) = "" Or Trim(TBBDDGen.Text) = "" Then
            MsgBox("Debe configurar todos los elementos solicitados", vbExclamation, "Validación")
            Exit Sub
        End If

        On Error Resume Next
        Con = New SqlConnection()
        Con.ConnectionString = "Data Source=" + Trim(TBSql.Text) + " ;" &
                    "User Id=" + Trim(TBUID.Text) + ";Password=" + Trim(TBSA.Text)

        Con.Open()

        If Con.State = ConnectionState.Closed Then
            MsgBox("Imposible realizar la conexión SQL: " & vbCrLf & Err.Description, vbCritical, "Conexión SQL")
            Exit Sub
        Else
            Con.Close()
        End If

        FC_SetDatos(Trim(TBSql.Text), Trim(TBUID.Text), Trim(TBSA.Text))
        If TBBDDGen.Text <> "" Then FC_DATABASE = Trim(TBBDDGen.Text)

        If txtSDK.Text <> "" Then FC_RutaSDKAdmin = txtSDK.Text
        If txtEmpresas.Text <> "" Then FC_RutaEmpresasAdmin = txtEmpresas.Text
        'FC_RutaModulos = Application.StartupPath

        FC_CrearBDD()
        'If TBBDDGen.Text <> "" Then FC_DATABASE = Trim(TBBDDGen.Text)
        CrearTablasPremium()
        On Error GoTo 0
        If sSystema = 0 Then
            cQue = "IF NOT EXISTS (SELECT idusuario FROM FCUser WHERE nombre=@nom)
                        BEGIN INSERT INTO FCUser(nombre,apellido_p,apellido_m,usuario,password,tipo,status)
                                VALUES(@nom, @nom, @nom, @use, @pass, @tip , @status) END"
            Using cCom = New SqlCommand(cQue, FC_Con)
                cCom.Parameters.AddWithValue("@nom", "ADMINISTRADOR")
                cCom.Parameters.AddWithValue("@use", FCConstruccion.UserAdmin)
                cCom.Parameters.AddWithValue("@pass", Eramake.eCryptography.Encrypt(FCConstruccion.PassAdmin))
                cCom.Parameters.AddWithValue("@tip", 0)
                cCom.Parameters.AddWithValue("@status", 1)
                cCom.ExecuteNonQuery()
            End Using
            GL_cUsuario = New clUsuario
            GL_cUsuario.login(FCConstruccion.UserAdmin, FCConstruccion.PassAdmin)
        End If

        linfo.Text = conInfo
        MsgBox("Datos generales configurados.", vbInformation, "Instalación Terminada")
        mpConfig.SelectedIndex = 1
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim fil As Integer
        If dgEmpresas.CurrentRow Is Nothing Then Exit Sub
        fil = dgEmpresas.CurrentRow.Index
        If MsgBox("Se va eliminar la empresa " & dgEmpresas.Item(1, fil).Value &
                        vbCrLf & "¿Desea continuar?", vbYesNo, "Validación") = vbYes Then
            MsgBox(dgEmpresas.Item(0, fil).Value)
        End If
    End Sub

    Private Sub dgEmpresas_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEmpresas.CellContentDoubleClick
        If dgEmpresas.CurrentRow Is Nothing Then Exit Sub
        Dim frm As New frmEmpresasAdw
        If Me.dgEmpresas.Columns(e.ColumnIndex).Name = "empnum" Then
            frm.ShowDialog()
            frm.Dispose()
            Carga_empresas_configuradas()
        End If
    End Sub


    Private Sub cbempresas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbempresas.SelectedIndexChanged

        If D_load = True Then Exit Sub
        id_Empresa = CInt(cbempresas.SelectedValue)
        If id_Empresa > 0 Then
            Cambio_Empresa()
        End If
    End Sub

    Private Sub Cambio_Empresa()
        Dim empresa As clEmpresa
        dglisConceptos.Rows.Clear()
        cbsucursales.DataSource = Nothing
        cbsucursales.Items.Clear()
        For Each empresa In colEmpresas
            If empresa.Idempresa = id_Empresa Then
                If IsNothing(DConexiones) Then FC_GetCons()
                DConexiones("CON").ChangeDatabase(empresa.BddCont)
                Conceptos_Guardados()
                D_load = True
                Llena_ComboSucursal(empresa.ColSucursales, cbsucursales)
                D_load = False
                Exit For
            End If
        Next empresa
    End Sub

    Private Sub Conceptos_Guardados()
        Dim dQue As String, nomtipo As String
        dglisConceptos.Rows.Clear()
        dQue = "SELECT idsucursal,nombresucursal,idconcepto,codigo,nombre,tipo FROM zConsConceptos"
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    nomtipo = IIf(dCr("tipo") = 0, "NO AUTORIZADO", "AUTORIZADO")
                    dglisConceptos.Rows.Add(dCr("idsucursal"), nomtipo, dCr("idconcepto"),
                                            dCr("nombresucursal"), dCr("codigo"), dCr("nombre"))
                Loop
            End Using
        End Using
    End Sub

    Private Sub cbsucursales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsucursales.SelectedIndexChanged
        If D_load = True Then Exit Sub
        id_Sucursal = CInt(cbsucursales.SelectedValue)

        If id_Sucursal > 0 Then
            Cambio_Sucursal()
        End If
    End Sub

    Private Sub Cambio_Sucursal()
        Dim empresa As clEmpresa, sucursal As clSucursal
        For Each empresa In colEmpresas
            If empresa.Idempresa = id_Empresa Then
                For Each sucursal In empresa.ColSucursales
                    If sucursal.Idsucursal = id_Sucursal Then
                        FC_ConexionFOX(sucursal.BddAdw)
                        usa_comercial = IIf(sucursal.Usacomercial = 1, True, False)
                        Carga_Conceptos()
                        Exit For
                    End If
                Next sucursal
                Exit For
            End If
        Next empresa
    End Sub

    Private Sub Carga_Conceptos()
        Dim fQue As String

        fQue = "SELECT CIDCONCE01 as id,CCODIGOC01 as Codigo,CNOMBREC01 as Nombre FROM MGW10006"
        Using cCom = New Odbc.OdbcDataAdapter(fQue, FC_CONFOX)
            cCom.Fill(d_DtConceptos)
        End Using
    End Sub

    Private Sub btAddCon_Click(sender As Object, e As EventArgs) Handles btAddCon.Click
        Dim frm As New frmConceptos, nomtipo As String
        If id_Empresa <> 0 And id_Sucursal <> 0 Then
            frm.C_dtCon = d_DtConceptos
            frm.ShowDialog()
            If frm.C_Codigo <> "" And frm.C_Nombre <> "" Then
                If Guarda_Concepto(frm.C_id, frm.C_Codigo, frm.C_Nombre) <> 0 Then
                    nomtipo = IIf(cbtipo.SelectedValue = 0, "NO AUTORIZADO", "AUTORIZADO")
                    dglisConceptos.Rows.Add(id_Sucursal, nomtipo, frm.C_id, cbsucursales.Text, frm.C_Codigo, frm.C_Nombre)
                End If
            End If
        End If
    End Sub

    Private Function Guarda_Concepto(ByVal cid As Integer, ByVal cCodigo As String, ByVal cNombre As String) As Integer
        Dim dQue As String, cantidad As Integer, dtipo As Integer

        dtipo = cbtipo.SelectedValue
        dQue = "IF NOT EXISTS (SELECT idsucursal FROM zConsConceptos WHERE idsucursal=@idsucursal  and tipo=@tipo)
                        BEGIN INSERT INTO zConsConceptos(idsucursal, nombresucursal,idconcepto,codigo, nombre, tipo)
                                VALUES(@idsucursal, @nombresucursal,@id, @codigo, @nombre, @tipo) SELECT SCOPE_IDENTITY() END"
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            dCom.Parameters.AddWithValue("idsucursal", id_Sucursal)
            dCom.Parameters.AddWithValue("nombresucursal", cbsucursales.Text)
            dCom.Parameters.AddWithValue("id", cid)
            dCom.Parameters.AddWithValue("codigo", cCodigo)
            dCom.Parameters.AddWithValue("nombre", cNombre)
            dCom.Parameters.AddWithValue("tipo", dtipo)
            Integer.TryParse(dCom.ExecuteScalar, cantidad)
        End Using
        Return cantidad
    End Function

    Private Sub Eliminar_Concepto(ByVal eIDsuc As Integer, ByVal eId As String, ByVal eTipo As Integer)
        Dim dQue As String

        dQue = "DELETE FROM zConsConceptos WHERE idsucursal=" & eIDsuc & " AND idconcepto='" & eId & "' and tipo=" & eTipo & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            dCom.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub btDelCon_Click(sender As Object, e As EventArgs) Handles btDelCon.Click
        Dim etipo As Integer
        If id_Empresa <> 0 Then
            If dglisConceptos.CurrentRow Is Nothing Then Exit Sub

            If dglisConceptos.CurrentRow.Index >= 0 Then
                If MsgBox("Se elimina el concepto " &
                          dglisConceptos.Item(5, dglisConceptos.CurrentRow.Index).Value & vbCrLf & "¿Desea Continuar?", vbYesNoCancel, "Validación") = vbYes Then
                    etipo = IIf(dglisConceptos.Item(1, dglisConceptos.CurrentRow.Index).Value = "AUTORIZADO", 1, 0)
                    Eliminar_Concepto(dglisConceptos.Item(0, dglisConceptos.CurrentRow.Index).Value, dglisConceptos.Item(2, dglisConceptos.CurrentRow.Index).Value, etipo)
                    dglisConceptos.Rows.Remove(dglisConceptos.CurrentRow)
                End If
            End If
        End If
    End Sub

    Private Sub btnAddUnidad_Click(sender As Object, e As EventArgs) Handles btnAddUnidad.Click
        Dim frm As New frmAgrega
        frm.A_tipo = 1
        frm.ShowDialog()
        Carga_UnidadesEInsumos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New frmAgrega
        frm.A_tipo = 2
        frm.ShowDialog()
        Carga_UnidadesEInsumos()
    End Sub

    Private Sub Elimina_unidadOInsumo(ByVal eTipo As Integer, ByVal id As Integer)
        Dim dQue As String = ""

        If eTipo = 1 Then
            dQue = "DELETE FROM ConsUnidades WHERE id=@id"
        ElseIf eTipo = 2 Then
            dQue = "DELETE FROM ConsInsumos WHERE id=@id"
        End If
        Using dCom = New SqlCommand(dQue, FC_Con)
            dCom.Parameters.AddWithValue("id", id)
            dCom.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub btnDelUnidad_Click(sender As Object, e As EventArgs) Handles btnDelUnidad.Click
        If Not dgUnidades.CurrentRow Is Nothing Then
            If MsgBox("Se va eliminar la unidad " &
                      dgUnidades.Item(2, dgUnidades.CurrentRow.Index).Value &
                      vbCrLf & "¿Desea Continuar?", vbYesNoCancel, "Validación") = vbYes Then
                Elimina_unidadOInsumo(1, dgUnidades.Item(0, dgUnidades.CurrentRow.Index).Value)
                Carga_UnidadesEInsumos()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not dgInsumos.CurrentRow Is Nothing Then
            If MsgBox("Se va eliminar el  insumo " &
                      dgInsumos.Item(2, dgInsumos.CurrentRow.Index).Value &
                      vbCrLf & "¿Desea Continuar?", vbYesNoCancel, "Validación") = vbYes Then
                Elimina_unidadOInsumo(2, dgInsumos.Item(0, dgInsumos.CurrentRow.Index).Value)
                Carga_UnidadesEInsumos()
            End If
        End If
    End Sub

    Private Sub dgEmpresas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEmpresas.CellDoubleClick
        If dgEmpresas.CurrentRow Is Nothing Then Exit Sub
        Dim frm As New frmEmpresasAdw
        If Me.dgEmpresas.Columns(e.ColumnIndex).Name = "empnum" Then
            frm.E_IDEmpresa = dgEmpresas.Item(0, e.RowIndex).Value
            frm.E_NombreEmpresa = dgEmpresas.Item(1, e.RowIndex).Value
            frm.ShowDialog()
            frm.Dispose()
            Carga_empresas_configuradas()
        End If
    End Sub


End Class
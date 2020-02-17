Imports System.Data.SqlClient

Public Class frmConfig
    Private Con As New SqlConnection
    Private sBanLoad As Integer

    Private conInfo As String = "Intalación " & vbCrLf & "Guarda la configuración Principal para los Modulos."
    Private Sub FrmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tooltip.SetToolTip(Me.btnADD, "Agregar Empresa")
        tooltip.SetToolTip(Me.btnDel, "Elima la empresa seleccionada")
        Dim arrDatos() As String
        sBanLoad = 0
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
            fError = FC_Conexion()
            If fError <> 0 Then Exit Sub
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
        Else
            mpConfig.SelectedIndex = 0
        End If
    End Sub

    Private Sub Carga_empresas_configuradas()
        Dim dQue As String, dcont As Integer
        fError = FC_Conexion()
        If fError <> 0 Then Exit Sub
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
        FC_RutaModulos = Application.StartupPath

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
        frm.ShowDialog()
        frm.Dispose()
        Carga_empresas_configuradas()
    End Sub
End Class
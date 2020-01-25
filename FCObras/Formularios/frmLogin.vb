﻿Public Class frmLogin
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arrDatos() As String

        TBUser.Text = FCConstruccion.UserAdmin
        TBPass.Text = FCConstruccion.PassAdmin

        arrDatos = FC_GetDatos()


        If Trim(Join(arrDatos)) = "" Then
            sSystema = 0
            TBUser.Text = FCConstruccion.UserAdmin
            TBPass.Text = FCConstruccion.PassAdmin
        ElseIf VerificaTablas() = False Then
            sSystema = 0
            TBUser.Text = FCConstruccion.UserAdmin
            TBPass.Text = FCConstruccion.PassAdmin
        Else
            sSystema = 1
            fError = FC_Conexion()

        End If
    End Sub

    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        If Me.TBUser.Text <> "" And Me.TBPass.Text <> "" Then
            If VerificaUsuario() = True Then
                If EstaAbierto(frmPrincipal) = True Then
                    frmPrincipal.Close()
                End If
                frmPrincipal.Show()
                Me.Close()
            Else
                MsgBox("El Usuario o Contraseña es Incorrecto.", MsgBoxStyle.Exclamation, "Validación")
            End If
        End If
    End Sub

    Private Function VerificaUsuario() As Boolean

        VerificaUsuario = False
        If FCConstruccion.sSystema = 0 Then
            If Me.TBUser.Text = FCConstruccion.UserAdmin And Me.TBPass.Text = FCConstruccion.PassAdmin Then
                VerificaUsuario = True
            End If
        ElseIf FCConstruccion.sSystema = 1 Then
            fError = FC_Conexion()
            'cUsuario = New clUsuario
            'VerificaUsuario = cUsuario.login(Me.TBUser.Text, Eramake.eCryptography.Encrypt(Me.TBPass.Text))
        End If
    End Function

    Private Sub TBUser_TextChanged(sender As Object, e As EventArgs) Handles TBUser.TextChanged
        Me.TBUser.Text = UCase(Me.TBUser.Text)
        Me.TBUser.SelectionStart = Me.TBUser.TextLength + 1
    End Sub
End Class
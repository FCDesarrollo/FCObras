Public Class frmPrincipal

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub MuserChan_Click(sender As Object, e As EventArgs) Handles MuserChan.Click
        frmLogin.Show()
        Me.Refresh()
    End Sub

    Private Sub MuserLog_Click(sender As Object, e As EventArgs) Handles MuserLog.Click
        Me.Close()
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(228, 227, 228)
        'BloqueaMenu()
        CargaMenu()
        If GL_cUsuario IsNot Nothing Then
            Me.Text = "Inicio -  Usuario: " & GL_cUsuario.Nombreuser & " " & GL_cUsuario.Apellidop
        End If
    End Sub

    Private Sub BloqueaMenu()
        For Each oToolStripButton In PMenu.Items
            oToolStripButton.enabled = False
        Next
        MUser.Enabled = True
        MuserADD.Enabled = False
    End Sub

    Private Sub CargaMenu()
        ' Dim numMod As Integer

RegresaMenu:
        If FCConstruccion.sSystema = 0 Then
            MConfig.Enabled = True
        ElseIf FCConstruccion.sSystema = 1 Then
            'numMod = GetNumMod()
            'If numMod = 0 Then
            '    MsgBox("No se han agregado los Modulos.", vbInformation, "Validación")
            '    sSystema = 0
            '    GoTo RegresaMenu
            'Else
            'MostrarMenu()
            'End If
        End If
    End Sub

    Private Sub MostrarMenu()
        Dim numPer As Integer

        numPer = GetNumPermisoClien()
        If GL_cUsuario.Tipo = tAdmin Then MConfig.Enabled = True
        If (GL_cUsuario.Tipo = tAdmin Or GL_cUsuario.Tipo = tSupervisor) _
                And numPer > 0 Then MuserADD.Enabled = True
        For Each modu In GL_cUsuario.Modper
            For Each oToolStripButton In PMenu.Items
                If oToolStripButton.tag = modu.Idmodulo Then
                    oToolStripButton.enabled = IIf(modu.Permisouser = 1, True, False)
                    Exit For
                End If
            Next
        Next modu
    End Sub

    Private Sub MObras_Click(sender As Object, e As EventArgs) Handles MCatalogos.Click
        'Dim hijoObr As New frmConstruccion
        'If EstaAbierto(hijoObr) = False Then
        '    hijoObr.MdiParent = Me
        '    hijoObr.Show()
        'Else
        '    hijoObr.BringToFront()
        'End If
    End Sub

    Private Sub MConfig_Click(sender As Object, e As EventArgs) Handles MConfig.Click
        Dim frm As New frmConfig
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Sub ObrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ObrasToolStripMenuItem.Click
        Dim hijoObr As New frmObras
        If EstaAbierto(hijoObr) = False Then
            hijoObr.MdiParent = Me
            hijoObr.Show()
        Else
            hijoObr.BringToFront()
        End If

    End Sub

    Private Sub OrdenesDeCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenesDeCompraToolStripMenuItem.Click
        Dim hijoObr As New frmOrdenes
        If EstaAbierto(hijoObr) = False Then
            hijoObr.MdiParent = Me
            hijoObr.Show()
        Else
            hijoObr.BringToFront()
        End If
    End Sub

    Private Sub ClasificacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClasificacionesToolStripMenuItem.Click
        Dim frm As New frmClasificacion
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Sub TiposInsumosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposInsumosToolStripMenuItem.Click
        Dim frm As New frmAgregaCat
        frm.A_tipo = 2
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Sub UnidadesDeMedidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadesDeMedidaToolStripMenuItem.Click
        Dim frm As New frmAgregaCat
        frm.A_tipo = 1
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Sub InsumosProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsumosProductosToolStripMenuItem.Click
        Dim frm As New frmAsocProductos
        frm.ShowDialog()
        frm.Dispose()
    End Sub
End Class
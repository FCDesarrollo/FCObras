Imports System.Data.SqlClient

Public Class frmConstruccion
    Private D_Empresas As Collection
    Private D_Load As Boolean
    Private D_IDEmpresa As Integer
    Private Sub CObra_Click(sender As Object, e As EventArgs) Handles CObra.Click
        Dim frm As New frmObras
        frm.ShowDialog()
    End Sub

    Private Sub FrmConstruccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        D_Empresas = New Collection
        D_Load = True
        D_Empresas = Carga_empresas()
        Llena_ComboEmpresa(D_Empresas, cbempresas)
        D_Load = False
    End Sub

    Private Sub Cbempresas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbempresas.SelectedIndexChanged
        If D_Load = True Then Exit Sub
        D_IDEmpresa = CInt(cbempresas.SelectedValue)
        If D_IDEmpresa > 0 Then
            Cambio_Empresa()
        End If
    End Sub

    Private Sub Cambio_Empresa()
        Dim empresa As clEmpresa
        dgOrdenes.Rows.Clear()
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

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

    End Sub





End Class
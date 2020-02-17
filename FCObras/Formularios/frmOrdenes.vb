Imports System.Data.SqlClient

Public Class frmOrdenes
    Private D_Empresas As Collection
    Private D_Load As Boolean
    Private D_IDEmpresa As Integer
    Private D_IDSucursal As Integer
    Private D_UsaComercial As Boolean
    Private Sub CObra_Click(sender As Object, e As EventArgs)
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

    Private Sub Cambio_Sucursal()
        Dim empresa As clEmpresa, sucursal As clSucursal
        For Each empresa In D_Empresas
            If empresa.Idempresa = D_IDEmpresa Then
                For Each sucursal In empresa.ColSucursales
                    If sucursal.Idsucursal = D_IDSucursal Then
                        FC_ConexionFOX(sucursal.BddAdw)
                        D_UsaComercial = IIf(sucursal.Usacomercial = 1, True, 0)
                        Exit For
                    End If
                Next sucursal
                Exit For
            End If
        Next empresa
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim frm As New frmOrden
        If D_IDSucursal > 0 Then
            frm.OIDSucursal = D_IDSucursal
            frm.ShowDialog()
            frm.Dispose()
        Else
            MsgBox("Seleccione una sucursal.", vbInformation, "Validación")
        End If
    End Sub

    Private Sub Cbsucursales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsucursales.SelectedIndexChanged
        If D_Load = True Then Exit Sub
        D_IDSucursal = CInt(cbsucursales.SelectedValue)
        dgOrdenes.Rows.Clear()

        If D_IDSucursal > 0 Then
            'Cambio_Sucursal(idsucursal)
        End If
    End Sub
End Class
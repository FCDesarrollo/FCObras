Imports FCConstruccion

Public Class frmInsumos
    Private _dtInsumos As New DataTable

    Private _dcuent As New clCuenta

    Private _codigo_in As String

    Public Property DtInsumos As DataTable
        Get
            Return _dtInsumos
        End Get
        Set(value As DataTable)
            _dtInsumos = value
        End Set
    End Property

    Public Property Dcuent As clCuenta
        Get
            Return _dcuent
        End Get
        Set(value As clCuenta)
            _dcuent = value
        End Set
    End Property

    Public Property Codigo_in As String
        Get
            Return _codigo_in
        End Get
        Set(value As String)
            _codigo_in = value
        End Set
    End Property

    Private Sub frmInsumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenar_GridInsumos()
    End Sub

    Private Sub Llenar_GridInsumos()
        For x = 0 To _dtInsumos.Rows.Count - 1
            If _codigo_in = _dtInsumos.Rows(x).Item("codigo_insumo") Then
                dgInsumos.Rows.Add(_dtInsumos.Rows(x).Item("id"),
                               _dtInsumos.Rows(x).Item("unidad"),
                               _dtInsumos.Rows(x).Item("codigo"),
                               _dtInsumos.Rows(x).Item("nombre_cuenta"))
            End If
        Next
    End Sub

    Private Sub txtBus_TextChanged(sender As Object, e As EventArgs) Handles txtBus.TextChanged
        dgInsumos.Rows.Clear()

        For x = 0 To _dtInsumos.Rows.Count - 1
            If _codigo_in = _dtInsumos.Rows(x).Item("codigo_insumo") Then
                For t = 2 To 3
                    If InStr(Trim(_dtInsumos.Rows(x).Item(t).ToString), txtBus.Text, vbTextCompare) <> 0 Then
                        dgInsumos.Rows.Add(_dtInsumos.Rows(x).Item("id"),
                                           _dtInsumos.Rows(x).Item("unidad"),
                                   _dtInsumos.Rows(x).Item("codigo"),
                                   _dtInsumos.Rows(x).Item("nombre_cuenta"))
                        Exit For
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub dgInsumos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgInsumos.CellContentClick

    End Sub

    Private Sub dgInsumos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgInsumos.CellContentDoubleClick
        If dgInsumos Is Nothing Then Exit Sub

        If e.RowIndex >= 0 Then
            _dcuent.Id = dgInsumos.Item(0, e.RowIndex).Value
            '_dcuent.Idcuentapadre = dgInsumos.Item(1, e.RowIndex).Value
            '_dcuent.Codigocuentapadre = dgInsumos.Item(2, e.RowIndex).Value
            _dcuent.Unidad = dgInsumos.Item(1, e.RowIndex).Value
            _dcuent.Codigo = dgInsumos.Item(2, e.RowIndex).Value
            _dcuent.Nombrecuenta = dgInsumos.Item(3, e.RowIndex).Value
            _dcuent.Get_SumDetalles()
            Me.Close()
        End If
    End Sub


End Class
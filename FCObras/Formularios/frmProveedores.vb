Public Class frmProveedores
    Private _p_dtPro As New DataTable
    Private _p_Codigo As String
    Private _p_Nombre As String

    Public Property P_dtPro As DataTable
        Get
            Return _p_dtPro
        End Get
        Set(value As DataTable)
            _p_dtPro = value
        End Set
    End Property

    Public Property P_Codigo As String
        Get
            Return _p_Codigo
        End Get
        Set(value As String)
            _p_Codigo = value
        End Set
    End Property

    Public Property P_Nombre As String
        Get
            Return _p_Nombre
        End Get
        Set(value As String)
            _p_Nombre = value
        End Set
    End Property

    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenar_GridPro()
    End Sub

    Private Sub Llenar_GridPro()
        For x = 0 To _p_dtPro.Rows.Count - 1
            dgProveedores.Rows.Add(Trim(_p_dtPro.Rows(x).Item("Codigo").ToString), Trim(_p_dtPro.Rows(x).Item("Nombre").ToString))
        Next
    End Sub

    Private Sub txtBus_TextChanged(sender As Object, e As EventArgs) Handles txtBus.TextChanged

        dgProveedores.Rows.Clear()

        For x = 0 To _p_dtPro.Rows.Count - 1
            For t = 0 To 1
                If InStr(Trim(_p_dtPro.Rows(x).Item(t).ToString), txtBus.Text, vbTextCompare) <> 0 Then
                    dgProveedores.Rows.Add(Trim(_p_dtPro.Rows(x).Item(0).ToString), Trim(_p_dtPro.Rows(x).Item(1).ToString))
                    Exit For
                End If
            Next
        Next
    End Sub


    Private Sub dgProveedores_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProveedores.CellContentDoubleClick
        If dgProveedores Is Nothing Then Exit Sub

        If e.RowIndex >= 0 Then
            _p_Codigo = dgProveedores.Item(0, e.RowIndex).Value
            _p_Nombre = dgProveedores.Item(1, e.RowIndex).Value
            Me.Close()
        End If
    End Sub

    Private Sub frmProveedores_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub dgProveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProveedores.CellContentClick

    End Sub
End Class
Public Class frmConceptos
    Private _c_dtCon As New DataTable
    Private _c_Codigo As String
    Private _c_Nombre As String
    Private _c_id As Integer

    Public Property C_dtCon As DataTable
        Get
            Return _c_dtCon
        End Get
        Set(value As DataTable)
            _c_dtCon = value
        End Set
    End Property

    Public Property C_Codigo As String
        Get
            Return _c_Codigo
        End Get
        Set(value As String)
            _c_Codigo = value
        End Set
    End Property

    Public Property C_Nombre As String
        Get
            Return _c_Nombre
        End Get
        Set(value As String)
            _c_Nombre = value
        End Set
    End Property

    Public Property C_id As Integer
        Get
            Return _c_id
        End Get
        Set(value As Integer)
            _c_id = value
        End Set
    End Property

    Private Sub frmConceptos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenar_GridCon()
    End Sub

    Private Sub Llenar_GridCon()
        For x = 0 To _c_dtCon.Rows.Count - 1
            dgConceptos.Rows.Add(_c_dtCon.Rows(x).Item("id").ToString, Trim(_c_dtCon.Rows(x).Item("Codigo").ToString), Trim(_c_dtCon.Rows(x).Item("Nombre").ToString))
        Next
    End Sub

    Private Sub txtBus_TextChanged(sender As Object, e As EventArgs) Handles txtBus.TextChanged
        dgConceptos.Rows.Clear()

        For x = 0 To _c_dtCon.Rows.Count - 1
            For t = 0 To 1
                If InStr(Trim(_c_dtCon.Rows(x).Item(t).ToString), txtBus.Text, vbTextCompare) <> 0 Then
                    dgConceptos.Rows.Add(_c_dtCon.Rows(x).Item(0).ToString, Trim(_c_dtCon.Rows(x).Item(1).ToString), Trim(_c_dtCon.Rows(x).Item(2).ToString))
                    Exit For
                End If
            Next
        Next
    End Sub


    Private Sub dgConceptos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgConceptos.CellContentDoubleClick
        If dgConceptos Is Nothing Then Exit Sub

        If e.RowIndex >= 0 Then
            _c_Codigo = dgConceptos.Item(1, e.RowIndex).Value
            _c_Nombre = dgConceptos.Item(2, e.RowIndex).Value
            _c_id = dgConceptos.Item(0, e.RowIndex).Value
            Me.Close()
        End If
    End Sub

    Private Sub frmConceptos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

End Class
Imports System.Data.SqlClient

Public Class frmClasificacion
    Private D_Empresas As Collection
    Private d_load As Boolean
    Private d_id As Integer
    Private Sub FrmClasificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ttTextos.SetToolTip(btnDelClas, "Elima la clasificación seleccionada")
        Carga_tipos()
        d_load = True
        D_Empresas = Carga_empresas()
        Llena_ComboEmpresa(D_Empresas, cbEmpresas)
        d_load = False
    End Sub

    Private Sub Carga_tipos()
        Dim dt As DataTable
        Dim dr As DataRow, t As Integer

        dt = New DataTable("clasificaciones")
        dt.Columns.Add("id")
        dt.Columns.Add("nombre")

        dr = dt.NewRow()
        dr(0) = 0
        dr(1) = "Seleccione clasificación"
        dt.Rows.Add(dr)

        For t = 1 To 3
            dr = dt.NewRow()
            dr(0) = t
            dr(1) = "Clasificación " & t
            dt.Rows.Add(dr)
        Next

        cbtipo.DataSource = dt
        cbtipo.DisplayMember = "nombre"
        cbtipo.ValueMember = "id"
    End Sub

    Private Sub Carga_clasificaciones()
        Dim dQue As String
        dgClasificaciones.Rows.Clear()
        dQue = "SELECT id,nombre_clasificacion,tipo FROM zConsClasifciaciones"
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    dgClasificaciones.Rows.Add(dCr("id"), Trim(dCr("nombre_clasificacion")),
                                               "Clasificación " & dCr("tipo"), dCr("tipo"))
                Loop
            End Using
        End Using
    End Sub

    Private Sub CbEmpresas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpresas.SelectedIndexChanged
        Dim idempresa As Integer
        If d_load = True Then Exit Sub
        idempresa = CInt(cbEmpresas.SelectedValue)
        Cambio_Empresa(idempresa)
    End Sub

    Private Sub Cambio_Empresa(ByVal idEmpresa As Integer)
        Dim empresa As clEmpresa
        txtnombre.Text = ""
        cbtipo.SelectedValue = 0
        cbtipo.Enabled = True
        dgClasificaciones.Rows.Clear()
        For Each empresa In D_Empresas
            If empresa.Idempresa = idEmpresa Then
                If DConexiones Is Nothing Then FC_GetCons()
                DConexiones("CON").ChangeDatabase(empresa.BddCont)
                Carga_clasificaciones()
                Exit For
            End If
        Next empresa
    End Sub

    Private Sub Guarda_clasificacion()
        Dim dQue As String

        dQue = "INSERT INTO zConsClasifciaciones(nombre_clasificacion,tipo)
                VALUES('" & txtnombre.Text & "'," & cbtipo.SelectedValue & ") 
                SELECT SCOPE_IDENTITY()"
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            d_id = Convert.ToInt32(dCom.ExecuteScalar())
        End Using
        If d_id <> 0 Then
            dgClasificaciones.Rows.Add(d_id, txtnombre.Text,
                                       "Clasificación " & cbtipo.SelectedValue, cbtipo.SelectedValue)
            txtnombre.Text = ""
            cbtipo.SelectedValue = 0
            d_id = 0
            cbtipo.Enabled = True
        End If
    End Sub

    Private Sub Update_clasificacion()
        Dim dQue As String

        dQue = "UPDATE zConsClasifciaciones SET nombre_clasificacion='" &
            txtnombre.Text & "' WHERE id=" & d_id & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            dCom.ExecuteNonQuery()
        End Using
        If d_id <> 0 Then
            dgClasificaciones.Item(1, dgClasificaciones.CurrentRow.Index).Value = txtnombre.Text
            txtnombre.Text = ""
            cbtipo.SelectedValue = 0
            d_id = 0
            cbtipo.Enabled = True
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If cbEmpresas.SelectedValue = 0 Then Exit Sub
        If txtnombre.Text <> "" And cbtipo.SelectedValue <> 0 Then
            If d_id = 0 Then
                Guarda_clasificacion()
            Else
                Update_clasificacion()
            End If
        Else
            MsgBox("Los datos estan incompletos.", vbExclamation, "Validación")
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtnombre.Text = ""
        cbtipo.SelectedValue = 0
        d_id = 0
        cbtipo.Enabled = True
    End Sub

    'Private Sub DgClasificaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgClasificaciones.CellContentClick
    '    If dgClasificaciones.CurrentRow Is Nothing Then Exit Sub

    '    If e.RowIndex >= 0 Then
    '        d_id = dgClasificaciones.Item(0, e.RowIndex).Value
    '        txtnombre.Text = dgClasificaciones.Item(1, e.RowIndex).Value
    '        cbtipo.SelectedValue = dgClasificaciones.Item(3, e.RowIndex).Value
    '        cbtipo.Enabled = False
    '    End If
    'End Sub

    Private Sub BtnDelClas_Click(sender As Object, e As EventArgs) Handles btnDelClas.Click
        If Not dgClasificaciones.CurrentRow Is Nothing Then
            If MsgBox("Se va eliminar la clasificación:" & vbCrLf & dgClasificaciones.Item(1, dgClasificaciones.CurrentRow.Index).Value &
                      "¿Desea continuar?", vbYesNoCancel, "Validación") = vbYes Then
                Eliminar_clasificacion(dgClasificaciones.Item(0, dgClasificaciones.CurrentRow.Index).Value)
                dgClasificaciones.Rows.Remove(dgClasificaciones.CurrentRow)
            End If
        End If
    End Sub

    Private Sub Eliminar_clasificacion(ByVal id As Integer)
        Dim dQue As String

        dQue = "DELETE FROM zConsClasifciaciones WHERE id=" & id & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            dCom.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub dgClasificaciones_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgClasificaciones.CellContentDoubleClick
        If dgClasificaciones.CurrentRow Is Nothing Then Exit Sub

        If e.RowIndex >= 0 Then
            d_id = dgClasificaciones.Item(0, e.RowIndex).Value
            txtnombre.Text = dgClasificaciones.Item(1, e.RowIndex).Value
            cbtipo.SelectedValue = dgClasificaciones.Item(3, e.RowIndex).Value
            cbtipo.Enabled = False
        End If
    End Sub

End Class
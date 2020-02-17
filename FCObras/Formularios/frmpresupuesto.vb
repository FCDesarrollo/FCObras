Imports System.IO

Public Class frmpresupuesto
    Private _p_Idobra As Integer
    Private _p_rfc As String
    Private _p_id As Integer

    Private presu As clPresupuesto
    Public Property P_Idobra As Integer
        Get
            Return _p_Idobra
        End Get
        Set(value As Integer)
            _p_Idobra = value
        End Set
    End Property

    Public Property P_rfc As String
        Get
            Return _p_rfc
        End Get
        Set(value As String)
            _p_rfc = value
        End Set
    End Property

    Public Property P_id As Integer
        Get
            Return _p_id
        End Get
        Set(value As Integer)
            _p_id = value
        End Set
    End Property

    Private Sub Frmpresupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        presu = New clPresupuesto
        Me.toltip.SetToolTip(Me.btnDelDoc, "Elimina el documento seleccionado")
        If _p_id <> 0 Then
            btnAgregar.Text = "Editar"
            presu.Id = _p_id
            presu.Get_Presupuesto()
            txtNombre.Text = presu.Nombrepresupuesto
            txtDes.Text = presu.Descripcion
            dt = presu.Get_DocumentosPresupuestos
            dgArchivos.Rows.Clear()

            For Each row As DataRow In dt.Rows
                dgArchivos.Rows.Add(row("id"), "", row("archivo"),
                                   row("descripcion"))
            Next
        Else
            btnAgregar.Text = "Guardar"
        End If
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtNombre.Text <> "" And txtDes.Text <> "" Then
            If _p_id <> 0 Then
                Update_Presu()
            Else
                Guarda_Presu()
            End If

            Me.Close()
        Else
            MsgBox("Datos incompletos.", vbInformation, "Validación")
        End If
    End Sub

    Public Sub Guarda_Presu()

        presu.Idobra = _p_Idobra
        presu.Nombrepresupuesto = txtNombre.Text
        presu.Descripcion = txtDes.Text
        presu.Guarda_Presupuesto()
        If presu.Id <> 0 Then
            Guarda_DocPResupuestos()
        End If
    End Sub

    Private Sub Guarda_DocPResupuestos()
        Dim rutaAr As String
        rutaAr = GeneralFC.FC_RutaSincronizada & "\" & _p_rfc & "\" & GL_ModActual

        If Not System.IO.Directory.Exists(rutaAr & "\" & _p_Idobra) Then
            My.Computer.FileSystem.CreateDirectory(rutaAr & "\" & _p_Idobra)
        End If
        For Each fila As DataGridViewRow In dgArchivos.Rows
            If fila.Cells(0).Value = 0 Then
                File.Copy(fila.Cells(1).Value & "\" & fila.Cells(2).Value, rutaAr & "\" & CStr(_p_Idobra) & "\" & fila.Cells(2).Value, True)
                presu.Guarda_DocPresupuesto(fila.Cells(2).Value, fila.Cells(3).Value)
            Else
                ''pendiente editar
            End If
        Next
    End Sub

    Private Sub Update_Presu()
        presu.Idobra = _p_Idobra
        presu.Nombrepresupuesto = txtNombre.Text
        presu.Descripcion = txtDes.Text
        presu.Update_presupuesto()
        If presu.Id <> 0 Then
            Guarda_DocPResupuestos()
        End If
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim rutaDefault = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim abrir As New OpenFileDialog

        abrir.InitialDirectory = rutaDefault
        abrir.Filter = "Archivos |*.pdf;*.jpg;*.jpeg;*.xlsx"
        abrir.Multiselect = True
        abrir.ShowDialog(Owner)
        For Each arch In abrir.FileNames
            dgArchivos.Rows.Add(0, Path.GetDirectoryName(arch), Path.GetFileName(arch), "")
        Next
    End Sub

    Private Sub BtnDelDoc_Click(sender As Object, e As EventArgs) Handles btnDelDoc.Click
        Dim rutaAr As String
        rutaAr = GeneralFC.FC_RutaSincronizada & "\" & _p_rfc & "\" & GL_ModActual & "\" & _p_Idobra
        If dgArchivos.CurrentRow Is Nothing Then Exit Sub
        If dgArchivos.CurrentRow.Index >= 0 Then
            If MsgBox("Se va eliminar el documento " &
                      vbCrLf & dgArchivos.Item(2, dgArchivos.CurrentRow.Index).Value, vbYesNoCancel, "Validación") = vbYes Then
                presu.Elimina_documento(dgArchivos.Item(0, dgArchivos.CurrentRow.Index).Value)
                If System.IO.File.Exists(rutaAr & "\" & dgArchivos.Item(2, dgArchivos.CurrentRow.Index).Value) = True Then
                    System.IO.File.Delete(rutaAr & "\" & dgArchivos.Item(2, dgArchivos.CurrentRow.Index).Value)
                End If
                dgArchivos.Rows.Remove(dgArchivos.CurrentRow)
            End If
        End If
    End Sub
End Class
Imports System.Data.SqlClient

Public Class frmAgregaCat
    Private D_Empresas As Collection
    Private _a_tipo As Integer
    Private d_load As Boolean

    Private dtCat As DataTable

    Public Property A_tipo As Integer
        Get
            Return _a_tipo
        End Get
        Set(value As Integer)
            _a_tipo = value
        End Set
    End Property

    Private Sub frmAgregaCat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _a_tipo = 1 Then
            Me.Text = "Agrega Unidad"
        ElseIf _a_tipo = 2 Then
            Me.Text = "Agrega Insumo"
        End If
        d_load = True
        D_Empresas = Carga_empresas()
        Llena_ComboEmpresa(D_Empresas, cbEmpresas)
        d_load = False
    End Sub

    Private Sub Carga_catalogo()
        Dim dQue As String = ""
        dtCat = New DataTable
        If _a_tipo = 1 Then
            dQue = "SELECT  id,clave_unidad as cod,nombre_unidad as nombre FROM zConsUnidades"
        ElseIf _a_tipo = 2 Then
            dQue = "SELECT  id,codigo_insumo as cod,nombre_insumo as nombre FROM zConsInsumos"
        End If
        Using cCom = New SqlDataAdapter(dQue, DConexiones("CON"))
            cCom.Fill(dtCat)
        End Using
    End Sub

    Private Sub Llenar_GridCat()
        For x = 0 To dtCat.Rows.Count - 1
            dgCatalogo.Rows.Add(Trim(dtCat.Rows(x).Item("id").ToString),
                                Trim(dtCat.Rows(x).Item("cod").ToString),
                                Trim(dtCat.Rows(x).Item("Nombre").ToString))
        Next
    End Sub

    Private Sub Guarda()
        Dim dQue As String = ""

        If _a_tipo = 1 Then
            dQue = "IF NOT EXISTS (SELECT clave_unidad FROM zConsUnidades WHERE clave_unidad=@codigo)
                        BEGIN INSERT INTO zConsUnidades(clave_unidad, nombre_unidad)VALUES(@codigo, @nombre) END
                    ELSE BEGIN UPDATE zConsUnidades SET nombre_unidad=@nombre 
                        WHERE clave_unidad=@codigo AND id=@id END"
        ElseIf _a_tipo = 2 Then
            dQue = "IF NOT EXISTS (SELECT codigo_insumo FROM zConsInsumos WHERE codigo_insumo=@codigo)
                        BEGIN INSERT INTO zConsInsumos(codigo_insumo, nombre_insumo)VALUES(@codigo, @nombre) END
                    ELSE BEGIN UPDATE zConsInsumos SET nombre_insumo=@nombre 
                        WHERE codigo_insumo=@codigo AND id=@id END"
        End If
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            dCom.Parameters.AddWithValue("codigo", txtclave.Text)
            dCom.Parameters.AddWithValue("nombre", txtnombre.Text)
            dCom.Parameters.AddWithValue("id", txtclave.Tag)
            dCom.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtclave.Text <> "" And txtnombre.Text <> "" Then
            Guarda()
            txtnombre.Text = ""
            txtclave.Text = ""
            txtclave.Tag = 0
            dgCatalogo.Rows.Clear()
            Carga_catalogo()
            Llenar_GridCat()
        Else
            MsgBox("Datos incompletos.", vbInformation, "Validación")
        End If
    End Sub

    Private Sub cbEmpresas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpresas.SelectedIndexChanged
        Dim idempresa As Integer
        If d_load = True Then Exit Sub
        idempresa = CInt(cbEmpresas.SelectedValue)
        Cambio_Empresa(idempresa)
    End Sub

    Private Sub Cambio_Empresa(ByVal idEmpresa As Integer)
        Dim empresa As clEmpresa
        txtnombre.Text = ""
        txtclave.Text = ""
        txtclave.Tag = 0
        dgCatalogo.Rows.Clear()
        For Each empresa In D_Empresas
            If empresa.Idempresa = idEmpresa Then
                If DConexiones Is Nothing Then FC_GetCons()
                DConexiones("CON").ChangeDatabase(empresa.BddCont)
                Carga_catalogo()
                Llenar_GridCat()
                Exit For
            End If
        Next empresa
    End Sub


    Private Sub dgCatalogo_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCatalogo.CellContentDoubleClick
        If dgCatalogo.CurrentRow Is Nothing Then Exit Sub

        If e.RowIndex >= 0 Then
            txtclave.Text = dgCatalogo.Item(1, e.RowIndex).Value
            txtclave.Tag = dgCatalogo.Item(0, e.RowIndex).Value
            txtnombre.Text = dgCatalogo.Item(2, e.RowIndex).Value
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim comple As String
        If txtclave.Tag <> 0 Then
            comple = IIf(_a_tipo = 1, "la unidad ", "el insumo ")
            If MsgBox("Se eliminara " & comple & txtnombre.Text, vbYesNoCancel, "Validación") = vbYes Then
                Eliminar_Cat()
                txtnombre.Text = ""
                txtclave.Text = ""
                txtclave.Tag = 0
                dgCatalogo.Rows.Clear()
                Carga_catalogo()
                Llenar_GridCat()
            End If
        End If
    End Sub

    Private Sub Eliminar_Cat()
        Dim dQue As String = "", dID As Integer

        dID = txtclave.Tag
        If _a_tipo = 1 Then
            dQue = "DELETE FROM zConsUnidades WHERE id=" & dID & ""
        ElseIf _a_tipo = 2 Then
            dQue = "DELETE FROM zConsInsumos WHERE id=" & dID & ""
        End If
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            dCom.ExecuteNonQuery()
        End Using
    End Sub
End Class
Imports FCConstruccion

Public Class frmprecio
    Private _dicPresupuestos As Dictionary(Of Integer, String)

    Private _preCuent As New clCuenta

    Public Property DicPresupuestos As Dictionary(Of Integer, String)
        Get
            Return _dicPresupuestos
        End Get
        Set(value As Dictionary(Of Integer, String))
            _dicPresupuestos = value
        End Set
    End Property

    Public Property PreCuent As clCuenta
        Get
            Return _preCuent
        End Get
        Set(value As clCuenta)
            _preCuent = value
        End Set
    End Property

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmprecio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Presupuestos()
    End Sub

    Private Sub Carga_Presupuestos()
        Dim dt As DataTable
        Dim dr As DataRow

        dt = New DataTable("Presupuestos")
        dt.Columns.Add("id")
        dt.Columns.Add("nombre")

        dr = dt.NewRow
        dr(0) = 0
        dr(1) = "SIN PRESUPUESTO"
        dt.Rows.Add(dr)

        For Each key As Integer In _dicPresupuestos.Keys
            dr = dt.NewRow
            dr(0) = key
            dr(1) = _dicPresupuestos.Item(key)
            dt.Rows.Add(dr)
        Next


        cbPresupuesto.DataSource = dt
        cbPresupuesto.ValueMember = "id"
        cbPresupuesto.DisplayMember = "nombre"
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtImporte.Text <> "" And txtImporte.Text <> 0 Then
            _preCuent.Idusuario = GL_cUsuario.Iduser
            _preCuent.Estatus = 1
            _preCuent.Cantidad = txtCantidad.Text
            _preCuent.Precio = txtPrecio.Text
            _preCuent.Idpresupuesto = cbPresupuesto.SelectedValue
            _preCuent.Fechaprecio = dtFecha.Value
            _preCuent.Importe = txtImporte.Text
            _preCuent.Guarda_Asociacion()
            Me.Close()
        End If
    End Sub


    Private Sub txtCantidad_LostFocus(sender As Object, e As EventArgs) Handles txtCantidad.LostFocus
        If txtCantidad.Text <> "" And txtPrecio.Text <> "" Then
            txtImporte.Text = txtCantidad.Text * txtPrecio.Text
        End If
    End Sub


    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        PALNUMEROS(e, 0, txtCantidad)
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        PALNUMEROS(e, 2, txtPrecio)
    End Sub

    Private Sub txtPrecio_LostFocus(sender As Object, e As EventArgs) Handles txtPrecio.LostFocus
        If txtCantidad.Text <> "" And txtPrecio.Text <> "" Then
            txtImporte.Text = txtCantidad.Text * txtPrecio.Text
        End If
    End Sub
End Class
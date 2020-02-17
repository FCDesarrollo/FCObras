Imports System.Data.SqlClient

Public Class frmOrden
    Private _oIDSucursal As Integer

    Private O_Obras As clObra
    Private D_Obras As Collection
    Private D_IDObra As Integer
    Private D_LOAD As Boolean

    Private D_dicUnidades As New Dictionary(Of Integer, String)
    Public Property OIDSucursal As Integer
        Get
            Return _oIDSucursal
        End Get
        Set(value As Integer)
            _oIDSucursal = value
        End Set
    End Property

    Private Sub FrmOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Unidades()
        O_Obras = New clObra
        O_Obras.Idsucursal = _oIDSucursal
        D_Obras = O_Obras.Carga_Obras
        D_LOAD = True
        Carga_Obras()
        D_LOAD = False

    End Sub

    Private Sub Carga_Unidades()
        Dim dQue As String, dkey As Integer, ditem As String

        dQue = "SELECT  id,clave_unidad FROM ConsUnidades"
        Using dCom = New SqlCommand(dQue, FC_Con)
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    dkey = dCr("id")
                    ditem = dCr("clave_unidad")
                    If Not D_dicUnidades.ContainsKey(dkey) Then
                        D_dicUnidades.Add(dkey, ditem)
                    End If
                Loop
            End Using
        End Using
    End Sub

    Private Sub Carga_Obras()
        Dim obra As clObra
        Dim dt As DataTable
        Dim dr As DataRow

        dt = New DataTable("obras")
        dt.Columns.Add("id")
        dt.Columns.Add("nombre")

        dr = dt.NewRow
        dr(0) = 0
        dr(1) = "Seleccione"
        dt.Rows.Add(dr)

        For Each obra In D_Obras
            dr = dt.NewRow
            dr(0) = obra.Id
            dr(1) = obra.Nombreobra
            dt.Rows.Add(dr)
        Next obra

        cbObra.DataSource = dt
        cbObra.DisplayMember = "nombre"
        cbObra.ValueMember = "id"
    End Sub

    Private Sub dgMov_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMov.CellClick
        Dim frm As New frmSelecCuenta, cuenta As clCuenta, cont As Integer
        Dim dUnidad As String
        If D_IDObra = 0 Then Exit Sub
        If (CInt(e.ColumnIndex.ToString) >= 0) Then
            If Me.dgMov.Columns(e.ColumnIndex).Name = "movbus" Then
                frm.IdObra = D_IDObra
                frm.ShowDialog()
                cont = 0
                For Each cuenta In frm.ColCuentas
                    With dgMov
                        If Existe_Cuenta(cuenta.Id, cuenta.Idcuentapadre) = False Then
                            If cont = 0 Then
                                dUnidad = IIf(D_dicUnidades.ContainsKey(cuenta.Unidad), D_dicUnidades.Item(cuenta.Unidad), "")
                                If CStr(.Rows(e.RowIndex).Cells("movidcuen").Value) <> "" Then
                                    .Rows(e.RowIndex).Cells("movidcuen").Value = cuenta.Id
                                    .Rows(e.RowIndex).Cells("movidcuentapadre").Value = cuenta.Idcuentapadre
                                    .Rows(e.RowIndex).Cells("movCodigo").Value = cuenta.Codigo
                                    .Rows(e.RowIndex).Cells("movcuenta").Value = cuenta.Nombrecuenta
                                    .Rows(e.RowIndex).Cells("movUni").Value = dUnidad
                                    .Rows(e.RowIndex).Cells("movcant").Value = 0
                                    .Rows(e.RowIndex).Cells("movPre").Value = cuenta.Precio
                                    .Rows(e.RowIndex).Cells("movTota").Value = 0

                                    ''OCULTOS PARA COMPARAR
                                    .Rows(e.RowIndex).Cells("movcantidadT").Value = cuenta.Cantidad
                                    .Rows(e.RowIndex).Cells("movprecioT").Value = cuenta.Precio
                                    .Rows(e.RowIndex).Cells("movtotalT").Value = cuenta.Importe
                                    Exit For
                                Else
                                    .Rows.Add(cuenta.Id, cuenta.Idcuentapadre,
                                              cuenta.Codigo, cuenta.Nombrecuenta, "",
                                              dUnidad, 0, cuenta.Precio, 0, cuenta.Cantidad, cuenta.Precio, cuenta.Importe)
                                End If
                            Else
                                .Rows.Add(cuenta.Id, cuenta.Idcuentapadre,
                                              cuenta.Codigo, cuenta.Nombrecuenta, "",
                                              dUnidad, 0, cuenta.Precio, 0, cuenta.Cantidad, cuenta.Precio, cuenta.Importe)
                            End If
                        End If
                    End With
                    cont = cont + 1
                Next cuenta

                frm.Dispose()
            End If
        End If
    End Sub

    Private Sub CbObra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbObra.SelectedIndexChanged
        If D_LOAD = True Then Exit Sub
        D_IDObra = CInt(cbObra.SelectedValue)
    End Sub

    Private Function Existe_Cuenta(ByVal idCuenta As Integer, ByVal idPadre As Integer) As Boolean
        Dim resp As Boolean

        resp = False
        For Each fila As DataGridViewRow In dgMov.Rows
            If fila.Cells("movidcuen").Value = idCuenta And fila.Cells("movidcuentapadre").Value = idPadre Then
                resp = True
            End If
        Next
        Return resp
    End Function

    Private Sub Limpiar_Orden()
        txtTipocambio.Text = 1
        txtFolio.Text = 0
        txtSerie.Text = ""
        txtCodigo.Text = ""
        txtNombre.Text = ""
        dtFecha.Value = Date.Now
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar_Orden()
    End Sub

    Private Sub txtTipocambio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipocambio.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "."
    End Sub

    Private Sub txtFolio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFolio.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

End Class
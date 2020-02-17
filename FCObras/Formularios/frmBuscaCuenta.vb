Imports FCConstruccion

Public Class frmBuscaCuenta
    Private dtCuentas As DataTable

    Private _d_idcuentafiltro As Integer

    Private _regcuenta As New clCuenta

    Private _d_tipollamada As Integer '-.1 Cuenta->Cuenta, -2 Cuenta->subcuenta
    Private _d_idobra As Integer

    Public Property D_idobra As Integer
        Get
            Return _d_idobra
        End Get
        Set(value As Integer)
            _d_idobra = value
        End Set
    End Property

    Public Property D_tipollamada As Integer
        Get
            Return _d_tipollamada
        End Get
        Set(value As Integer)
            _d_tipollamada = value
        End Set
    End Property


    Public Property D_idcuentafiltro As Integer
        Get
            Return _d_idcuentafiltro
        End Get
        Set(value As Integer)
            _d_idcuentafiltro = value
        End Set
    End Property

    Public Property Regcuenta As clCuenta
        Get
            Return _regcuenta
        End Get
        Set(value As clCuenta)
            _regcuenta = value
        End Set
    End Property

    Private Sub FrmBuscaCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cuenta As New clCuenta, filtro As String
        filtro = "AND id<> " & D_idcuentafiltro
        cuenta.Idobra = _d_idobra
        dtCuentas = cuenta.Carga_Cuentas(filtro)
        Carga_cuentas()
    End Sub

    Private Sub Carga_cuentas()
        For Each row As DataRow In dtCuentas.Rows
            dgCuentas.Rows.Add(row("id"), row("codigo"), row("nombre_cuenta"),
                               row("fechaInicio"), row("fechaFinal"), row("clasificacion1"),
                               row("clasificacion2"), row("clasificacion3"), row("tipoinsumo"), row("idinsumo"))
        Next
    End Sub



    Private Sub dgCuentas_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCuentas.CellContentDoubleClick
        If dgCuentas Is Nothing Then Exit Sub

        If e.RowIndex >= 0 Then
            _regcuenta.Id = dgCuentas.Item(0, e.RowIndex).Value
            _regcuenta.Codigo = dgCuentas.Item(1, e.RowIndex).Value
            _regcuenta.Nombrecuenta = dgCuentas.Item(2, e.RowIndex).Value
            _regcuenta.Fechaini = dgCuentas.Item(3, e.RowIndex).Value
            _regcuenta.Fechafin = dgCuentas.Item(4, e.RowIndex).Value
            _regcuenta.Clasificacion1 = dgCuentas.Item(5, e.RowIndex).Value
            _regcuenta.Clasificacion2 = dgCuentas.Item(6, e.RowIndex).Value
            _regcuenta.Clasificacion3 = dgCuentas.Item(7, e.RowIndex).Value
            _regcuenta.Tipo = dgCuentas.Item(8, e.RowIndex).Value
            _regcuenta.Idinsumo = dgCuentas.Item(9, e.RowIndex).Value
            Me.Close()
        End If
    End Sub

    Private Sub dgCuentas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCuentas.CellDoubleClick
        If dgCuentas Is Nothing Then Exit Sub

        If e.RowIndex >= 0 Then
            _regcuenta.Id = dgCuentas.Item(0, e.RowIndex).Value
            _regcuenta.Codigo = dgCuentas.Item(1, e.RowIndex).Value
            _regcuenta.Nombrecuenta = dgCuentas.Item(2, e.RowIndex).Value
            _regcuenta.Fechaini = dgCuentas.Item(3, e.RowIndex).Value
            _regcuenta.Fechafin = dgCuentas.Item(4, e.RowIndex).Value
            _regcuenta.Clasificacion1 = dgCuentas.Item(5, e.RowIndex).Value
            _regcuenta.Clasificacion2 = dgCuentas.Item(6, e.RowIndex).Value
            _regcuenta.Clasificacion3 = dgCuentas.Item(7, e.RowIndex).Value
            _regcuenta.Tipo = dgCuentas.Item(8, e.RowIndex).Value
            _regcuenta.Idinsumo = dgCuentas.Item(9, e.RowIndex).Value
            Me.Close()
        End If
    End Sub
End Class
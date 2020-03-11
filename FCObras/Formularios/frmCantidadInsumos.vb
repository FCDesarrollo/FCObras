Imports System.Data.SqlClient

Public Class frmCantidadInsumos
    Private _i_idcuenta As Integer
    Private _i_idobra As Integer
    Private _i_dicCuentas As New Collection

    Public Property I_idcuenta As Integer
        Get
            Return _i_idcuenta
        End Get
        Set(value As Integer)
            _i_idcuenta = value
        End Set
    End Property

    Public Property I_idobra As Integer
        Get
            Return _i_idobra
        End Get
        Set(value As Integer)
            _i_idobra = value
        End Set
    End Property

    Public Property I_dicCuentas As Collection
        Get
            Return _i_dicCuentas
        End Get
        Set(value As Collection)
            _i_dicCuentas = value
        End Set
    End Property

    Private Sub frmCantidadInsumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_insumos()
    End Sub

    Private Sub Carga_insumos()
        Dim dQue As String, cCuenta As clCuenta

        dQue = "SELECT DISTINCT p.id_cuenta,p.id_cuentapadre,p.codigo_cuenta,
                    p.codigo_cuentapadre,c.nombre_cuenta  FROM zConsAsociacionesPrecios p 
		                INNER JOIN zConsCuentas c ON p.id_cuenta=c.id 
                        WHERE p.id_cuenta=" & _i_idcuenta & " AND p.id_obra=" & _i_idobra & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    cCuenta = New clCuenta
                    With cCuenta
                        .Id = _i_idcuenta
                        .Codigo = dCr("codigo_cuenta")
                        .Nombrecuenta = dCr("nombre_cuenta")
                        .Idcuentapadre = dCr("id_cuentapadre")
                        .Codigocuentapadre = dCr("codigo_cuentapadre")
                        .Get_SumDetalles()
                        dgInsumos.Rows.Add(.Id, .Idcuentapadre, .Unidad, .Importependiente,
                                            .Codigocuentapadre, .Codigo, .Nombrecuenta, .Cantidadpendiente, 0)
                    End With
                Loop
            End Using
        End Using
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim aCuenta As clCuenta
        For Each fila As DataGridViewRow In dgInsumos.Rows
            If fila.Cells("inscantidad").Value > 0 Then
                aCuenta = New clCuenta
                With aCuenta
                    .Id = fila.Cells("insuidcuenta").Value
                    .Codigo = fila.Cells("insucodigo").Value
                    .Nombrecuenta = fila.Cells("insuNombre").Value
                    .Idcuentapadre = fila.Cells("insidcuentapadre").Value
                    .Codigocuentapadre = fila.Cells("inscodcuentapadre").Value
                    .Unidad = fila.Cells("insunidad").Value
                    .Cantidad = fila.Cells("inscantidad").Value
                    .Cantidadpendiente = fila.Cells("inscantidaddi").Value
                    .Importependiente = fila.Cells("inspresutotal").Value
                End With
                _i_dicCuentas.Add(aCuenta)
            End If
        Next
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
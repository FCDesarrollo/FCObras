Imports System.Data.SqlClient

Public Class frmSelecCuenta

    Private dtCuentas As DataTable
    Private dDicCuentas As Dictionary(Of String, String)
    Private _idObra As Integer


    Private _colCuentas As New Collection

    Public Property IdObra As Integer
        Get
            Return _idObra
        End Get
        Set(value As Integer)
            _idObra = value
        End Set
    End Property

    Public Property ColCuentas As Collection
        Get
            Return _colCuentas
        End Get
        Set(value As Collection)
            _colCuentas = value
        End Set
    End Property

    Private Sub FrmSelecCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Arbol()
    End Sub

    Private Sub Carga_Arbol()
        Dim cuenta As New clCuenta

        cuenta.Idobra = _idObra
        dtCuentas = cuenta.Carga_AsociadasCuentas()
        dDicCuentas = cuenta.Nombres_cuentas()
        treCuentas.Nodes.Clear()
        CrearNodosDelPadre(0, Nothing)
        cuenta = Nothing
    End Sub

    Private Sub CrearNodosDelPadre(ByVal indicePadre As Integer, ByVal nodePadre As TreeNode)
        Dim dataViewHijos As DataView


        'Crear un DataView con los Nodos que dependen del Nodo padre pasado como parámetro
        dataViewHijos = New DataView(dtCuentas)

        'Filtra por cada padre
        dataViewHijos.RowFilter = dtCuentas.Columns("id_cuentapadre").ColumnName +
        " = " + indicePadre.ToString()

        ' Agregar al TreeView los nodos Hijos que se han obtenido en el DataView.
        For Each dataRowCurrent As DataRowView In dataViewHijos
            Dim nuevoNodo As New TreeNode

            'Descripción o texto del nodo
            nuevoNodo.Text = dataRowCurrent("codigo_cuenta").ToString().Trim() & " - " & dDicCuentas.Item(dataRowCurrent("codigo_cuenta").ToString().Trim())

            'Si necesito guardar el valor del IdentificadorNodo dentro del mismo nodo
            nuevoNodo.Name = dataRowCurrent("id_cuenta").ToString().Trim()

            'Si necesito guardar el valor del IdentificadorPadre dentro del mismo nodo
            nuevoNodo.Tag = dataRowCurrent("id_cuentapadre").ToString().Trim()

            'Si el parámetro nodoPadre es nulo es porque es la primera llamada, son los Nodos
            'del primer nivel que no dependen de otro nodo.
            If nodePadre Is Nothing Then
                treCuentas.Nodes.Add(nuevoNodo)
            Else
                'se añade el nuevo nodo al nodo padre.
                nodePadre.Nodes.Add(nuevoNodo)
            End If

            'Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.
            CrearNodosDelPadre(Int32.Parse(dataRowCurrent("id_cuenta").ToString()), nuevoNodo)
        Next dataRowCurrent
    End Sub

    Private Sub Baja_cuentas(ByVal idCuen As Integer)
        Dim dQue As String, cuenta As clCuenta, filtro As String

        filtro = "id_cuenta=" & idCuen
        dQue = "SELECT DISTINCT id_cuenta,id_cuentapadre,codigo_cuenta,unidad
                            FROM zConsAsociacionesPrecios 
                            WHERE id_cuenta = " & idCuen & " 
                            Or id_cuentapadre = " & idCuen & " order by id_cuentapadre"
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    cuenta = New clCuenta
                    cuenta.Unidad = dCr("unidad")
                    cuenta.Id = dCr("id_cuenta")
                    cuenta.Idcuentapadre = dCr("id_cuentapadre")
                    cuenta.Codigo = dCr("codigo_cuenta")
                    cuenta.Nombrecuenta = dDicCuentas.Item(dCr("codigo_cuenta"))
                    'cuenta.Get_SumDetalles()
                    _colCuentas.Add(cuenta)
                Loop
            End Using
        End Using


    End Sub

    Private Sub treCuentas_DoubleClick(sender As Object, e As EventArgs) Handles treCuentas.DoubleClick
        Baja_cuentas(treCuentas.SelectedNode.Name)
        Me.Close()
    End Sub
End Class
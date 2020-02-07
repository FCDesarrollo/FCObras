Imports System.IO

Public Class frmCuentas
    Private dtCuentas As DataTable
    Private dDicCuentas As Dictionary(Of String, String)
    Private aExisteNode As Boolean

    Private _d_idobra As Integer
    Private _d_nombreobra As String
    Private _d_nombreempresa As String

    Public Property D_idobra As Integer
        Get
            Return _d_idobra
        End Get
        Set(value As Integer)
            _d_idobra = value
        End Set
    End Property

    Public Property D_nombreobra As String
        Get
            Return _d_nombreobra
        End Get
        Set(value As String)
            _d_nombreobra = value
        End Set
    End Property

    Public Property D_nombreempresa As String
        Get
            Return _d_nombreempresa
        End Get
        Set(value As String)
            _d_nombreempresa = value
        End Set
    End Property

    Private Sub FrmCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Arbol()
        lbEmpresa.Text = "Nombre de Empresa: " & _d_nombreempresa
        lbObra.Text = "Nombre de Obra: " & _d_nombreobra
    End Sub

    Private Sub Carga_Arbol()
        Dim cuenta As New clCuenta

        cuenta.Idobra = _d_idobra
        dtCuentas = cuenta.Carga_Cuentas()
        dDicCuentas = cuenta.Nombres_cuentas()
        tvCuentas.Nodes.Clear()
        CrearNodosDelPadre(0, Nothing)
    End Sub



    Private Sub PrintRecursive(ByVal n As TreeNodeCollection, ByVal aTexto As String, ByVal aSiguiente As Boolean)
        'System.Diagnostics.Debug.WriteLine(n.Text) 'Muestra el texto del nodo en la ventana de inmediato
        ' MessageBox.Show(n.Text) 'Muestra el mismo mensaje por pantalla
        Dim aNode As TreeNode

        If n Is Nothing Then
            n = tvCuentas.Nodes
        End If
        '*** Es aquí donde añado lo que necesito guardar de cada nodo ***  

        'Por cada nodo de la raíz
        For Each aNode In n
            If InStr(UCase(aNode.Text), UCase(aTexto), CompareMethod.Text) <> 0 Then
                If aSiguiente = False Or (aNode.IsSelected = False And aSiguiente = True) Then
                    tvCuentas.SelectedNode = aNode

                    aExisteNode = True
                    Exit For
                End If
            End If
            If aExisteNode = True Then Exit Sub
            PrintRecursive(aNode.Nodes, aTexto, aSiguiente)
        Next
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
                tvCuentas.Nodes.Add(nuevoNodo)
            Else
                'se añade el nuevo nodo al nodo padre.
                nodePadre.Nodes.Add(nuevoNodo)
            End If

            'Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.
            CrearNodosDelPadre(Int32.Parse(dataRowCurrent("id_cuenta").ToString()), nuevoNodo)
        Next dataRowCurrent
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        aExisteNode = False
        PrintRecursive(Nothing, txtBuscar.Text, False)
    End Sub

    Private Sub BtnSiguien_Click(sender As Object, e As EventArgs) Handles btnSiguien.Click
        If txtBuscar.Text <> "" Then
            'aExisteNode = False

            'PrintRecursive(Nothing, txtBuscar.Text, True)
        End If
    End Sub

    Private Sub BtnCarga_Click(sender As Object, e As EventArgs) Handles btnCarga.Click
        Dim idPre As Integer
        Dim rutaDefault = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim abrir As New OpenFileDialog

        Dim frm As New frmAvanceCuentas
        If Get_numAsoc(1) = 0 Then
            MsgBox("Si las cuentas no tienen presupuesto se le agregara el presupuesto default.", vbInformation, "Información")
            idPre = Get_IDPresupuesto(1)
        Else
            MsgBox("El Layout de cuentas debe tener el presupuesto")
        End If
        abrir.InitialDirectory = rutaDefault
        abrir.Filter = "Archivos Excel|*.xlsx"

        abrir.ShowDialog(Owner)
        If abrir.FileName <> "" Then
            frm.D_ruta = abrir.FileName
            frm.D_idPre = idPre
            frm.D_idobra = _d_idobra
            frm.ShowDialog()
            tvCuentas.Nodes.Clear()
            Carga_Arbol()
        End If
    End Sub


End Class
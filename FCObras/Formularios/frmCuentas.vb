﻿Imports System.Data.SqlClient
Imports System.IO

Public Class frmCuentas
    Private dtCuentas As DataTable
    Private dDicCuentas As Dictionary(Of String, String)
    Private aExisteNode As Boolean

    Private D_Cuenta As clCuenta

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
        FC_Conexion()
        Carga_Unidades()
        Carga_TiposInsumos()
        Carga_Clasificaciones()
        Carga_Arbol()
        lbEmpresa.Text = "Nombre de Empresa: " & _d_nombreempresa
        lbObra.Text = "Nombre de Obra: " & _d_nombreobra
        D_Cuenta = New clCuenta
    End Sub

    Private Sub Carga_Unidades()
        Dim dQue As String
        Dim dt As DataTable
        Dim dr As DataRow

        dt = New DataTable("unidades")
        dt.Columns.Add("id")
        dt.Columns.Add("codigo")

        dr = dt.NewRow
        dr(0) = 0
        dr(1) = "SIN UNIDAD"
        dt.Rows.Add(dr)

        dQue = "SELECT id,clave_unidad FROM ConsUnidades"
        Using dCom = New SqlCommand(dQue, FC_Con)
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    dr = dt.NewRow
                    dr(0) = dCr("id")
                    dr(1) = Trim(dCr("clave_unidad"))
                    dt.Rows.Add(dr)
                Loop
            End Using
        End Using

        cbUnidad.DataSource = dt
        cbUnidad.ValueMember = "id"
        cbUnidad.DisplayMember = "codigo"
    End Sub

    Private Sub Carga_Clasificaciones()
        Dim dQue As String
        Dim dt As DataTable, dt2 As DataTable, dt3 As DataTable
        Dim dr As DataRow, dr2 As DataRow, dr3 As DataRow

        dt = New DataTable("clasificacion1")
        dt.Columns.Add("id")
        dt.Columns.Add("nombre")

        dr = dt.NewRow
        dr(0) = 0
        dr(1) = "SIN CLASIFICACION"
        dt.Rows.Add(dr)

        dt2 = New DataTable("clasificacion2")
        dt2.Columns.Add("id")
        dt2.Columns.Add("nombre")

        dr2 = dt2.NewRow
        dr2(0) = 0
        dr2(1) = "SIN CLASIFICACION"
        dt2.Rows.Add(dr2)

        dt3 = New DataTable("clasificacion3")
        dt3.Columns.Add("id")
        dt3.Columns.Add("nombre")

        dr3 = dt3.NewRow
        dr3(0) = 0
        dr3(1) = "SIN CLASIFICACION"
        dt3.Rows.Add(dr3)

        dQue = "SELECT id,nombre_clasificacion,tipo FROM zConsClasifciaciones"
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    If dCr("tipo") = 1 Then
                        dr = dt.NewRow
                        dr(0) = dCr("id")
                        dr(1) = dCr("nombre_clasificacion")
                        dt.Rows.Add(dr)
                    ElseIf dCr("tipo") = 2 Then
                        dr2 = dt2.NewRow
                        dr2(0) = dCr("id")
                        dr2(1) = dCr("nombre_clasificacion")
                        dt2.Rows.Add(dr2)
                    ElseIf dCr("tipo") = 3 Then
                        dr3 = dt3.NewRow
                        dr3(0) = dCr("id")
                        dr3(1) = dCr("nombre_clasificacion")
                        dt3.Rows.Add(dr3)
                    End If
                Loop
            End Using
        End Using

        cbclas1.DataSource = dt
        cbclas1.ValueMember = "id"
        cbclas1.DisplayMember = "nombre"

        cbclas2.DataSource = dt2
        cbclas2.ValueMember = "id"
        cbclas2.DisplayMember = "nombre"

        cbclas3.DataSource = dt3
        cbclas3.ValueMember = "id"
        cbclas3.DisplayMember = "nombre"
    End Sub

    Private Sub Carga_TiposInsumos()
        Dim dQue As String
        Dim dt As DataTable
        Dim dr As DataRow


        dt = New DataTable("tiposinsumos")
        dt.Columns.Add("id")
        dt.Columns.Add("codigo")

        dr = dt.NewRow
        dr(0) = 0
        dr(1) = "SIN INSUMO"
        dt.Rows.Add(dr)

        dQue = "SELECT id,codigo_insumo FROM ConsInsumos"
        Using dCom = New SqlCommand(dQue, FC_Con)
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    dr = dt.NewRow
                    dr(0) = dCr("id")
                    dr(1) = Trim(dCr("codigo_insumo"))
                    dt.Rows.Add(dr)
                Loop
            End Using
        End Using

        cbNombreTipo.DataSource = dt
        cbNombreTipo.ValueMember = "id"
        cbNombreTipo.DisplayMember = "codigo"

    End Sub


    Private Sub Carga_Arbol()
        Dim cuenta As New clCuenta

        cuenta.Idobra = _d_idobra
        dtCuentas = cuenta.Carga_AsociadasCuentas()
        dDicCuentas = cuenta.Nombres_cuentas()
        tvCuentas.Nodes.Clear()
        CrearNodosDelPadre(0, Nothing)
        cuenta = Nothing
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
        abrir.Multiselect = False
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

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'If Valida_Cuenta() = True Then
        '    'D_Cuenta = New clCuenta
        '    'D_Cuenta.Idobra = _d_idobra
        '    'D_Cuenta.Codigo = txtCuenta.Text
        '    'D_Cuenta.Nombrecuenta = txtnombrecuenta.Text
        '    'D_Cuenta.Fechaini = dtFechaI.Value
        '    'D_Cuenta.Fechafin = dtFechaF.Value
        '    'D_Cuenta.Codigoadw = txtCuenta.Text
        '    'D_Cuenta.Clasificacion1 = cbclas1.ValueMember
        '    'D_Cuenta.Clasificacion2 = cbclas2.ValueMember
        '    'D_Cuenta.Clasificacion3 = cbclas3.ValueMember
        '    'D_Cuenta.Tipo = IIf(ckTipo.Checked, 1, 0)
        '    'D_Cuenta.Idinsumo = cbNombreTipo.ValueMember
        '    'D_Cuenta.Guarda_cuenta()
        '    'If D_Cuenta.Id <> 0 Then

        '    'End If
        'End If
    End Sub



    Private Sub tvCuentas_DoubleClick(sender As Object, e As EventArgs) Handles tvCuentas.DoubleClick
        Dim dt As New DataTable
        D_Cuenta = New clCuenta
        D_Cuenta.Idobra = D_idobra
        D_Cuenta.Id = tvCuentas.SelectedNode.Name
        D_Cuenta.Idcuentapadre = tvCuentas.SelectedNode.Tag
        If D_Cuenta.Get_Cuenta = True Then
            txtCuenta.Text = D_Cuenta.Codigo
            txtnombrecuenta.Text = D_Cuenta.Nombrecuenta
            dtFechaI.Value = D_Cuenta.Fechaini
            dtFechaF.Value = D_Cuenta.Fechafin
            txtSubCuenta.Text = D_Cuenta.Codigocuentapadre
            ckTipo.Checked = IIf(D_Cuenta.Tipo = 1, True, False)
            cbNombreTipo.SelectedValue = D_Cuenta.Idinsumo
            cbUnidad.SelectedValue = D_Cuenta.Unidad
            cbclas1.SelectedValue = D_Cuenta.Clasificacion1
            cbclas2.SelectedValue = D_Cuenta.Clasificacion2
            cbclas3.SelectedValue = D_Cuenta.Clasificacion3
            dt = D_Cuenta.Get_Precios()
            dgPrecios.Rows.Clear()

            For Each row As DataRow In dt.Rows
                dgPrecios.Rows.Add(row("id"), row("id_presupuesto"), Format(row("fecha"), Formato_FechaMonth),
                                   row("cantidad"), row("precio"), row("importe"))
            Next
        Else
            MsgBox("No se encontro la cuenta", vbInformation, "Validación")
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnbusCuen_Click(sender As Object, e As EventArgs) Handles btnbusCuen.Click
        Dim frm As New frmBuscaCuenta
        frm.D_tipollamada = 1
        frm.D_idobra = D_idobra
        frm.ShowDialog()
        If frm.Regcuenta.Id <> 0 Then
            D_Cuenta.Id = frm.Regcuenta.Id
            txtCuenta.Text = frm.Regcuenta.Codigo
            txtnombrecuenta.Text = frm.Regcuenta.Nombrecuenta
            dtFechaI.Value = frm.Regcuenta.Fechaini
            dtFechaF.Value = frm.Regcuenta.Fechafin
            cbclas1.SelectedValue = frm.Regcuenta.Clasificacion1
            cbclas2.SelectedValue = frm.Regcuenta.Clasificacion2
            cbclas3.SelectedValue = frm.Regcuenta.Clasificacion3
            ckTipo.Checked = IIf(frm.Regcuenta.Tipo = 1, True, False)
            cbNombreTipo.SelectedValue = frm.Regcuenta.Idinsumo
        End If
        frm = Nothing
    End Sub

    Private Sub BtnbusSub_Click(sender As Object, e As EventArgs) Handles btnbusSub.Click
        Dim frm As New frmBuscaCuenta
        frm.D_tipollamada = 2
        frm.D_idobra = D_idobra
        frm.D_idcuentafiltro = D_Cuenta.Id
        frm.ShowDialog()
        If frm.Regcuenta.Id <> 0 Then
            txtCuenta.Text = frm.Regcuenta.Codigo
            txtnombrecuenta.Text = frm.Regcuenta.Nombrecuenta
        End If
        frm = Nothing
    End Sub

    Private Sub Limpiar_Cuenta()
        D_Cuenta = New clCuenta
        txtCuenta.Text = ""
        txtnombrecuenta.Text = ""
        dtFechaI.Value = Date.Now
        dtFechaF.Value = Date.Now
        txtSubCuenta.Text = ""
        ckTipo.Checked = False
        cbNombreTipo.SelectedValue = 0
        cbUnidad.SelectedValue = 0
        cbclas1.SelectedValue = 0
        cbclas2.SelectedValue = 0
        cbclas3.SelectedValue = 0
        dgPrecios.Rows.Clear()
        dgFechas.Rows.Clear()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar_Cuenta()
    End Sub

    Private Sub Valida_Cuenta()
        If D_Cuenta.Id = 0 Then
            If dDicCuentas.ContainsKey(txtCuenta.Text) Then
                MsgBox("La cuenta ya existe")
            End If
        End If
    End Sub

End Class
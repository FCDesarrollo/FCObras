﻿Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmObras
    Private D_Empresas As Collection
    Private D_ObrasAll As Collection
    Private D_Load As Boolean
    Private D_IDEmpresa As Integer
    Private D_RFC As String
    Private D_IDSucursal As Integer
    Private D_Obra As clObra
    Private Sub FrmObras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        D_Empresas = New Collection
        D_Load = True
        Limpiar_Obra()
        Carga_estatus()
        D_Empresas = Carga_empresas()
        Llena_ComboEmpresa(D_Empresas, cbempresas)
        D_Load = False
    End Sub

    Private Sub Bloque_Botones()
        If D_Obra.Id = 0 Then
            btnPartidas.Enabled = False
            btnEliminar.Enabled = False
            btnADDPresupuesto.Enabled = False
            btnDelPresupuesto.Enabled = False
            btnADDPlan.Enabled = False
            btnDelPlan.Enabled = False
        Else
            btnPartidas.Enabled = True
            btnEliminar.Enabled = True
            btnADDPresupuesto.Enabled = True
            btnDelPresupuesto.Enabled = True
            btnADDPlan.Enabled = True
            btnDelPlan.Enabled = True
        End If
    End Sub
    Private Sub Carga_estatus()
        Dim dt As DataTable
        Dim dr As DataRow

        dt = New DataTable("estatus")
        dt.Columns.Add("id")
        dt.Columns.Add("estatus")

        dr = dt.NewRow
        dr(0) = 1
        dr(1) = "ACTIVA"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr(0) = 0
        dr(1) = "INACTIVA"
        dt.Rows.Add(dr)

        cbEstatus.DataSource = dt
        cbEstatus.ValueMember = "id"
        cbEstatus.DisplayMember = "estatus"
    End Sub



    Private Sub Cbempresas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbempresas.SelectedIndexChanged
        If D_Load = True Then Exit Sub
        D_IDEmpresa = CInt(cbempresas.SelectedValue)
        Cambio_Empresa()
    End Sub

    Private Sub Cambio_Empresa()
        Dim empresa As clEmpresa
        dgObras.Rows.Clear()
        cbsucursales.DataSource = Nothing
        cbsucursales.Items.Clear()
        Limpiar_Obra()
        For Each empresa In D_Empresas
            If empresa.Idempresa = D_IDEmpresa Then
                D_RFC = empresa.Rfc
                If DConexiones Is Nothing Then FC_GetCons()
                DConexiones("CON").ChangeDatabase(empresa.BddCont)
                D_Load = True
                Llena_ComboSucursal(empresa.ColSucursales, cbsucursales)
                D_Load = False
                Exit For
            End If
        Next empresa
    End Sub

    Private Sub Limpiar_Obra()
        txtobra.Text = ""
        cbEstatus.SelectedIndex = 0
        dtFechaF.Value = Now
        dtFechaI.Value = Now
        txtdes.Text = ""
        dgPlanes.Rows.Clear()
        dgPresupuesto.Rows.Clear()
        D_Obra = New clObra
        D_Obra.Idsucursal = D_IDSucursal
        Bloque_Botones()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dgObras.ClearSelection()
        Limpiar_Obra()
    End Sub

    Private Sub Cbsucursales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsucursales.SelectedIndexChanged
        If D_Load = True Then Exit Sub
        D_ObrasAll = New Collection
        D_IDSucursal = CInt(cbsucursales.SelectedValue)
        Limpiar_Obra()
        If D_IDSucursal > 0 Then
            D_Obra.Idsucursal = D_IDSucursal
            D_ObrasAll = D_Obra.Carga_Obras
        End If
        Llena_GridObras()
    End Sub

    Private Sub Llena_GridObras()
        Dim gObra As clObra
        dgObras.Rows.Clear()
        For Each gObra In D_ObrasAll
            dgObras.Rows.Add(gObra.Id, gObra.Nombreobra, IIf(gObra.Estatus = 1, "ACTIVA", "INACTIVA"))
        Next gObra
        'dgObras.ClearSelection()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If D_IDSucursal = 0 Then Exit Sub
        If Valida_Obra() = True Then
            D_Obra.Nombreobra = txtobra.Text
            D_Obra.Fechaini = Format(dtFechaI.Value, Formato_FechaYear)
            D_Obra.Fechafin = Format(dtFechaF.Value, Formato_FechaYear)
            D_Obra.Descripcion = txtdes.Text
            D_Obra.Estatus = cbEstatus.SelectedValue
            If D_Obra.Id = 0 Then
                D_Obra.Guarda_Obra()
                If D_Obra.Id <> 0 Then
                    AgregaDefault_Presupuesto()
                    AgregaDefault_PlanCrono()
                    D_ObrasAll.Add(D_Obra)
                    muestra_Presupuestos()
                    muestra_Planes()
                End If
            Else
                ''FALTA POR EDITAR
            End If
            Bloque_Botones()
            Llena_GridObras()
        End If
    End Sub

    Private Function Valida_Obra() As Boolean
        Dim vRes As Boolean
        vRes = True
        If txtobra.Text = "" Then
            MsgBox("El nombre de la Obra es incorrecto.", vbExclamation, "Validación")
            txtobra.Select()
            vRes = False
        ElseIf dtFechaF.Value.Date < dtFechaI.Value.Date Then
            MsgBox("La fecha final de la obra no debe ser menor a la inicial.", vbExclamation, "Validación")
            dtFechaF.Select()
            vRes = False
        ElseIf txtdes.Text = "" Then
            MsgBox("Escribir una descripción de la obra.", vbExclamation, "Validación")
            txtdes.Select()
            vRes = False
        End If

        Return vRes
    End Function

    Private Sub dgObras_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgObras.CellClick
        If IsNothing(dgObras.CurrentRow) Then Exit Sub
        If e.RowIndex >= 0 Then
            If D_Obra.Id <> dgObras.Item(0, dgObras.CurrentRow.Index).Value Then
                D_Obra.Id = dgObras.Item(0, dgObras.CurrentRow.Index).Value
                Muestra_Obra()
            End If
        End If
    End Sub

    Private Sub Muestra_Obra()
        Dim obra As clObra, presupuesto As New clPresupuesto
        Dim plancrono As New clPlanCrono

        For Each obra In D_ObrasAll
            If obra.Id = D_Obra.Id Then
                D_Obra.Nombreobra = obra.Nombreobra
                D_Obra.Fechaini = obra.Fechaini
                D_Obra.Fechafin = obra.Fechafin
                D_Obra.Descripcion = obra.Descripcion
                D_Obra.Estatus = obra.Estatus
                Exit For
            End If
        Next

        txtobra.Text = D_Obra.Nombreobra
        cbEstatus.SelectedValue = D_Obra.Estatus
        dtFechaI.Value = D_Obra.Fechaini
        dtFechaF.Value = D_Obra.Fechafin
        txtdes.Text = D_Obra.Descripcion

        presupuesto.Idobra = D_Obra.Id
        D_Obra.ColPresupuestos = presupuesto.Carga_Presupuestos()
        muestra_Presupuestos()

        plancrono.Idobra = D_Obra.Id
        D_Obra.ColPlanCrono = plancrono.Carga_PlanesCrono()
        muestra_Planes()

        Bloque_Botones()

        plancrono = Nothing
        presupuesto = Nothing
    End Sub

    Private Sub AgregaDefault_Presupuesto()
        Dim presupuesto As New clPresupuesto

        presupuesto.Idobra = D_Obra.Id
        presupuesto.Nombrepresupuesto = "DEFAULT PRESUPUESTO"
        presupuesto.Descripcion = "Presupuesto 1"
        presupuesto.Guarda_Presupuesto()
        If presupuesto.Id <> 0 Then
            D_Obra.ColPresupuestos.Add(presupuesto)
        End If

        presupuesto = Nothing
    End Sub

    Private Sub AgregaDefault_PlanCrono()
        Dim plancrono As New clPlanCrono

        plancrono.Idobra = D_Obra.Id
        plancrono.Nombreplan = "DEFAULT PLAN CRONOLOGICO"
        plancrono.Descripcion = "Plan cronologico agregado default a la obra"
        plancrono.Guarda_PlanCrono()

        If plancrono.Id <> 0 Then
            D_Obra.ColPlanCrono.Add(plancrono)
        End If

        plancrono = Nothing
    End Sub

    Private Sub muestra_Presupuestos()
        Dim presupuesto As clPresupuesto
        Dim combobox As DataGridViewComboBoxCell
        Dim dtt As DataTable, dtPresu As DataTable
        Dim dr As DataRow

        Dim rutaAr As String
        rutaAr = GeneralFC.FC_RutaSincronizada & "\" & D_RFC & "\" & GL_ModActual & "\" & D_Obra.Id

        dgPresupuesto.Rows.Clear()

        For Each presupuesto In D_Obra.ColPresupuestos
            dgPresupuesto.Rows.Add(presupuesto.Id, presupuesto.Nombrepresupuesto, "", "abrir")
            combobox = dgPresupuesto.Rows(dgPresupuesto.Rows.Count - 1).Cells(2)
            dtt = New DataTable("documentos")
            dtt.Columns.Add("ruta")
            dtt.Columns.Add("archivo")

            dr = dtt.NewRow()
            dr(0) = 0
            dr(1) = "Seleccione"
            dtt.Rows.Add(dr)

            dtPresu = presupuesto.Get_DocumentosPresupuestos
            For Each row As DataRow In dtPresu.Rows
                dr = dtt.NewRow()
                dr(0) = rutaAr & "\" & row("archivo")
                dr(1) = row("archivo")
                dtt.Rows.Add(dr)
            Next

            combobox.DataSource = dtt
            combobox.DisplayMember = "archivo"
            combobox.ValueMember = "ruta"
        Next
    End Sub

    Private Sub muestra_Planes()
        Dim plancrono As clPlanCrono
        dgPlanes.Rows.Clear()

        For Each plancrono In D_Obra.ColPlanCrono
            dgPlanes.Rows.Add(plancrono.Id, plancrono.Nombreplan)
        Next
    End Sub

    Private Sub dgObras_SelectionChanged(sender As Object, e As EventArgs) Handles dgObras.SelectionChanged
        If IsNothing(dgObras.CurrentRow) Then Exit Sub
        If dgObras.CurrentRow.Index >= 0 Then
            If D_Obra.Id <> dgObras.Item(0, dgObras.CurrentRow.Index).Value Then
                D_Obra.Id = dgObras.Item(0, dgObras.CurrentRow.Index).Value
                Muestra_Obra()
            End If
        End If
    End Sub

    Private Sub BtnPartidas_Click(sender As Object, e As EventArgs) Handles btnPartidas.Click
        Dim frm As New frmCuentas
        frm.D_idobra = D_Obra.Id
        frm.D_nombreobra = D_Obra.Nombreobra
        frm.D_nombreempresa = cbempresas.Text
        frm.ShowDialog()

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If D_Obra.Id <> 0 Then
            If MsgBox("Al Eliminar la obra se eliminara toda su información." & vbCrLf _
                        & "Cuentas,presupuestos,planes y precios" & vbCrLf _
                        & "¿Desea Continuar?", vbYesNoCancel, "Validación") = vbYes Then
                D_Obra.Eliminar_obra()
                Limpiar_Obra()
                dgObras.Rows.Remove(dgObras.CurrentRow)
            End If
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnADDPresupuesto_Click(sender As Object, e As EventArgs) Handles btnADDPresupuesto.Click
        Dim frm As New frmpresupuesto
        Dim presupuesto As New clPresupuesto
        If D_Obra.Id <> 0 Then
            frm.P_Idobra = D_Obra.Id
            frm.P_rfc = D_RFC
            frm.ShowDialog()
            frm.Dispose()
            presupuesto.Idobra = D_Obra.Id
            D_Obra.ColPresupuestos = presupuesto.Carga_Presupuestos()
            muestra_Presupuestos()
        End If
    End Sub

    Private Sub BtnDelPresupuesto_Click(sender As Object, e As EventArgs) Handles btnDelPresupuesto.Click
        Dim presupuesto As New clPresupuesto
        If D_Obra.Id <> 0 Then
            If Not dgPresupuesto.CurrentRow Is Nothing Then
                If MsgBox("Se va eliminar el presupuesto " &
                          dgPresupuesto.Item(1, dgPresupuesto.CurrentRow.Index).Value &
                          vbCrLf & "¿Desea Continuar?", vbYesNoCancel, "Validación") = vbYes Then
                    presupuesto.Id = dgPresupuesto.Item(0, dgPresupuesto.CurrentRow.Index).Value
                    presupuesto.Elimina_Presupuesto()
                    presupuesto.Idobra = D_Obra.Id
                    D_Obra.ColPresupuestos = presupuesto.Carga_Presupuestos()
                    muestra_Presupuestos()
                End If
            End If
        End If
    End Sub


    Private Sub dgPresupuesto_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPresupuesto.CellContentDoubleClick
        Dim frm As New frmpresupuesto
        Dim presupuesto As New clPresupuesto
        If dgPresupuesto.CurrentRow Is Nothing Then Exit Sub

        If e.RowIndex >= 0 Then
            If D_Obra.Id <> 0 Then
                frm.P_Idobra = D_Obra.Id
                frm.P_rfc = D_RFC
                frm.P_id = dgPresupuesto.Item(0, e.RowIndex).Value
                frm.ShowDialog()
                frm.Dispose()
                presupuesto.Idobra = D_Obra.Id
                D_Obra.ColPresupuestos = presupuesto.Carga_Presupuestos()
                muestra_Presupuestos()
            End If
        End If
    End Sub

    Private Sub TxtBuscaObra_TextChanged(sender As Object, e As EventArgs) Handles txtBuscaObra.TextChanged
        'Busca_Obra(txtBuscaObra.Text)
    End Sub

    Private Sub Busca_Obra(ByVal dBus As String)
        'Dim gObra As clObra
        'dgObras.Rows.Clear()

        'For Each gObra In D_ObrasAll
        '    If InStr(gObra.Nombreobra, dBus, vbTextCompare) <> 0 Then
        '        dgObras.Rows.Add(gObra.Id, gObra.Nombreobra, IIf(gObra.Estatus = 1, "ACTIVA", "INACTIVA"))
        '        Exit For
        '    End If
        'Next gObra
    End Sub
End Class
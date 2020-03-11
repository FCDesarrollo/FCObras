Imports System.Data.SqlClient
Imports System.IO
Imports OfficeOpenXml

Public Class frmOrdenes
    Private D_Empresas As Collection
    Private D_Load As Boolean
    Private D_IDEmpresa As Integer
    Private D_IDSucursal As Integer
    Private D_UsaComercial As Boolean
    Private D_RutaDoc As String

    Private D_VistaDocumentos As DataView

    Private Sub CObra_Click(sender As Object, e As EventArgs)
        Dim frm As New frmObras
        frm.ShowDialog()
    End Sub

    Private Sub FrmConstruccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toltip.SetToolTip(btnNuevo, "Crea una nueva orden")
        toltip.SetToolTip(btnRefrescar, "Refresca el estatus de la orden")
        toltip.SetToolTip(btnAutoriza, "Abre la orden para autorizar")
        D_Empresas = New Collection
        D_Load = True
        D_Empresas = Carga_empresas()
        Llena_ComboEmpresa(D_Empresas, cbempresas)
        Carga_estatus()
        D_Load = False
    End Sub

    Private Sub Cbempresas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbempresas.SelectedIndexChanged
        If D_Load = True Then Exit Sub
        D_IDEmpresa = CInt(cbempresas.SelectedValue)
        If D_IDEmpresa > 0 Then
            Cambio_Empresa()
        End If
    End Sub

    Private Sub Cambio_Empresa()
        Dim empresa As clEmpresa
        dgOrdenes.Rows.Clear()
        cbsucursales.DataSource = Nothing
        cbsucursales.Items.Clear()
        For Each empresa In D_Empresas
            If empresa.Idempresa = D_IDEmpresa Then
                If IsNothing(DConexiones) Then FC_GetCons()
                DConexiones("CON").ChangeDatabase(empresa.BddCont)
                D_Load = True
                Llena_ComboSucursal(empresa.ColSucursales, cbsucursales)
                D_Load = False
                Exit For
            End If
        Next empresa
    End Sub

    Private Sub Cambio_Sucursal()
        Dim empresa As clEmpresa, sucursal As clSucursal
        For Each empresa In D_Empresas
            If empresa.Idempresa = D_IDEmpresa Then
                For Each sucursal In empresa.ColSucursales
                    If sucursal.Idsucursal = D_IDSucursal Then
                        D_UsaComercial = IIf(sucursal.Usacomercial = 1, True, False)

                        D_Load = True
                        If D_UsaComercial = False Then
                            D_RutaDoc = sucursal.BddAdw
                            FC_ConexionFOX(sucursal.BddAdw)
                            Carga_ordenesADW()
                        Else
                            ''PENDIENTE
                        End If
                        D_Load = False
                        Exit For
                    End If
                Next sucursal
                Exit For
            End If
        Next empresa
    End Sub




    Private Sub Carga_ordenesADW()
        Dim dQue As String, fQue As String, dicCampos As New Dictionary(Of Integer, Integer)
        Dim estatus As String, idestado As Integer, dicConceptos As New Dictionary(Of Integer, String)
        Dim fechaMin As Date
        D_VistaDocumentos = New DataView

        Dim dr As DataRow
        Dim dt As New DataTable("documentos")
        dt.Columns.Add("iddoc")
        dt.Columns.Add("Obra")
        dt.Columns.Add("Concepto")
        dt.Columns.Add("Estatus")
        dt.Columns.Add("Fecha")
        dt.Columns.Add("Serie")
        dt.Columns.Add("Folio")
        dt.Columns.Add("Razón Social")
        dt.Columns.Add("Total")
        dt.Columns.Add("idmoneda")
        dt.Columns.Add("tipodecambio")
        dt.Columns.Add("idobra")

        dgOrdenes.DataSource = Nothing
        dgOrdenes.Rows.Clear()

        dQue = "SELECT iddocadw,validado FROM zConsDocCampos WHERE idsucursal=" & D_IDSucursal & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCR = dCom.ExecuteReader
                Do While dCR.Read
                    If Not dicCampos.ContainsKey(dCR("iddocadw")) Then
                        dicCampos.Add(dCR("iddocadw"), dCR("validado"))
                    End If
                Loop
            End Using
        End Using

        dQue = "SELECT idconcepto,codigo FROM zConsConceptos WHERE idsucursal=" & D_IDSucursal & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCR = dCom.ExecuteReader
                Do While dCR.Read
                    If Not dicConceptos.ContainsKey(dCR("idconcepto")) Then
                        dicConceptos.Add(dCR("idconcepto"), dCR("codigo"))
                    End If
                Loop
            End Using
        End Using

        dQue = "SELECT DISTINCT idconcepto FROM zConsObras WHERE idsucursal=" & D_IDSucursal & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCR = dCom.ExecuteReader
                Do While dCR.Read
                    If Not dicConceptos.ContainsKey(dCR("idconcepto")) Then
                        dicConceptos.Add(dCR("idconcepto"), CStr(dCR("idconcepto")))
                    End If
                Loop
            End Using
        End Using

        fechaMin = Date.Now.Date
        For Each conce As KeyValuePair(Of Integer, String) In dicConceptos
            fQue = "SELECT M08.CIDDOCUM01,CFECHA,CSERIEDO01,CFOLIO,CRAZONSO01,
                                CTOTAL,CREFEREN01,CNOMBREC01,CIDMONEDA,CTIPOCAM01,M08.CTEXTOEX03
                            FROM MGW10008 M08 INNER JOIN MGW10006 M06 ON M08.CIDCONCE01=M06.CIDCONCE01 
                    WHERE M06.CIDCONCE01=" & conce.Key & " order by CFECHA desc"
            Using fCom = New Odbc.OdbcCommand(fQue, FC_CONFOX)
                Using fRs = fCom.ExecuteReader
                    Do While fRs.Read
                        idestado = 0
                        If dicCampos.ContainsKey(fRs("CIDDOCUM01")) Then
                            idestado = dicCampos.Item(fRs("CIDDOCUM01"))
                            dicCampos.Remove(fRs("CIDDOCUM01"))
                        End If

                        If fechaMin > Format(fRs("CFECHA"), Formato_FechaMonth) Then
                            fechaMin = Format(fRs("CFECHA"), Formato_FechaMonth)
                        End If

                        estatus = Get_Estatus(idestado)
                        dr = dt.NewRow
                        dr(0) = fRs("CIDDOCUM01")
                        dr(1) = Trim(fRs("CREFEREN01"))
                        dr(2) = Trim(fRs("CNOMBREC01"))
                        dr(3) = estatus
                        dr(4) = Format(fRs("CFECHA"), Formato_FechaMonth)
                        dr(5) = Trim(fRs("CSERIEDO01"))
                        dr(6) = fRs("CFOLIO")
                        dr(7) = Trim(fRs("CRAZONSO01"))
                        dr(8) = Format(fRs("CTOTAL"), Format_Moneda)
                        dr(9) = fRs("CIDMONEDA")
                        dr(10) = fRs("CTIPOCAM01")
                        dr(11) = fRs("CTEXTOEX03")
                        dt.Rows.Add(dr)

                    Loop
                End Using
            End Using

        Next

        For Each campos As KeyValuePair(Of Integer, Integer) In dicCampos
            Borra_CamposExtras(campos.Key)
        Next

        D_VistaDocumentos = dt.DefaultView
        With dgOrdenes
            .DataSource = D_VistaDocumentos
            .Columns("iddoc").Visible = False
            .Columns("Obra").Width = 200
            .Columns("Concepto").Width = 160
            .Columns("Estatus").Width = 100
            .Columns("Fecha").Width = 100
            .Columns("Serie").Width = 50
            .Columns("Folio").Width = 80
            .Columns("Razón Social").Width = 220
            .Columns("Total").Width = 100

            .Columns("idmoneda").Visible = False
            .Columns("tipodecambio").Visible = False
            .Columns("idobra").Visible = False
        End With

        dtFechaI.Value = fechaMin
        DtfechaF.Value = Date.Now.Date
        Filtro_Ordenes()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim frm As New frmOrden
        If D_IDSucursal > 0 Then
            frm.ONombreEmpresa = cbempresas.Text
            frm.OIDEmpesa = D_IDEmpresa
            frm.OIDSucursal = D_IDSucursal
            frm.OUsaComercial = D_UsaComercial
            frm.ORutaDoc = D_RutaDoc
            frm.ShowDialog()
            frm.Dispose()
            If D_UsaComercial = True Then

            Else
                Carga_ordenesADW()
            End If

        Else
            MsgBox("Seleccione una sucursal.", vbInformation, "Validación")
        End If
    End Sub

    Private Sub Cbsucursales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsucursales.SelectedIndexChanged
        If D_Load = True Then Exit Sub
        D_IDSucursal = CInt(cbsucursales.SelectedValue)
        dgOrdenes.DataSource = Nothing
        D_VistaDocumentos = Nothing

        If D_IDSucursal > 0 Then
            Cambio_Sucursal()
        End If
    End Sub

    Private Sub dgOrdenes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgOrdenes.CellContentDoubleClick
        If dgOrdenes.CurrentRow Is Nothing Then Exit Sub

        If e.RowIndex >= 0 Then
            Dim frm As New frmOrden
            frm.ONombreEmpresa = cbempresas.Text
            frm.OIDEmpesa = D_IDEmpresa
            frm.OIDSucursal = D_IDSucursal
            frm.OUsaComercial = D_UsaComercial
            frm.ORutaDoc = D_RutaDoc
            frm.OIDDoc = dgOrdenes.Item(0, e.RowIndex).Value
            frm.ShowDialog()
            frm.Dispose()

            If D_UsaComercial = True Then

            Else
                Carga_ordenesADW()
            End If
        End If
    End Sub

    Private Sub dtFechaI_ValueChanged(sender As Object, e As EventArgs) Handles dtFechaI.ValueChanged
        If D_Load = True Then Exit Sub
        Filtro_Ordenes()
    End Sub

    Private Sub DtfechaF_ValueChanged(sender As Object, e As EventArgs) Handles DtfechaF.ValueChanged
        If D_Load = True Then Exit Sub
        Filtro_Ordenes()
    End Sub


    Public Sub Filtro_Ordenes()
        Dim filFechas As String, filEstatus As String
        If Not IsNothing(D_VistaDocumentos) Then
            If cbEstatus.SelectedValue <> -1 Then
                filEstatus = " and Estatus = '" & cbEstatus.Text & "'"
            End If
            filFechas = "Fecha >=#" &
                    dtFechaI.Value.Date & "# and Fecha<=#" & DtfechaF.Value.Date & "#"
            D_VistaDocumentos.RowFilter = filFechas & filEstatus

        End If
    End Sub
    Private Sub Carga_estatus()
        Dim dt As New DataTable()
        Dim dr As DataRow

        dt.Columns.Add("idestatus")
        dt.Columns.Add("estatus")

        dr = dt.NewRow
        dr("idestatus") = -1
        dr("estatus") = "Todos"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("idestatus") = -3
        dr("estatus") = "Autorizado Automatico"
        dt.Rows.Add(dr)

        For x = 0 To 7
            dr = dt.NewRow
            dr("idestatus") = x
            dr("estatus") = Get_Estatus(x)
            dt.Rows.Add(dr)
        Next

        cbEstatus.DataSource = dt
        cbEstatus.DisplayMember = "estatus"
        cbEstatus.ValueMember = "idestatus"

    End Sub

    Private Sub cbEstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEstatus.SelectedIndexChanged
        If D_Load = True Then Exit Sub
        Filtro_Ordenes()
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        If dgOrdenes.Rows.Count > 0 Then
            Dim folder As New FolderBrowserDialog
            Dim ruta As String = String.Empty

            If folder.ShowDialog = Windows.Forms.DialogResult.OK Then
                ruta = folder.SelectedPath
                Exporta_Excel(ruta)
                MsgBox("Archivo Exportado.", vbInformation, "Validación")
            End If

        End If
    End Sub

    Private Sub Exporta_Excel(ByVal Ruta As String)
        Dim dt As DataTable = D_VistaDocumentos.ToTable
        Dim nomcol As String
        nomcol = dt.Columns("iddoc").Caption
        dt.Columns.Remove(nomcol)
        nomcol = dt.Columns("idmoneda").Caption
        dt.Columns.Remove(nomcol)
        nomcol = dt.Columns("tipodecambio").Caption
        dt.Columns.Remove(nomcol)
        nomcol = dt.Columns("idobra").Caption
        dt.Columns.Remove(nomcol)
        Dim fileg As New FileInfo(Ruta & "\ordenes.xlsx")
        If System.IO.File.Exists(Ruta & "\ordenes.xlsx") = True Then
            System.IO.File.Delete(Ruta & "\ordenes.xlsx")
        End If
        Using package As New ExcelPackage(fileg)
            Dim ws As ExcelWorksheet = package.Workbook.Worksheets.Add("Ordenes")

            ws.Cells("A1").Value = "Empresa: " & cbempresas.Text
            ws.Cells("A2").Value = "Sucursal: " & cbsucursales.Text
            ws.Cells("A3").Value = "Ordenes del " & dtFechaI.Value & " al " & DtfechaF.Value
            ws.Cells("A4").Value = "Estatus: " & cbEstatus.Text
            For t = 1 To 4
                ws.Row(t).Style.Font.Bold = True
            Next t
            ws.Cells("A6").LoadFromDataTable(dt, True)

            For t = 1 To 8
                ws.Column(t).AutoFit()
            Next t
            package.Save()
        End Using
    End Sub

    Private Sub btnAutoriza_Click(sender As Object, e As EventArgs) Handles btnAutoriza.Click
        If Not dgOrdenes.CurrentRow Is Nothing Then
            If dgOrdenes.Item(3, dgOrdenes.CurrentRow.Index).Value = "Pendiente" Then
                If MsgBox("Se va autorizar el documento: " & vbCrLf &
                      dgOrdenes.Item(2, dgOrdenes.CurrentRow.Index).Value &
                      vbCrLf & "De la Obra: " & dgOrdenes.Item(1, dgOrdenes.CurrentRow.Index).Value &
                      vbCrLf & "Con folio-Serie: " &
                      dgOrdenes.Item(6, dgOrdenes.CurrentRow.Index).Value &
                      "-" & dgOrdenes.Item(5, dgOrdenes.CurrentRow.Index).Value, vbYesNoCancel, "Validación") = vbYes Then
                    Autoriza_Temporal(dgOrdenes.Item(0, dgOrdenes.CurrentRow.Index).Value, dgOrdenes.Item(11, dgOrdenes.CurrentRow.Index).Value)
                    MsgBox("Documento Autorizado.", vbInformation, "Validación")
                End If
            Else
                MsgBox("El documento ya esta autorizado.", vbInformation, "Validación")
            End If
        End If
    End Sub

    Private Sub Autoriza_Temporal(ByVal aIDDoc As Integer, ByVal aIDObra As Integer)
        Dim dQue As String, aIDConce As Integer

        dQue = "UPDATE zConsDocCampos SET validado=3 WHERE iddocadw=" & aIDDoc & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            dCom.ExecuteNonQuery()
        End Using
        aIDConce = Get_IdConcetpAutoriza(aIDObra, D_IDSucursal)
        If aIDConce <> 0 Then
            dQue = "UPDATE MGW10008 SET CIDCONCE01=" & aIDConce & " WHERE CIDDOCUM01=" & aIDDoc & ""
            Using dCom = New Odbc.OdbcCommand(dQue, FC_CONFOX)
                dCom.ExecuteNonQuery()
            End Using
        End If
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        If D_IDSucursal > 0 Then
            If D_UsaComercial = True Then

            Else
                Carga_ordenesADW()
            End If
        End If
    End Sub
End Class
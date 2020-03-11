Imports System.Data.SqlClient

Public Class frmAvanceCuentas
    Private _d_ruta As String
    Private _d_idPre As Integer
    Private _d_idobra As Integer
    Public Property D_ruta As String
        Get
            Return _d_ruta
        End Get
        Set(value As String)
            _d_ruta = value
        End Set
    End Property

    Public Property D_idPre As Integer
        Get
            Return _d_idPre
        End Get
        Set(value As Integer)
            _d_idPre = value
        End Set
    End Property

    Public Property D_idobra As Integer
        Get
            Return _d_idobra
        End Get
        Set(value As Integer)
            _d_idobra = value
        End Set
    End Property


    Private Sub Carga_registrosexcel(ByVal idPre As Integer)
        Dim lLibro As String, f As Integer, uFil As Long, dkey As String, dkeyInsumo As String
        Dim dItemInsumo As Integer, dkeyPresu As String, dItemPre As Integer
        Dim dKeyUni As String, dItemUni As Integer
        Dim cuenta As clCuenta, cuentaAgregada As clCuenta
        Dim appXL As Microsoft.Office.Interop.Excel.Application
        Dim wbXl As Microsoft.Office.Interop.Excel.Workbook
        Dim shXL As Microsoft.Office.Interop.Excel.Worksheet

        Dim dDicCuentas As New Dictionary(Of String, clCuenta)
        Dim dDicInsumos As New Dictionary(Of String, Integer)
        Dim dDicPresupuestos As New Dictionary(Of String, Integer)
        Dim dDicUnidades As New Dictionary(Of String, Integer)
        Dim dDicCuentasAdd As New Collection, dQue As String

        ''CUENTAS
        dQue = "SELECT id,codigo FROM zConsCuentas WHERE id_obra=" & _d_idobra & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    cuenta = New clCuenta
                    cuenta.Id = dCr("id")
                    cuenta.Codigo = dCr("codigo")
                    dkey = dCr("codigo")
                    If Not dDicCuentas.ContainsKey(dkey) Then
                        dDicCuentas.Add(dkey, cuenta)
                    End If
                Loop
            End Using
        End Using

        ''PRESUPUESTOS
        dQue = "SELECT id,nombre_presupuesto FROM zConsPresupuestos WHERE id_obra=" & _d_idobra & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    dkeyPresu = UCase(Trim(dCr("nombre_presupuesto")))
                    dItemPre = dCr("id")
                    If Not dDicPresupuestos.ContainsKey(dkeyPresu) Then
                        dDicPresupuestos.Add(dkeyPresu, dItemPre)
                    End If
                Loop
            End Using
        End Using

        ''INSUMOS
        dQue = "SELECT id, codigo_insumo FROM zConsInsumos"
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    dkeyInsumo = UCase(dCr("codigo_insumo"))
                    dItemInsumo = dCr("id")
                    If Not dDicInsumos.ContainsKey(dkeyInsumo) Then
                        dDicInsumos.Add(dkeyInsumo, dItemInsumo)
                    End If
                Loop
            End Using
        End Using

        ''UNIDADES
        dQue = "SELECT id,clave_unidad FROM zConsUnidades"
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    dKeyUni = UCase(dCr("clave_unidad"))
                    dItemUni = dCr("id")
                    If Not dDicUnidades.ContainsKey(dKeyUni) Then
                        dDicUnidades.Add(dKeyUni, dItemUni)
                    End If
                Loop
            End Using
        End Using

        lLibro = _d_ruta ' "C:\Users\Arturo Gallegos\Desktop\Construccion\Layoutcuentas.xlsx"
        'Try
        appXL = New Microsoft.Office.Interop.Excel.Application
        'appXL.Visible = False
        wbXl = appXL.Workbooks.Open(lLibro)
        shXL = wbXl.ActiveSheet

        With shXL
            uFil = getLastRow(shXL)
            LAvance.Text = "Cargando registros "
            For f = 4 To uFil

                LAvance.Text = "Cargando registros " & f - 3 & " de " & uFil - 3
                LAvance.Refresh()
                picgif.Refresh()

                cuenta = New clCuenta

                dkey = .Cells(f, iColCuentas.iCodigo).value
                cuenta.Id = 0
                cuenta.Idobra = _d_idobra
                cuenta.Codigo = dkey
                cuenta.Nombrecuenta = .Cells(f, iColCuentas.iCuenta).value
                cuenta.Codigoadw = ""
                cuenta.Tipo = .Cells(f, iColCuentas.iTipoInsumo).value

                cuenta.Idinsumo = 0
                dkeyInsumo = UCase(IIf(IsNothing(.Cells(f, iColCuentas.iNOmInsumo).value), "", .Cells(f, iColCuentas.iNOmInsumo).value))
                If dDicInsumos.ContainsKey(dkeyInsumo) Then
                    cuenta.Idinsumo = dDicInsumos.Item(dkeyInsumo)
                End If

                ''DATOS PARA ASOCIACION
                cuenta.Idcuentapadre = 0
                cuenta.Fechaini = .Cells(f, iColCuentas.iFechaini).value
                cuenta.Fechafin = .Cells(f, iColCuentas.iFechaFin).value
                cuenta.Codigocuentapadre = IIf(IsNothing(.Cells(f, iColCuentas.iSubcuenta).value), "", .Cells(f, iColCuentas.iSubcuenta).value)
                cuenta.Fechaprecio = .Cells(f, iColCuentas.iFechaPrecio).value
                cuenta.Cantidad = .Cells(f, iColCuentas.iCantidad).value

                dKeyUni = UCase(IIf(IsNothing(.Cells(f, iColCuentas.iUnidad).value), "", .Cells(f, iColCuentas.iUnidad).value))
                cuenta.Unidad = 0
                If dDicUnidades.ContainsKey(dKeyUni) Then
                    cuenta.Unidad = dDicUnidades.Item(dKeyUni)
                End If

                cuenta.Idusuario = GL_cUsuario.Iduser
                cuenta.Estatus = 1
                cuenta.Precio = .Cells(f, iColCuentas.iPrecio).value
                cuenta.Importe = .Cells(f, iColCuentas.iImporte).value
                cuenta.Cantidadpendiente = .Cells(f, iColCuentas.iCantidad).value
                cuenta.Importependiente = .Cells(f, iColCuentas.iImporte).value


                dkeyPresu = UCase(IIf(IsNothing(.Cells(f, iColCuentas.iPresupuesto).value), "", .Cells(f, iColCuentas.iPresupuesto).value))
                cuenta.Idpresupuesto = idPre ''PENDIENTE
                If dDicPresupuestos.ContainsKey(dkeyPresu) Then
                    cuenta.Idpresupuesto = dDicPresupuestos.Item(dkeyPresu)
                End If

                If Not dDicCuentas.ContainsKey(dkey) Then
                    cuenta.Guarda_cuenta()
                    dDicCuentas.Add(dkey, cuenta)
                Else
                    cuentaAgregada = dDicCuentas.Item(dkey)
                    cuenta.Id = cuentaAgregada.Id
                End If

                dkey = .Cells(f, iColCuentas.iSubcuenta).value
                If dkey <> "" Then
                    If dDicCuentas.ContainsKey(dkey) Then
                        cuentaAgregada = dDicCuentas.Item(dkey)
                        cuenta.Idcuentapadre = cuentaAgregada.Id
                    End If
                End If
                If cuenta.Codigocuentapadre <> "" And cuenta.Idcuentapadre = 0 Then
                    dDicCuentasAdd.Add(cuenta)
                Else
                    cuenta.Guarda_Asociacion()
                End If
            Next
        End With

        LAvance.Text = "Finalizado cuentas cargadas"
            LAvance.Refresh()
            NAR(shXL)
            wbXl.Close(False)
            NAR(wbXl)
            NAR(wbXl)
            appXL.Quit()
            NAR(appXL)
            'MsgBox(dDicCuentasAdd.Count)
        'Catch ex As Exception
        '    MsgBox("Error al leer las cuentas." & vbCrLf & ex.Message, vbExclamation, "Validación")
        'End Try
    End Sub

    Private Sub NAR(ByVal o As Object)
        Try
            While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
            End While
        Catch
        Finally
            o = Nothing
        End Try
    End Sub

    Private Sub frmAvanceCuentas_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        picgif.Refresh()
        Carga_registrosexcel(_d_idPre)
        Me.Close()
    End Sub

    Private Sub FrmAvanceCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
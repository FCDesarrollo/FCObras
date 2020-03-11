Imports System.Data.SqlClient

Module modFuncionesGlobalesConst

    Public Function Carga_empresas() As Collection
        Dim oQue As String, sucQue As String, dEmpresas As New Collection
        Dim empresa As clEmpresa, Sucursal As clSucursal
        fCError = FC_Conexion()
        If fCError <> 0 Then Exit Function

        Try
            oQue = "SELECT IdEmpresa,Empresa,ctBDD,RFC FROM ConsEmpresas"
            Using oCom = New SqlCommand(oQue, FC_Con)
                Using oCr = oCom.ExecuteReader()
                    Do While oCr.Read
                        empresa = New clEmpresa

                        empresa.Idempresa = oCr("IdEmpresa")
                        empresa.Nombreempresa = Trim(oCr("Empresa"))
                        empresa.BddCont = Trim(oCr("ctBDD"))
                        empresa.Rfc = Trim(oCr("RFC"))

                        sucQue = "SELECT Nombre,IdAdw,Ruta,Sucursal,usaComercial FROM ConsRutasADW 
                                WHERE IDEmpresa=" & oCr("IdEmpresa") & ""
                        Using sucCom = New SqlCommand(sucQue, FC_Con)
                            Using sucCr = sucCom.ExecuteReader
                                Do While sucCr.Read
                                    Sucursal = New clSucursal
                                    Sucursal.Idsucursal = sucCr("IdAdw")
                                    Sucursal.NombreAdw = Trim(sucCr("Nombre"))
                                    Sucursal.Nombresucursal = Trim(sucCr("Sucursal"))
                                    Sucursal.BddAdw = Trim(sucCr("Ruta"))
                                    Sucursal.Usacomercial = sucCr("usaComercial")

                                    empresa.ColSucursales.Add(Sucursal)
                                Loop
                            End Using
                        End Using
                        If empresa.ColSucursales.Count > 0 Then
                            dEmpresas.Add(empresa)
                        End If
                    Loop
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al cargar las Empresas.", vbExclamation, "Validación")
        End Try

        Return dEmpresas
    End Function
    Public Sub Llena_ComboEmpresa(ByVal lColEmpresas As Collection, ByVal cb As ComboBox)
        Dim empresa As clEmpresa
        Dim dt As DataTable
        Dim dr As DataRow

        dt = New DataTable("empresas")
        dt.Columns.Add("id")
        dt.Columns.Add("Nombre")

        dr = dt.NewRow
        dr(0) = 0
        dr(1) = "SELECCIONAR EMPRESA"
        dt.Rows.Add(dr)

        For Each empresa In lColEmpresas
            dr = dt.NewRow
            dr(0) = empresa.Idempresa
            dr(1) = empresa.Nombreempresa
            dt.Rows.Add(dr)
        Next empresa

        cb.DataSource = dt
        cb.ValueMember = "id"
        cb.DisplayMember = "Nombre"
    End Sub

    Public Sub Llena_ComboSucursal(ByVal lColSucursales As Collection, ByVal cb As ComboBox)
        Dim sucursal As clSucursal
        Dim dt As DataTable
        Dim dr As DataRow

        dt = New DataTable("sucursales")
        dt.Columns.Add("id")
        dt.Columns.Add("Nombre")

        dr = dt.NewRow
        dr(0) = 0
        dr(1) = "SELECCIONAR SUCURSAL"
        dt.Rows.Add(dr)

        For Each sucursal In lColSucursales
            dr = dt.NewRow
            dr(0) = sucursal.Idsucursal
            dr(1) = sucursal.Nombresucursal
            dt.Rows.Add(dr)
        Next sucursal

        cb.DataSource = dt
        cb.ValueMember = "id"
        cb.DisplayMember = "Nombre"
    End Sub

    Public Function Get_numAsoc(ByVal gIDObra As Integer) As Integer
        Dim dNum As Integer, dQue As String

        dQue = "SELECT COUNT(*) as num FROM zConsAsociacionesPrecios WHERE id_obra=" & gIDObra & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCr = dCom.ExecuteReader
                dCr.Read()

                If dCr.HasRows Then
                    dNum = dCr("num")
                End If
            End Using
        End Using

        Return dNum
    End Function

    Public Function Get_IDPresupuesto(ByVal gIDObra As Integer) As Integer
        Dim dId As Integer, dQue As String

        dQue = "SELECT  TOP (1) id FROM zConsPresupuestos WHERE id_obra=" & gIDObra & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCr = dCom.ExecuteReader
                dCr.Read()
                If dCr.HasRows Then
                    dId = dCr("id")
                End If
            End Using
        End Using

        Return dId
    End Function

    Public Function Get_Estatus(ByVal ides As Integer) As String
        Dim resp As String

        Select Case ides
            Case = -3
                resp = "Autorizado Automatico"
            Case = 1
                resp = "Pendiente"
            Case = 2
                resp = "Cancelado"
            Case = 3
                resp = "Autorizado"
            Case = 4
                resp = "Surtido"
            Case = 5
                resp = "Surtido Parcial"
            Case = 6
                resp = "Sin Surtir"
            Case = 7
                resp = "No Autorizado"
            Case Else
                resp = "No Encontrado"
        End Select

        Return resp
    End Function

    Public Sub Get_Precio(ByVal aId As Integer, ByVal aIdPadre As Integer, ByVal aFecha As Date, ByRef idprecio As Integer, ByRef preciounitadrio As Double)
        Dim dQue As String

        dQue = "SELECT TOP(1) id,precio from zConsAsociacionesPrecios
                    WHERE id_cuenta=@idcuenta and id_cuentapadre=@idcuentapadre
                        and fecha <=@fecha order by id desc "
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            dCom.Parameters.AddWithValue("idcuenta", aId)
            dCom.Parameters.AddWithValue("idcuentapadre", aIdPadre)
            dCom.Parameters.AddWithValue("fecha", aFecha)
            Using dCr = dCom.ExecuteReader
                dCr.Read()
                If dCr.HasRows Then
                    idprecio = dCr("id")
                    preciounitadrio = dCr("precio")
                End If
            End Using
        End Using
    End Sub

    Public Sub Get_Concepto(ByVal dId As Integer, ByRef D_CodconceAuto As String, ByRef D_NomconceAuto As String)
        Dim fQue As String

        fQue = "SELECT CCODIGOC01,CNOMBREC01 FROM MGW10006 WHERE CIDCONCE01=" & dId & ""
        Using fCom = New Odbc.OdbcCommand(fQue, FC_CONFOX)
            Using fCr = fCom.ExecuteReader
                fCr.Read()
                If fCr.HasRows Then
                    D_CodconceAuto = Trim(fCr("CCODIGOC01"))
                    D_NomconceAuto = Trim(fCr("CNOMBREC01"))
                End If
            End Using
        End Using
    End Sub

    Public Sub Get_Almacen(ByVal dId As Integer, ByRef D_CodAlmacen As String, ByRef D_NomAlmacen As String)
        Dim fQue As String

        fQue = "SELECT CCODIGOA01,CNOMBREA01 FROM MGW10003 WHERE CIDALMACEN=" & dId & ""
        Using fCom = New Odbc.OdbcCommand(fQue, FC_CONFOX)
            Using fCr = fCom.ExecuteReader
                fCr.Read()
                If fCr.HasRows Then
                    D_CodAlmacen = Trim(fCr("CCODIGOA01"))
                    D_NomAlmacen = Trim(fCr("CNOMBREA01"))
                End If
            End Using
        End Using
    End Sub

    Public Sub Borra_CamposExtras(ByVal idDoc As Integer)
        Dim dQue As String, dAux As String

        dQue = "SELECT idasocprecio,cantidad,total FROM  zConsDoc_MovCampos WHERE iddocadw=" & idDoc & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCR = dCom.ExecuteReader
                Do While dCR.Read
                    dAux = "UPDATE zConsAsociacionesPrecios SET 
                        cantidad_pendiente=cantidad_pendiente+" & dCR("cantidad") & ",
                        importe_pendiente=importe_pendiente+" & dCR("total") & "
                        WHERE id=" & dCR("idasocprecio") & ""
                    Using aCom = New SqlCommand(dAux, DConexiones("CON"))
                        aCom.ExecuteNonQuery()
                    End Using
                Loop
            End Using
        End Using

        dQue = "DELETE FROM zConsDocCampos WHERE iddocadw=" & idDoc & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            dCom.ExecuteNonQuery()
        End Using

        dQue = "DELETE FROM zConsDoc_MovCampos WHERE iddocadw=" & idDoc & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            dCom.ExecuteNonQuery()
        End Using
    End Sub

    Public Function Get_IdConcetpAutoriza(ByVal iIDObra As Integer, ByVal iIDSucursal As Integer) As Integer
        Dim dQue As String, resp As Integer

        dQue = "SELECT idconcepto FROM zConsObras WHERE id=" & iIDObra & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCr = dCom.ExecuteReader
                dCr.Read()
                If dCr.HasRows Then
                    resp = dCr("idconcepto")
                End If
            End Using
        End Using

        If resp = 0 Then
            dQue = "SELECT idconcepto FROM zConsConceptos 
                WHERE idsucursal=" & iIDSucursal & " AND tipo=1"
            Using dCom = New SqlCommand(dQue, DConexiones("CON"))
                Using dCr = dCom.ExecuteReader
                    dCr.Read()
                    If dCr.HasRows Then
                        resp = dCr("idconcepto")
                    End If
                End Using
            End Using
        End If

        Return resp
    End Function
End Module

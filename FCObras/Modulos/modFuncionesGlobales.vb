Imports System.Data.SqlClient

Module modFuncionesGlobales

    Public Function Carga_empresas() As Collection
        Dim oQue As String, sucQue As String, dEmpresas As New Collection
        Dim empresa As clEmpresa, Sucursal As clSucursal
        fError = FC_Conexion()
        If fError <> 0 Then Exit Function

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
End Module

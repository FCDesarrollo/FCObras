Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Text

Module modFC_Premium

    Public Sub CrearTablasPremium()
        Dim cpCom As SqlCommand
        Dim cQue As String
        FC_Con.Close()
        fError = FC_Conexion()
        If fError <> 0 Then Exit Sub
        cQue = "IF OBJECT_ID('dbo.Instancias') IS NULL " &
                    "Begin CREATE TABLE [dbo].[Instancias]([id] [int] NULL,[nombre] [nvarchar](20) NULL," &
                    "[server] [nvarchar](50) NULL,[uid] [nvarchar](30) NULL,[pwd] [nvarchar](60) NULL) ON [PRIMARY] END"
        cpCom = New SqlCommand(cQue, FC_Con)
        cpCom.ExecuteNonQuery()
        cpCom.Dispose()

        cQue = "IF OBJECT_ID('dbo.FCModulos') IS NULL " &
                    "Begin CREATE TABLE [dbo].[FCModulos](
                            [idmodulo] [int] NOT NULL,
                            [nombre_modulo] [nvarchar](250) NOT NULL,
                            [version] [numeric](18, 2) NOT NULL,
                            [fechaactualizacion] [date] NULL,
                            [permiso] [int] NOT NULL,
                            [nombre_archivo] [nvarchar](250) NULL,
                            [nombre_ficha] [nvarchar](250) NULL,
                            [ficha_ver] [nvarchar](250) NULL,
                            [cargado] [int] NULL,
                            [archivo_ver] [nvarchar](250) NULL,
                            [nombre_carpeta] [nvarchar](250) NULL
                            ) ON [PRIMARY] END"
        cpCom = New SqlCommand(cQue, FC_Con)
        cpCom.ExecuteNonQuery()
        cpCom.Dispose()

        cQue = "IF OBJECT_ID('dbo.FCParametros') IS NULL " &
                    "Begin CREATE TABLE [dbo].[FCParametros](
	                        [ultima_actualizacion] [date] NULL,
	                        [Actualizado] [numeric](18, 2) NULL,
	                        [nombrecliente] [nvarchar](250) NULL,
	                        [rfccliente] [nvarchar](250) NULL
                        ) ON [PRIMARY] END"
        cpCom = New SqlCommand(cQue, FC_Con)
        cpCom.ExecuteNonQuery()
        cpCom.Dispose()

        cQue = "IF OBJECT_ID('dbo.FCUser') IS NULL " &
                    "Begin CREATE TABLE [dbo].[FCUser](
	                        [idusuario] [int] IDENTITY(1,1) NOT NULL,
	                        [nombre] [nvarchar](250) NOT NULL,
	                        [apellido_p] [nvarchar](250) NOT NULL,
	                        [apellido_m] [nvarchar](250) NOT NULL,
	                        [usuario] [nvarchar](150) NOT NULL,
	                        [password] [nvarchar](50) NOT NULL,
	                        [tipo] [int] NOT NULL,
	                        [status] [int] NOT NULL
                        ) ON [PRIMARY] END"
        cpCom = New SqlCommand(cQue, FC_Con)
        cpCom.ExecuteNonQuery()
        cpCom.Dispose()

        cQue = "IF OBJECT_ID('dbo.FCModUser') IS NULL " &
                    "Begin CREATE TABLE [dbo].[FCModUser](
	                    [idusuario] [int] NOT NULL,
	                    [idmodulo] [int] NOT NULL,
	                    [permiso] [int] NOT NULL
                    ) ON [PRIMARY] END"
        cpCom = New SqlCommand(cQue, FC_Con)
        cpCom.ExecuteNonQuery()
        cpCom.Dispose()

        cQue = "IF OBJECT_ID('dbo.ConsEmpresas') IS NULL " &
                    "Begin CREATE TABLE [dbo].[ConsEmpresas](
	                    [IdEmpresa] [int]  NOT NULL,
	                    [Empresa] [nvarchar](250) NULL,
	                    [ctBDD] [nvarchar](150) NULL
                    ) ON [PRIMARY] END"
        cpCom = New SqlCommand(cQue, FC_Con)
        cpCom.ExecuteNonQuery()
        cpCom.Dispose()

        cQue = "IF OBJECT_ID('dbo.ConsRutasADW') IS NULL " &
                    "Begin CREATE TABLE [dbo].[ConsRutasADW](
	                    [IDEmpresa] [int] NOT NULL,
	                    [Nombre] [nvarchar](max) NOT NULL,
	                    [IdAdw] [int] NOT NULL,
	                    [Ruta] [nvarchar](max) NOT NULL,
	                    [Sucursal] [nvarchar](max) NULL,
	                    [usaComercial] [int] NULL DEFAULT 0
                    ) ON [PRIMARY] END"
        cpCom = New SqlCommand(cQue, FC_Con)
        cpCom.ExecuteNonQuery()
        cpCom.Dispose()

        cQue = "IF OBJECT_ID('dbo.ConsUnidades') IS NULL " &
                    "Begin CREATE TABLE [dbo].[ConsUnidades](
	                [id] [int] IDENTITY(1,1) NOT NULL,
	                [clave_unidad] [nvarchar](60) NULL,
	                [nombre_unidad] [nvarchar](250) NULL
                ) ON [PRIMARY] END"
        cpCom = New SqlCommand(cQue, FC_Con)
        cpCom.ExecuteNonQuery()
        cpCom.Dispose()
    End Sub

    Public Function VerificaTablas() As Boolean
        Dim arrTabs() As String = {"Instancias", "FCModulos", "FCParametros", "FCUser", "FCModUser"}
        VerificaTablas = verificarTablasModulo(arrTabs)
    End Function

    Public Function Verifica_TablasGen_Actualiza() As Boolean
        Dim arrTabs() As String = {"ConsEmpresas", "ConsRutasADW", "ConsUnidades"}
        Verifica_TablasGen_Actualiza = verificarTablasModulo(arrTabs)
    End Function

    Public Function GetNumMod() As Integer
        Dim RsGet As SqlDataReader

        GetNumMod = 0
        Using ComRsGet As New SqlCommand("SELECT COUNT(*) AS NUMERO FROM FCModulos", FC_Con)
            RsGet = ComRsGet.ExecuteReader()
            RsGet.Read()
            If RsGet.HasRows = True Then
                If RsGet("NUMERO") IsNot DBNull.Value Then GetNumMod = RsGet("NUMERO")
            End If
            RsGet.Close()
        End Using
    End Function

    Public Function GetNumPermisoClien() As Integer
        Dim RsGet As SqlDataReader

        GetNumPermisoClien = 0
        Using ComRsGet As New SqlCommand("SELECT COUNT(*) AS NUMERO FROM FCModulos WHERE version<>0 AND permiso=1", FC_Con)
            RsGet = ComRsGet.ExecuteReader()
            RsGet.Read()
            If RsGet.HasRows = True Then
                If RsGet("NUMERO") IsNot DBNull.Value Then GetNumPermisoClien = RsGet("NUMERO")
            End If
            RsGet.Close()
        End Using
    End Function

    Public Function ConsumeAPI(ByVal aAPi As String, ByVal aMetodo As String,
                               ByVal aDatos As String, Optional sMe As String = "POST", Optional sType As String = "URL") As String
        Dim s As HttpWebRequest
        Dim enc As UTF8Encoding
        Dim response As HttpWebResponse
        Dim reader As StreamReader
        Dim rawresponse As String
        Dim postdata As String
        Dim postdatabytes As Byte()

        Try
            s = HttpWebRequest.Create(aAPi & aMetodo)
            enc = New System.Text.UTF8Encoding()
            If sMe = "POST" Then
                postdata = aDatos
                postdatabytes = enc.GetBytes(postdata)
                s.ContentLength = postdatabytes.Length
            End If
            s.Method = sMe
            If sType = "URL" Then
                s.ContentType = "application/x-www-form-urlencoded"
            Else
                s.ContentType = "application/json"
            End If

            If sMe = "POST" Then
                Using stream = s.GetRequestStream()
                    stream.Write(postdatabytes, 0, postdatabytes.Length)
                End Using
            End If
            'Dim result = s.GetResponse()
            response = DirectCast(s.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())

            rawresponse = reader.ReadToEnd()
            ConsumeAPI = rawresponse
        Catch ex As Exception
            MsgBox("Error al Consumir API", vbExclamation, "Validación")
            ConsumeAPI = ""
        End Try

    End Function

    Public Sub CreaTablas_ModConstruccion(ByVal dBdd As String)
        Dim cQue As String, cpCom As SqlCommand
        If IsNothing(DConexiones) Then FC_GetCons()
        DConexiones("CON").ChangeDatabase(dBdd)

        cQue = "IF OBJECT_ID('dbo.zConsObras') IS NULL " &
                    "Begin CREATE TABLE [dbo].[zConsObras](
	                    [id] [int] IDENTITY(1,1) NOT NULL,
	                    [idsucursal] [int] NOT NULL,
	                    [nombre_obra] [nvarchar](250) NOT NULL,
	                    [fecha_inicial] [date] NOT NULL,
	                    [fecha_final] [date] NOT NULL,
	                    [descripcion] [ntext] NULL,
	                    [estatus] [int] NOT NULL
                    ) ON [PRIMARY]  END"
        cpCom = New SqlCommand(cQue, DConexiones("CON"))
        cpCom.ExecuteNonQuery()
        cpCom.Dispose()

        cQue = "IF OBJECT_ID('dbo.zConsCuentas') IS NULL " &
                    "Begin CREATE TABLE [dbo].[zConsCuentas](
	                    [id] [int] IDENTITY(1,1) NOT NULL,
	                    [id_obra] [int] NOT NULL,
	                    [fechaInicio] [date] NULL,
	                    [fechaFinal] [date] NULL,
	                    [codigo] [nvarchar](150) NULL,
	                    [nombre_cuenta] [nvarchar](250) NULL,
	                    [codigo_adw] [nvarchar](150) NULL,
	                    [clasificacion1] [int] NULL,
	                    [clasificaicon2] [int] NULL,
	                    [clasificacion3] [int] NULL,
	                    [tipoinsumo] [int] NULL,
	                    [idinsumo] [int] NULL
                    ) ON [PRIMARY]  END"
        cpCom = New SqlCommand(cQue, DConexiones("CON"))
        cpCom.ExecuteNonQuery()
        cpCom.Dispose()

        cQue = "IF OBJECT_ID('dbo.zConsPlanesCrono') IS NULL " &
                    "Begin CREATE TABLE [dbo].[zConsPlanesCrono](
	                    [id] [int] IDENTITY(1,1) NOT NULL,
	                    [id_obra] [int] NOT NULL,
	                    [nombre_plan] [nvarchar](250) NULL,
	                    [descripcion] [nvarchar](250) NULL
                    ) ON [PRIMARY]  END"
        cpCom = New SqlCommand(cQue, DConexiones("CON"))
        cpCom.ExecuteNonQuery()
        cpCom.Dispose()

        cQue = "IF OBJECT_ID('dbo.zConsPresupuestos') IS NULL " &
                    "Begin CREATE TABLE [dbo].[zConsPresupuestos](
	                    [id] [int] IDENTITY(1,1) NOT NULL,
	                    [id_obra] [int] NULL,
	                    [nombre_presupuesto] [nvarchar](250) NULL,
	                    [descripcion] [nvarchar](250) NULL
                    ) ON [PRIMARY]  END"
        cpCom = New SqlCommand(cQue, DConexiones("CON"))
        cpCom.ExecuteNonQuery()
        cpCom.Dispose()

        cQue = "IF OBJECT_ID('dbo.zConsPresupuestos_Doc') IS NULL " &
                    "Begin CREATE TABLE [dbo].[zConsPresupuestos_Doc](
	                    [id] [int] IDENTITY(1,1) NOT NULL,
	                    [id_presupuesto] [int] NULL,
	                    [archivo] [nvarchar](250) NULL,
	                    [descripcion] [nvarchar](250) NULL
                    ) ON [PRIMARY]  END"
        cpCom = New SqlCommand(cQue, DConexiones("CON"))
        cpCom.ExecuteNonQuery()
        cpCom.Dispose()

        cQue = "IF OBJECT_ID('dbo.zConsAsociacionesPrecios') IS NULL " &
                    "Begin CREATE TABLE [dbo].[zConsAsociacionesPrecios](
	                    [id] [int] IDENTITY(1,1) NOT NULL,
                        [id_obra] [int] NULL,
	                    [id_cuenta] [int] NOT NULL,
	                    [id_cuentapadre] [int] NOT NULL,
	                    [codigo_cuenta] [nvarchar](250) NOT NULL,
	                    [codigo_cuentapadre] [nvarchar](250) NOT NULL,
	                    [fecha] [date] NULL,
	                    [id_presupuesto] [INT] NOT NULL,
	                    [cantidad] [numeric](18, 2) NULL,
	                    [unidad] [int] NULL,
	                    [precio] [numeric](18, 2) NULL,
	                    [importe] [numeric](18, 2) NULL,
	                    [cantidad_pendiente] [numeric](18, 2) NULL,
	                    [importe_pendiente] [numeric](18, 2) NULL,
                    ) ON [PRIMARY]  END"
        cpCom = New SqlCommand(cQue, DConexiones("CON"))
        cpCom.ExecuteNonQuery()
        cpCom.Dispose()

        cQue = "IF OBJECT_ID('dbo.zConsClasifciaciones') IS NULL " &
                    "Begin CREATE TABLE [dbo].[zConsClasifciaciones](
	                    [id] [int] IDENTITY(1,1) NOT NULL,
	                    [nombre_clasificacion] [nvarchar](250) NULL,
	                    [tipo] [int] NULL
                    ) ON [PRIMARY]  END"
        cpCom = New SqlCommand(cQue, DConexiones("CON"))
        cpCom.ExecuteNonQuery()
        cpCom.Dispose()
    End Sub
End Module

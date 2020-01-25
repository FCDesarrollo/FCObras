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

        cQue = "IF OBJECT_ID('dbo.FCModulo') IS NULL " &
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
    End Sub

    Public Function VerificaTablas() As Boolean
        Dim arrTabs() As String = {"Instancias", "FCModulos", "FCParametros", "FCUser", "FCModUser"}
        VerificaTablas = verificarTablasModulo(arrTabs)
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
End Module

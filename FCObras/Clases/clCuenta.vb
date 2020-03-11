Imports System.Data.SqlClient

Public Class clCuenta
    Private _id As Integer
    Private _fechaini As Date
    Private _fechafin As Date
    Private _idobra As Integer
    Private _codigo As String
    Private _nombrecuenta As String
    Private _codigoadw As String
    Private _clasificacion1 As Integer
    Private _clasificacion2 As Integer
    Private _clasificacion3 As Integer
    Private _tipo As Integer
    Private _idinsumo As String

    Private _idusuario As Integer
    Private _estatus As Integer


    ''variables para asociacion
    Private _idcuentapadre As Integer
    Private _codigocuentapadre As String
    Private _fechaprecio As Date
    Private _idpresupuesto As Integer
    Private _cantidad As Double
    Private _unidad As Integer
    Private _precio As Double
    Private _importe As Double
    Private _cantidadpendiente As Double
    Private _importependiente As Double

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Idobra As Integer
        Get
            Return _idobra
        End Get
        Set(value As Integer)
            _idobra = value
        End Set
    End Property

    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property Nombrecuenta As String
        Get
            Return _nombrecuenta
        End Get
        Set(value As String)
            _nombrecuenta = value
        End Set
    End Property

    Public Property Codigoadw As String
        Get
            Return _codigoadw
        End Get
        Set(value As String)
            _codigoadw = value
        End Set
    End Property

    Public Property Clasificacion1 As Integer
        Get
            Return _clasificacion1
        End Get
        Set(value As Integer)
            _clasificacion1 = value
        End Set
    End Property

    Public Property Clasificacion2 As Integer
        Get
            Return _clasificacion2
        End Get
        Set(value As Integer)
            _clasificacion2 = value
        End Set
    End Property

    Public Property Clasificacion3 As Integer
        Get
            Return _clasificacion3
        End Get
        Set(value As Integer)
            _clasificacion3 = value
        End Set
    End Property

    Public Property Tipo As Integer
        Get
            Return _tipo
        End Get
        Set(value As Integer)
            _tipo = value
        End Set
    End Property

    Public Property Idcuentapadre As Integer
        Get
            Return _idcuentapadre
        End Get
        Set(value As Integer)
            _idcuentapadre = value
        End Set
    End Property

    Public Property Codigocuentapadre As String
        Get
            Return _codigocuentapadre
        End Get
        Set(value As String)
            _codigocuentapadre = value
        End Set
    End Property

    Public Property Fechaprecio As Date
        Get
            Return _fechaprecio
        End Get
        Set(value As Date)
            _fechaprecio = value
        End Set
    End Property

    Public Property Idpresupuesto As Integer
        Get
            Return _idpresupuesto
        End Get
        Set(value As Integer)
            _idpresupuesto = value
        End Set
    End Property

    Public Property Cantidad As Double
        Get
            Return _cantidad
        End Get
        Set(value As Double)
            _cantidad = value
        End Set
    End Property

    Public Property Unidad As Integer
        Get
            Return _unidad
        End Get
        Set(value As Integer)
            _unidad = value
        End Set
    End Property

    Public Property Precio As Double
        Get
            Return _precio
        End Get
        Set(value As Double)
            _precio = value
        End Set
    End Property

    Public Property Importe As Double
        Get
            Return _importe
        End Get
        Set(value As Double)
            _importe = value
        End Set
    End Property

    Public Property Cantidadpendiente As Double
        Get
            Return _cantidadpendiente
        End Get
        Set(value As Double)
            _cantidadpendiente = value
        End Set
    End Property

    Public Property Importependiente As Double
        Get
            Return _importependiente
        End Get
        Set(value As Double)
            _importependiente = value
        End Set
    End Property

    Public Property Idinsumo As String
        Get
            Return _idinsumo
        End Get
        Set(value As String)
            _idinsumo = value
        End Set
    End Property

    Public Property Fechaini As Date
        Get
            Return _fechaini
        End Get
        Set(value As Date)
            _fechaini = value
        End Set
    End Property

    Public Property Fechafin As Date
        Get
            Return _fechafin
        End Get
        Set(value As Date)
            _fechafin = value
        End Set
    End Property

    Public Property Idusuario As Integer
        Get
            Return _idusuario
        End Get
        Set(value As Integer)
            _idusuario = value
        End Set
    End Property

    Public Property Estatus As Integer
        Get
            Return _estatus
        End Get
        Set(value As Integer)
            _estatus = value
        End Set
    End Property

    Public Sub Guarda_cuenta()
        Dim gQue As String

        Try
            gQue = "INSERT INTO zConsCuentas(fechaInicio,fechaFinal,id_obra,codigo,nombre_cuenta,codigo_adw,
                            unidad,clasificacion1,clasificacion2,clasificacion3,tipoinsumo,idinsumo)VALUES(
                            @fechaini,@fechafin,@idobra,@codigo,@nombre,@codigoadw,@unidad,@clasi1,@clasi2,@clasi3,@tipo,@idinsumo)
                            SELECT SCOPE_IDENTITY()"
            Using gCom = New SqlCommand(gQue, DConexiones("CON"))
                gCom.Parameters.AddWithValue("idobra", _idobra)
                gCom.Parameters.AddWithValue("fechaini", _fechaini)
                gCom.Parameters.AddWithValue("fechafin", _fechafin)
                gCom.Parameters.AddWithValue("codigo", _codigo)
                gCom.Parameters.AddWithValue("nombre", _nombrecuenta)
                gCom.Parameters.AddWithValue("codigoadw", _codigoadw)
                gCom.Parameters.AddWithValue("unidad", _unidad)
                gCom.Parameters.AddWithValue("clasi1", _clasificacion1)
                gCom.Parameters.AddWithValue("clasi2", _clasificacion2)
                gCom.Parameters.AddWithValue("clasi3", _clasificacion3)
                gCom.Parameters.AddWithValue("tipo", _tipo)
                gCom.Parameters.AddWithValue("idinsumo", _idinsumo)
                _id = Convert.ToInt32(gCom.ExecuteScalar())
            End Using
        Catch ex As Exception
            MsgBox("Error al guardar cuenta." & vbCrLf & ex.Message, vbExclamation, "Validación")
        End Try
    End Sub

    Public Sub Guarda_Asociacion()
        Dim gQue As String, sQue As String

        Try
            sQue = "SELECT TOP 1 cantidad,precio FROM zConsAsociacionesPrecios 
                            WHERE id_cuenta=" & _id & " AND id_cuentapadre=" & _idcuentapadre & " ORDER BY ID DESC"
            Using sCom = New SqlCommand(sQue, DConexiones("CON"))
                Using sCr = sCom.ExecuteReader
                    sCr.Read()
                    If sCr.HasRows Then
                        _cantidad = _cantidad - sCr("cantidad")
                        _cantidadpendiente = _cantidad
                        _precio = _precio
                        _importe = _cantidad * _precio
                        _importependiente = _importe
                    End If
                End Using
            End Using
            If _precio <> 0 Or _tipo = 0 Then
                gQue = "INSERT INTO zConsAsociacionesPrecios(id_usuario,id_obra,id_cuenta,id_cuentapadre,
                            codigo_cuenta,codigo_cuentapadre,fecha,id_presupuesto,cantidad,
                            unidad,precio,importe,cantidad_pendiente,importe_pendiente,estatus)VALUES(
                            @idusuario,@idobra,@idcuenta,@idcuentapadre,@codigocuenta,@codigocuentapadre,
                            @fecha,@idpre,@cant,@uni,@precio,@importe,@cantpen,@importepen,@status)"
                Using gCom = New SqlCommand(gQue, DConexiones("CON"))
                    gCom.Parameters.AddWithValue("idusuario", _idusuario)
                    gCom.Parameters.AddWithValue("idobra", _idobra)
                    gCom.Parameters.AddWithValue("idcuenta", _id)
                    gCom.Parameters.AddWithValue("idcuentapadre", _idcuentapadre)
                    gCom.Parameters.AddWithValue("codigocuenta", _codigo)
                    gCom.Parameters.AddWithValue("codigocuentapadre", _codigocuentapadre)
                    gCom.Parameters.AddWithValue("fecha", _fechaprecio)
                    gCom.Parameters.AddWithValue("idpre", _idpresupuesto)
                    gCom.Parameters.AddWithValue("cant", _cantidad)
                    gCom.Parameters.AddWithValue("uni", _unidad)
                    gCom.Parameters.AddWithValue("precio", _precio)
                    gCom.Parameters.AddWithValue("importe", _importe)
                    gCom.Parameters.AddWithValue("cantpen", _cantidadpendiente)
                    gCom.Parameters.AddWithValue("importepen", _importependiente)
                    gCom.Parameters.AddWithValue("status", _estatus)
                    gCom.ExecuteNonQuery()
                End Using
            End If
        Catch ex As Exception
            MsgBox("Error al guardar Asociación de cuenta." & vbCrLf & ex.Message, vbExclamation, "Validación")
        End Try
    End Sub

    Public Function Carga_AsociadasCuentas() As DataTable
        Dim dt As New DataTable, cQue As String

        cQue = "SELECT DISTINCT id_cuenta,id_cuentapadre,codigo_cuenta,codigo_cuentapadre FROM 
                    zConsAsociacionesPrecios WHERE id_obra=" & _idobra & ""
        Using cCom = New SqlDataAdapter(cQue, DConexiones("CON"))
            cCom.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function Carga_Cuentas(ByVal filtro As String) As DataTable
        Dim dt As New DataTable, cQue As String

        cQue = "SELECT id,id_obra,fechaInicio,fechaFinal,codigo,nombre_cuenta,
                        codigo_adw,clasificacion1,clasificacion2,clasificacion3,
                        tipoinsumo, idinsumo FROM zConsCuentas WHERE id_obra=" & _idobra & " " & filtro & ""
        Using cCom = New SqlDataAdapter(cQue, DConexiones("CON"))
            cCom.Fill(dt)
        End Using
        Return dt
    End Function
    Public Function Nombres_cuentas() As Dictionary(Of String, String)
        Dim dDicCuentas As New Dictionary(Of String, String)
        Dim dQue As String, dKey As String, dItem As String

        dQue = "SELECT codigo,nombre_cuenta FROM zConsCuentas WHERE id_obra=" & _idobra & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    dKey = Trim(dCr("codigo"))
                    dItem = Trim(dCr("nombre_cuenta"))
                    If Not dDicCuentas.ContainsKey(dKey) Then
                        dDicCuentas.Add(dKey, dItem)
                    End If
                Loop
            End Using
        End Using

        Return dDicCuentas
    End Function

    Public Function Get_Cuenta() As Boolean
        Dim dQue As String, resp As Boolean

        resp = False
        dQue = "SELECT DISTINCT fechaInicio,fechaFinal,codigo,nombre_cuenta,
                    clasificacion1,clasificacion2,clasificacion3,tipoinsumo,
                    idinsumo,id_cuentapadre,codigo_cuentapadre,a.unidad FROM zConsCuentas c
                    INNER JOIN zConsAsociacionesPrecios a ON c.id=a.id_cuenta 
                    WHERE a.id_cuenta=" & _id & " and id_cuentapadre=" & _idcuentapadre & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCr = dCom.ExecuteReader
                dCr.Read()
                If dCr.HasRows Then
                    resp = True
                    _fechaini = dCr("fechaInicio")
                    _fechafin = dCr("fechaFinal")
                    _codigo = dCr("codigo")
                    _nombrecuenta = dCr("nombre_cuenta")
                    _clasificacion1 = dCr("clasificacion1")
                    _clasificacion2 = dCr("clasificacion2")
                    _clasificacion3 = dCr("clasificacion3")
                    _tipo = dCr("tipoinsumo")
                    _idinsumo = dCr("idinsumo")
                    _idcuentapadre = dCr("id_cuentapadre")
                    _codigocuentapadre = dCr("codigo_cuentapadre")
                    _unidad = dCr("unidad")
                End If
            End Using
        End Using
        Return resp
    End Function

    Public Function Get_Precios() As DataTable
        Dim dt As New DataTable, dQue As String

        dQue = "SELECT id,fecha,id_presupuesto,cantidad,precio,importe 
                    FROM zConsAsociacionesPrecios WHERE id_cuenta=" & _id & "
                    AND id_cuentapadre=" & _idcuentapadre & " order by id ASC"
        Using cCom = New SqlDataAdapter(dQue, DConexiones("CON"))
            cCom.Fill(dt)
        End Using
        Return dt
    End Function

    Public Sub Get_SumDetalles()
        Dim dQue As String

        dQue = "SELECT  SUM(cantidad) AS cantidad,SUM(importe) AS importe,
                            SUM(cantidad_pendiente) as cantidadpendiente,
                            SUM(importe_pendiente) as importependiente,unidad
                            FROM zConsAsociacionesPrecios 
                            WHERE id_cuenta = " & _id & " AND id_cuentapadre=" & _idcuentapadre & " group by unidad"
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCr = dCom.ExecuteReader()
                dCr.Read()
                If dCr.HasRows Then
                    _cantidad = dCr("cantidad")
                    _importe = dCr("importe")
                    _cantidadpendiente = dCr("cantidadpendiente")
                    _importependiente = dCr("importependiente")
                    _unidad = dCr("unidad")
                End If
            End Using
        End Using
    End Sub

    Public Function Get_idCuenta(ByVal cCodigo As String) As Integer
        Dim dQue As String, resp As Integer

        dQue = "SELECT id FROM zConsCuentas WHERE codigo='" & cCodigo & "'"
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            Using dCr = dCom.ExecuteReader()
                dCr.Read()
                If dCr.HasRows Then
                    resp = dCr("id")
                End If
            End Using
        End Using
        Return resp
    End Function

    Public Sub EliminaSin_Precio()
        Dim dQue As String
        dQue = "DELETE FROM zConsCuentas WHERE id=" & _id & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            dCom.ExecuteNonQuery()
        End Using

        dQue = "DELETE FROM zConsAsociacionesPrecios WHERE  id_cuenta=" & _id & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            dCom.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub Actualiza_Cuenta()
        Dim dQue As String

        dQue = "UPDATE zConsCuentas SET fechaInicio=@fechai, fechafinal=@fechaf, 
                        nombre_cuenta=@nombre,unidad=@unidad, clasificacion1=@clas1, clasificacion2=@clas2,
                        clasificacion3=@clas3, tipoinsumo=@tipo, idinsumo=@idinsumo
                        WHERE id=@id"
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            dCom.Parameters.AddWithValue("id", _id)
            dCom.Parameters.AddWithValue("fechai", _fechaini)
            dCom.Parameters.AddWithValue("fechaf", _fechafin)
            dCom.Parameters.AddWithValue("nombre", _nombrecuenta)
            dCom.Parameters.AddWithValue("unidad", _unidad)
            dCom.Parameters.AddWithValue("clas1", _clasificacion1)
            dCom.Parameters.AddWithValue("clas2", _clasificacion2)
            dCom.Parameters.AddWithValue("clas3", _clasificacion3)
            dCom.Parameters.AddWithValue("tipo", _tipo)
            dCom.Parameters.AddWithValue("idinsumo", _idinsumo)
            dCom.ExecuteNonQuery()
        End Using

        dQue = "UPDATE zConsAsociacionesPrecios SET unidad=" & _unidad & " WHERE id_cuenta=" & _id & ""
        Using dCom = New SqlCommand(dQue, DConexiones("CON"))
            dCom.ExecuteNonQuery()
        End Using
    End Sub


End Class

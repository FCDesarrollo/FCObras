Imports System.Data.SqlClient

Public Class clObra
    Private _id As Integer
    Private _idsucursal As Integer
    Private _nombreobra As String
    Private _estatus As Integer
    Private _fechaini As Date
    Private _fechafin As Date
    Private _descripcion As String

    Private _colPresupuestos As New Collection
    Private _colPlanCrono As New Collection

    Sub New()
        Me._id = 0
    End Sub
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Nombreobra As String
        Get
            Return _nombreobra
        End Get
        Set(value As String)
            _nombreobra = value
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

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Idsucursal As Integer
        Get
            Return _idsucursal
        End Get
        Set(value As Integer)
            _idsucursal = value
        End Set
    End Property

    Public Property ColPresupuestos As Collection
        Get
            Return _colPresupuestos
        End Get
        Set(value As Collection)
            _colPresupuestos = value
        End Set
    End Property

    Public Property ColPlanCrono As Collection
        Get
            Return _colPlanCrono
        End Get
        Set(value As Collection)
            _colPlanCrono = value
        End Set
    End Property

    Public Sub Guarda_Obra()
        Dim cQue As String

        Try
            cQue = "INSERT INTO zConsObras(idsucursal,nombre_obra,fecha_inicial,
                        fecha_final,descripcion,estatus)VALUES(@idsuc,@nombre,
                            @fechai,@fechaf,@des,@sta) SELECT SCOPE_IDENTITY()"
            Using cCom = New SqlCommand(cQue, DConexiones("CON"))
                cCom.Parameters.AddWithValue("idsuc", _idsucursal)
                cCom.Parameters.AddWithValue("nombre", _nombreobra)
                cCom.Parameters.AddWithValue("fechai", _fechaini)
                cCom.Parameters.AddWithValue("fechaf", _fechafin)
                cCom.Parameters.AddWithValue("des", _descripcion)
                cCom.Parameters.AddWithValue("sta", _estatus)
                _id = Convert.ToInt32(cCom.ExecuteScalar())
            End Using
        Catch ex As Exception
            MsgBox("Error al guardar la Obra." & vbCrLf & ex.Message, vbExclamation, "Validación")
        End Try
    End Sub

    Public Function Carga_Obras() As Collection
        Dim obra As clObra, colObr As New Collection
        Dim cQue As String

        Try
            cQue = "SELECT id,nombre_obra,fecha_inicial,fecha_final,descripcion,
                        estatus FROM zConsObras WHERE idsucursal=" & _idsucursal & ""
            Using cCOm = New SqlCommand(cQue, DConexiones("CON"))
                Using cCr = cCOm.ExecuteReader
                    Do While cCr.Read
                        obra = New clObra
                        obra.Id = cCr("id")
                        obra.Idsucursal = _idsucursal
                        obra.Nombreobra = cCr("nombre_obra")
                        obra.Fechaini = Format(cCr("fecha_inicial"), Formato_FechaYear)
                        obra.Fechafin = Format(cCr("fecha_final"), Formato_FechaYear)
                        obra.Descripcion = cCr("descripcion")
                        obra.Estatus = cCr("estatus")

                        colObr.Add(obra)
                    Loop
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al cargar las Obras." & vbCrLf & ex.Message, vbExclamation, "Validación")
        End Try
        Return colObr
        colObr = Nothing
    End Function

    Public Sub Eliminar_obra()
        Dim dQue As String, dCom As SqlCommand

        Try
            dQue = "DELETE FROM zConsObras WHERE id=" & _id & ""
            dCom = New SqlCommand(dQue, DConexiones("CON"))
            dCom.ExecuteNonQuery()
            dCom.Dispose()

            dQue = "DELETE FROM zConsPlanesCrono WHERE id_obra=" & _id & ""
            dCom = New SqlCommand(dQue, DConexiones("CON"))
            dCom.ExecuteNonQuery()
            dCom.Dispose()

            dQue = "DELETE FROM zConsCuentas WHERE id_obra=" & _id & ""
            dCom = New SqlCommand(dQue, DConexiones("CON"))
            dCom.ExecuteNonQuery()
            dCom.Dispose()

            dQue = "DELETE FROM zConsAsociacionesPrecios WHERE id_obra=" & _id & ""
            dCom = New SqlCommand(dQue, DConexiones("CON"))
            dCom.ExecuteNonQuery()
            dCom.Dispose()

            dQue = "SELECT id FROM zConsPresupuestos WHERE id_obra=" & _id & ""
            Using dCor = New SqlCommand(dQue, DConexiones("CON"))
                Using dCr = dCor.ExecuteReader
                    Do While dCr.Read
                        dQue = "DELETE FROM zConsPresupuestos_Doc WHERE id_presupuesto=" & dCr("id") & ""
                        dCom = New SqlCommand(dQue, DConexiones("CON"))
                        dCom.ExecuteNonQuery()
                        dCom.Dispose()
                    Loop
                End Using
            End Using

            dQue = "DELETE FROM zConsPresupuestos WHERE id_obra=" & _id & ""
            dCom = New SqlCommand(dQue, DConexiones("CON"))
            dCom.ExecuteNonQuery()
            dCom.Dispose()
        Catch ex As Exception
            MsgBox("Error al eliminar la obra.", vbInformation, "Validación")
        End Try

        _id = 0
    End Sub
End Class

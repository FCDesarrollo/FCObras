Imports System.Data.SqlClient

Public Class clPlanCrono
    Private _id As Integer
    Private _idobra As Integer
    Private _nombreplan As String
    Private _descripcion As String

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

    Public Property Nombreplan As String
        Get
            Return _nombreplan
        End Get
        Set(value As String)
            _nombreplan = value
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

    Public Sub Guarda_PlanCrono()
        Dim gQue As String

        Try
            gQue = "INSERT INTO zConsPlanesCrono(id_obra,nombre_plan,descripcion)
                                            VALUES(@idobra,@nombre,@des) SELECT SCOPE_IDENTITY()"
            Using gCom = New SqlCommand(gQue, DConexiones("CON"))
                gCom.Parameters.AddWithValue("idobra", _idobra)
                gCom.Parameters.AddWithValue("nombre", _nombreplan)
                gCom.Parameters.AddWithValue("des", _descripcion)
                _id = Convert.ToInt32(gCom.ExecuteScalar())
            End Using
        Catch ex As Exception
            MsgBox("Error al guardar plan cronologico." & vbCrLf & ex.Message, vbExclamation, "Validación")
        End Try
    End Sub

    Public Function Carga_PlanesCrono() As Collection
        Dim plancrono As clPlanCrono, colPlancron As New Collection
        Dim gQue As String

        gQue = "SELECT  id,nombre_plan,descripcion FROM zConsPlanesCrono WHERE id_obra=" & _idobra & ""
        Using gCom = New SqlCommand(gQue, DConexiones("CON"))
            Using gCr = gCom.ExecuteReader
                Do While gCr.Read
                    plancrono = New clPlanCrono
                    plancrono.Id = gCr("id")
                    plancrono.Nombreplan = Trim(gCr("nombre_plan"))
                    plancrono.Descripcion = Trim(gCr("descripcion"))

                    colPlancron.Add(plancrono)
                Loop
            End Using
        End Using

        Return colPlancron
        colPlancron = Nothing
    End Function
End Class

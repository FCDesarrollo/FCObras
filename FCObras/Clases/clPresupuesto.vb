Imports System.Data.SqlClient

Public Class clPresupuesto
    Private _id As Integer
    Private _idobra As Integer
    Private _nombrepresupuesto As String
    Private _descripcion As String

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Nombrepresupuesto As String
        Get
            Return _nombrepresupuesto
        End Get
        Set(value As String)
            _nombrepresupuesto = value
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

    Public Property Idobra As Integer
        Get
            Return _idobra
        End Get
        Set(value As Integer)
            _idobra = value
        End Set
    End Property

    Public Sub Guarda_Presupuesto()
        Dim gQue As String

        Try
            gQue = "INSERT INTO zConsPresupuestos(id_obra,nombre_presupuesto,
                            descripcion)VALUES(@idobra,@nombre,@des) SELECT SCOPE_IDENTITY()"
            Using gCom = New SqlCommand(gQue, DConexiones("CON"))
                gCom.Parameters.AddWithValue("idobra", _idobra)
                gCom.Parameters.AddWithValue("nombre", _nombrepresupuesto)
                gCom.Parameters.AddWithValue("des", _descripcion)
                _id = Convert.ToInt32(gCom.ExecuteScalar())
            End Using
        Catch ex As Exception
            MsgBox("Error al guardar presupuesto." & vbCrLf & ex.Message, vbExclamation, "Validación")
        End Try
    End Sub

    Public Function Carga_Presupuestos() As Collection
        Dim presupuesto As clPresupuesto, colPre As New Collection
        Dim gQue As String

        gQue = "SELECT  id,nombre_presupuesto,descripcion FROM zConsPresupuestos WHERE id_obra=" & _idobra & ""
        Using gCom = New SqlCommand(gQue, DConexiones("CON"))
            Using gCr = gCom.ExecuteReader
                Do While gCr.Read
                    presupuesto = New clPresupuesto
                    presupuesto.Id = gCr("id")
                    presupuesto.Nombrepresupuesto = Trim(gCr("nombre_presupuesto"))
                    presupuesto.Descripcion = Trim(gCr("descripcion"))

                    colPre.Add(presupuesto)
                Loop
            End Using
        End Using

        Return colPre
        colPre = Nothing
    End Function
End Class

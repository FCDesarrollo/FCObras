Imports System.Data.SqlClient

Module modConstrucion
    Public C_Tipo_Agrega As Integer

    Public Function Get_numeroUnidades() As Integer
        Dim dQue As String, resp As Integer

        dQue = "SELECT COUNT(*) as num FROM ConsUnidades"
        Using dCom = New SqlCommand(dQue, FC_Con)
            Using dCr = dCom.ExecuteReader
                dCr.Read()
                If dCr.HasRows Then
                    resp = dCr("num")
                End If
            End Using
        End Using

        Return resp
    End Function

    Public Function Get_numeroInsumos() As Integer
        Dim dQue As String, resp As Integer

        dQue = "SELECT COUNT(*) as num FROM ConsInsumos"
        Using dCom = New SqlCommand(dQue, FC_Con)
            Using dCr = dCom.ExecuteReader
                dCr.Read()
                If dCr.HasRows Then
                    resp = dCr("num")
                End If
            End Using
        End Using

        Return resp
    End Function
End Module

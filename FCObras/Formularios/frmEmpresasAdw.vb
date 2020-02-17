Imports System.Data.SqlClient

Public Class frmEmpresasAdw
    Private Sub FrmEmpresasAdw_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Carga_EmpresasAdminpaq()
        Dim cQue As String, cRutaEmp As String

        cRutaEmp = FC_RutaEmpresasAdmin
        fError = FC_ConexionFOX(cRutaEmp)
        If fError <> 0 Then Exit Sub
        dgEmpresas.Rows.Clear()
        cQue = "SELECT CIDEMPRESA,CNOMBREE01,CRUTADATOS FROM MGW00001 WHERE CIDEMPRESA <> 1"
        Using fCom = New Odbc.OdbcCommand(cQue, FC_CONFOX)
            Using fCr = fCom.ExecuteReader()
                Do Until fCr.Read
                    dgEmpresas.Rows.Add(fCr("CIDEMPRESA"), Trim(fCr("CRUTADATOS")),
                                        False, Trim(fCr("CNOMBREE01")), "")
                Loop
            End Using
        End Using
    End Sub

    Private Sub Carga_EmpresasComercial()
        Dim cQue As String, cRutaEmp As String

        cRutaEmp = "CompacWAdmin"
        If DConexiones Is Nothing Then FCConstruccion.FC_GetCons()
        DConexiones("COM").ChangeDatabase(cRutaEmp)

        dgEmpresas.Rows.Clear()
        cQue = "SELECT CIDEMPRESA,CNOMBREEMPRESA,CRUTADATOS FROM Empresas WHERE CIDEMPRESA <> 1"
        Using fCom = New SqlCommand(cQue, DConexiones("COM"))
            Using fCr = fCom.ExecuteReader()
                Do Until fCr.Read
                    dgEmpresas.Rows.Add(fCr("CIDEMPRESA"), Trim(fCr("CRUTADATOS")),
                                        False, Trim(fCr("CNOMBREEMPRESA")), "")
                Loop
            End Using
        End Using
    End Sub

    Private Sub RbAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles rbAdmin.CheckedChanged
        If rbAdmin.Checked = True Then
            Carga_EmpresasAdminpaq()
        End If

    End Sub

    Private Sub Rbcomercial_CheckedChanged(sender As Object, e As EventArgs) Handles rbcomercial.CheckedChanged
        If rbcomercial.Checked = True Then
            Carga_EmpresasComercial()
        End If
    End Sub
End Class
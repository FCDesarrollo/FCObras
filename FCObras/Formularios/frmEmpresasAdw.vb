Imports System.Data.SqlClient

Public Class frmEmpresasAdw
    Private _e_IDEmpresa As Integer
    Private _e_NombreEmpresa As String

    Public Property E_IDEmpresa As Integer
        Get
            Return _e_IDEmpresa
        End Get
        Set(value As Integer)
            _e_IDEmpresa = value
        End Set
    End Property

    Public Property E_NombreEmpresa As String
        Get
            Return _e_NombreEmpresa
        End Get
        Set(value As String)
            _e_NombreEmpresa = value
        End Set
    End Property

    Private Sub FrmEmpresasAdw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_EmpresasAdminpaq()
        Verifica_seleccionadas()
    End Sub

    Private Sub Carga_EmpresasAdminpaq()
        Dim cQue As String, cRutaEmp As String

        cRutaEmp = FC_RutaEmpresasAdmin
        fCError = FC_ConexionFOX(cRutaEmp)
        If fCError <> 0 Then Exit Sub
        dgEmpresas.Rows.Clear()
        cQue = "SELECT CIDEMPRESA,CNOMBREE01,CRUTADATOS FROM MGW00001 WHERE CIDEMPRESA <> 1"
        Using fCom = New Odbc.OdbcCommand(cQue, FC_CONFOX)
            Using fCr = fCom.ExecuteReader()
                Do While fCr.Read
                    dgEmpresas.Rows.Add(fCr("CIDEMPRESA"), Trim(fCr("CRUTADATOS")),
                                        False, Trim(fCr("CNOMBREE01")), "")
                Loop
            End Using
        End Using
    End Sub

    Private Sub Verifica_seleccionadas()
        Dim dQue As String

        dQue = "SELECT IdAdw,Sucursal FROM ConsRutasADW WHERE IDEmpresa=" & _e_IDEmpresa & ""
        Using dCom = New SqlCommand(dQue, FC_Con)
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    For Each fila As DataGridViewRow In dgEmpresas.Rows
                        If fila.Cells(0).Value = dCr("idAdw") Then
                            fila.Cells(2).Value = True
                            fila.Cells(4).Value = dCr("Sucursal")
                        End If
                    Next
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

    Private Sub dgEmpresas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEmpresas.CellContentClick
        If dgEmpresas.CurrentRow Is Nothing Then Exit Sub
        If Me.dgEmpresas.Rows(e.RowIndex).Cells("empsele").Value = False And e.ColumnIndex = 2 Then
            MsgBox("Debe escribir el nombre de sucursal", vbInformation, "Validación")
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Guarda_Sucursal()
    End Sub

    Private Sub Guarda_Sucursal()
        Dim dQue As String, usacomercial As Integer

        usacomercial = IIf(rbAdmin.Checked = True, 0, 1)
        Try
            dQue = "DELETE FROM ConsRutasADW WHERE IDEmpresa=" & _e_IDEmpresa & ""
            Using dCom = New SqlCommand(dQue, FC_Con)
                dCom.ExecuteNonQuery()
            End Using
            For Each fila As DataGridViewRow In dgEmpresas.Rows
                If fila.Cells(2).Value = True And fila.Cells(4).Value <> "" Then
                    dQue = "IF NOT EXISTS (SELECT * FROM ConsRutasADW WHERE IDEmpresa=@idemp and IdAdw=@idadw)
                               BEGIN INSERT INTO ConsRutasADW(IDEmpresa, Nombre, IdAdw, Ruta, Sucursal, usaComercial)
                                    VALUES(@idemp,@nombre,@idadw,@ruta,@suc,@usaComercial) END"
                    Using dCom = New SqlCommand(dQue, FC_Con)
                        dCom.Parameters.AddWithValue("idemp", _e_IDEmpresa)
                        dCom.Parameters.AddWithValue("nombre", _e_NombreEmpresa)
                        dCom.Parameters.AddWithValue("idadw", fila.Cells(0).Value)
                        dCom.Parameters.AddWithValue("ruta", fila.Cells(1).Value)
                        dCom.Parameters.AddWithValue("suc", fila.Cells(4).Value)
                        dCom.Parameters.AddWithValue("usaComercial", usacomercial)
                        dCom.ExecuteNonQuery()
                    End Using
                End If
            Next
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al agregar la empresa AdminPAQ." & vbCrLf & ex.Message, vbExclamation, "Validación")
        End Try

    End Sub
End Class
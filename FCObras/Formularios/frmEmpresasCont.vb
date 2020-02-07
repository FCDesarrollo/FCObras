Imports System.Data.SqlClient

Public Class frmEmpresasCont
    Private Sub FrmEmpresasCont_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_EmpresasContpaq()
    End Sub

    Private Sub Carga_EmpresasContpaq()
        Dim cQue As String
        fError = FC_Conexion()
        If fError <> 0 Then Exit Sub
        If IsNothing(DConexiones) Then FC_GetCons()
        DConexiones("CON").ChangeDatabase("GeneralesSQL")
        dgEmpresas.Rows.Clear()
        Try
            cQue = "SELECT Nombre,AliasBDD,Id FROM ListaEmpresas"
            Using cCom = New SqlCommand(cQue, DConexiones("CON"))
                Using cCr = cCom.ExecuteReader
                    Do While cCr.Read
                        If Not Empresa_Agregada(cCr("Id")) Then
                            dgEmpresas.Rows.Add(cCr("Id"), Trim(cCr("AliasBDD")), False, Trim(cCr("Nombre")))
                        End If
                    Loop
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al cargar empresas ContPAQ." & vbCrLf & ex.Message, vbExclamation, "Validación")
        End Try


    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Guarda_Empresas()
        Dim dQue As String

        Try
            For Each fila As DataGridViewRow In dgEmpresas.Rows
                If fila.Cells(2).Value = True Then
                    dQue = "INSERT INTO ConsEmpresas(IdEmpresa,Empresa,ctBDD)
                                VALUES(" & fila.Cells(0).Value & ",
                                '" & fila.Cells(3).Value & "','" & fila.Cells(1).Value & "')"
                    Using dCom = New SqlCommand(dQue, FC_Con)
                        dCom.ExecuteNonQuery()
                        CreaTablas_ModConstruccion(fila.Cells(1).Value)
                    End Using
                End If
            Next
        Catch ex As Exception
            MsgBox("Error al agregar la empresa ContPAQ." & vbCrLf & ex.Message, vbExclamation, "Validación")
        End Try

    End Sub

    Private Function Empresa_Agregada(ByVal eIDEmpresa As Integer) As Boolean
        Dim dExiste As Boolean, dQue As String

        dExiste = False
        dQue = "SELECT IdEmpresa FROM ConsEmpresas WHERE IdEmpresa=" & eIDEmpresa & ""
        Using dCom = New SqlCommand(dQue, FC_Con)
            Using dCr = dCom.ExecuteReader()
                dCr.Read()
                If dCr.HasRows Then
                    dExiste = True
                End If
            End Using
        End Using
        Empresa_Agregada = dExiste
    End Function

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Guarda_Empresas()
    End Sub
End Class
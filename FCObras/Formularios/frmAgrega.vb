Imports System.Data.SqlClient

Public Class frmAgrega
    Private _a_tipo As Integer
    Private _a_edita As Integer

    Public Property A_tipo As Integer
        Get
            Return _a_tipo
        End Get
        Set(value As Integer)
            _a_tipo = value
        End Set
    End Property

    Public Property A_edita As Integer
        Get
            Return _a_edita
        End Get
        Set(value As Integer)
            _a_edita = value
        End Set
    End Property

    Private Sub frmAgrega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _a_tipo = 1 Then
            Me.Text = IIf(_a_edita = 0, "Agrega ", "Edita ") & "Unidad"
        ElseIf _a_tipo = 2 Then
            Me.Text = IIf(_a_edita = 0, "Agrega ", "Edita ") & "Insumo"
        End If
    End Sub

    Private Sub Guarda()
        Dim dQue As String = ""
        If _a_tipo = 1 Then
            dQue = "IF NOT EXISTS (SELECT clave_unidad FROM ConsUnidades WHERE clave_unidad=@codigo)
                        BEGIN INSERT INTO ConsUnidades(clave_unidad, nombre_unidad)VALUES(@codigo, @nombre) END"
        ElseIf _a_tipo = 2 Then
            dQue = "IF NOT EXISTS (SELECT codigo_insumo FROM ConsInsumos WHERE codigo_insumo=@codigo)
                        BEGIN INSERT INTO ConsInsumos(codigo_insumo, nombre_insumo)VALUES(@codigo, @nombre) END"
        End If
        Using dCom = New SqlCommand(dQue, FC_Con)
            dCom.Parameters.AddWithValue("codigo", txtclave.Text)
            dCom.Parameters.AddWithValue("nombre", txtnombre.Text)
            dCom.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtclave.Text <> "" And txtnombre.Text <> "" Then
            Guarda()
            If ckAll.Checked = True Then
                Guarda_todasempresas()
            End If
            Me.Close()
        End If
    End Sub

    Private Sub Guarda_todasempresas()
        Dim dQue As String, dQueSql As String = ""
        If IsNothing(DConexiones) Then FC_GetCons()

        If _a_tipo = 1 Then
            dQueSql = "IF NOT EXISTS (SELECT clave_unidad FROM zConsUnidades WHERE clave_unidad=@codigo)
                        BEGIN INSERT INTO zConsUnidades(clave_unidad, nombre_unidad)VALUES(@codigo, @nombre) END"
        ElseIf _a_tipo = 2 Then
            dQueSql = "IF NOT EXISTS (SELECT codigo_insumo FROM zConsInsumos WHERE codigo_insumo=@codigo)
                        BEGIN INSERT INTO zConsInsumos(codigo_insumo, nombre_insumo)VALUES(@codigo, @nombre) END"
        End If

        dQue = "SELECT ctBDD FROM ConsEmpresas"
        Using dCom = New SqlCommand(dQue, FC_Con)
            Using dCr = dCom.ExecuteReader
                Do While dCr.Read
                    DConexiones("CON").ChangeDatabase(dCr("ctBDD"))
                    Using dSql = New SqlCommand(dQueSql, DConexiones("CON"))
                        dSql.Parameters.AddWithValue("codigo", txtclave.Text)
                        dSql.Parameters.AddWithValue("nombre", txtnombre.Text)
                        dSql.ExecuteNonQuery()
                    End Using
                Loop
            End Using
        End Using
    End Sub
End Class
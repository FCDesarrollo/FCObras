Module modNumeros
    Public CODIGOSEPARADOR As String = System.Globalization.CultureInfo.CurrentUICulture.NumberFormat.CurrencyDecimalSeparator

    Public Sub PALNUMEROS(EV As KeyPressEventArgs, DECIMALES As Integer, TXB As TextBox)
        REM se llama así
        ' Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'PALNUMEROS(e, 2, texbox1)
        ' el 2 es la cantidad de decimales y se puede cambiar
        'End Sub
        REM Fin de comentario
        If DECIMALES < 0 Then DECIMALES = 0
        If EV.KeyChar = Convert.ToChar(Keys.Return) Then
            EV.Handled = True
            TXB.Focus()
        ElseIf EV.KeyChar = "."c Or EV.KeyChar = ","c Or EV.KeyChar = "."c Then
            If (TXB.Text.IndexOf(","c) >= 0) Or (DECIMALES = 0) Then
                EV.Handled = True
            Else
                If TXB.Text.Length = 0 Then
                    TXB.Text = "0" & CChar(CODIGOSEPARADOR)
                    TXB.SelectionStart = 3
                    EV.Handled = True
                Else

                    EV.KeyChar = CChar(CODIGOSEPARADOR)  REM","c`.
                End If
            End If
        ElseIf EV.KeyChar = "-"c And TXB.TextLength = 0 Then
            EV.KeyChar = "-"c
        ElseIf Not (Char.IsControl(EV.KeyChar) Or Char.IsDigit(EV.KeyChar)) Then
            EV.Handled = True

        ElseIf TXB.Text.IndexOf(","c) > 0 Then
            If (TXB.Text.Length - TXB.Text.IndexOf(","c) > DECIMALES) And (TXB.SelectionStart > TXB.Text.IndexOf(","c)) And (Not (Char.IsControl(EV.KeyChar))) Then
                EV.Handled = True
            End If

        End If
    End Sub

    Public Sub PALRRELLENO(Decimales As Integer, TXB As TextBox)
        ' se llama así
        ' Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        'PALRRELLENO(2, txtbox1)
        ' End Sub
        Dim Nu As Decimal
        Dim texto As String
        If Decimal.TryParse(TXB.Text, Nu) Then
            texto = "N" & Trim(Str(Decimales))
            TXB.Text = Nu.ToString(texto)
        Else
            TXB.Text = ""
        End If
    End Sub
End Module

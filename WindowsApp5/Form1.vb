Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Select Case ComboBox1.SelectedItem
            Case "VERDE"
                Panel1.BackColor = Color.Green
            Case "AZUL"
                Panel1.BackColor = Color.Blue
            Case "ROJO"
                Panel1.BackColor = Color.Red
            Case "AMARILLO"
            Case Else
                Panel1.BackColor = Color.Transparent
        End Select

    End Sub
End Class

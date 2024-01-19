Public Class Form1
    'BUCLE FOR 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'VARIABLES
        Dim contador, ciclo As Integer

        'FOR
        ciclo = 1
        RichTextBox1.Text = ""
        For contador = 0 To Val(TextBox1.Text)
            RichTextBox1.Text = RichTextBox1.Text & "contador = " & contador & " ciclo = " & ciclo & vbCrLf
            ciclo += 1
        Next

    End Sub
    'LIMPIAMOS LOS TEXTBOX
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        RichTextBox1.Text = ""
        TextBox1.Focus()

    End Sub
    'BUCLE FOR 2
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'VARIABLES
        Dim contador, ciclo As Integer

        'FOR
        ciclo = 1
        RichTextBox2.Text = ""
        For contador = 0 To Val(TextBox2.Text) Step Val(TextBox3.Text)
            RichTextBox2.Text = RichTextBox2.Text & "contador = " & contador & " ciclo = " & ciclo & vbCrLf
            'ciclo += TextBox3.Text
            ciclo += 1
        Next
    End Sub
    'LIMPIAR FOR 2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = ""
        RichTextBox2.Text = ""
        TextBox2.Focus()
        TextBox3.Text = 1

    End Sub
End Class

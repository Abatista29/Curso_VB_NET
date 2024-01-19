Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'VARIABLES
        Dim contador As Integer = 0

        ' VALIDO QUE INGRESE UN VALOR
        If TextBox1.Text = "" Then
            msgError.Text = "Asegurate de ingresar un valor"
            msgError.ForeColor = Color.Red

            ' VALIDO QUE SEA UN NUMERO POSITIVO MAYOR A CERO
        ElseIf TextBox1.Text <= contador Then
            msgError.Text = "Asegurate que sea un valor positivo mayor a cero"
            msgError.ForeColor = Color.Red
        Else
            msgError.Text = ""
            'LIMPIAMOS EL RICH ANTES DE QUE ENTRE AL BUCLE
            RichTextBox1.Text = ""
            While (contador < TextBox1.Text)
                contador = (contador + 1)
                RichTextBox1.Text = RichTextBox1.Text & "contador: " & contador & vbCrLf
            End While
        End If

    End Sub
    ' LIMPIAMOS LOS INPUTS
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        RichTextBox1.Text = ""
    End Sub
End Class

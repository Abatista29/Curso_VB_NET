Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' VARIABLES
        Dim numero As Integer
        Dim contador As Integer = 0

        numero = Val(TextBox1.Text)

        If TextBox1.Text <> "" Then
            Do
                contador += 1
                If (numero Mod contador) = 0 Then
                    RichTextBox1.Text = RichTextBox1.Text & contador & ", "
                End If
            Loop Until (contador = numero)
        Else
            MsgBox("Escribe un numero")
            TextBox1.Focus()
        End If

    End Sub
    'LIMPIANOS LOS INPUTS Y VARIABLES
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox1.Focus()
        RichTextBox1.Text = ""
    End Sub
End Class

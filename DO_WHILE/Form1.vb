Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '
        Dim valor As Decimal


        'VALIDACIONES
        If TextBox1.Text <> "" Then
            If TextBox2.Text <> "" Then
                If Val(TextBox1.Text) < Val(TextBox2.Text) Then
                    Do
                        valor = InputBox("Inserta un numero entre el numero " & Val(TextBox1.Text) & " y el numero " & Val(TextBox2.Text) & ":")
                    Loop While ((valor < Val(TextBox1.Text)) Or (valor > Val(TextBox2.Text)))
                    MsgBox("Adivinastes el numero")

                Else
                    MsgBox("El numero 1 no es menor que el numero 2")
                    TextBox1.Focus()
                End If

            Else
                MsgBox("Debes insertar el numero 2")
                TextBox2.Focus()
            End If
        Else
            MsgBox("Debe insertar el numero 1")
            TextBox1.Focus()
        End If
    End Sub
End Class

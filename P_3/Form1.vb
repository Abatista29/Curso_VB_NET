Public Class Form1
    ' VARIABLES
    Dim num1 As Decimal
    Dim num2 As Decimal
    Dim result As Decimal

    ' OPERACIONES
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'ASIGNAMOS
        num1 = TextBox1.Text
        num2 = TextBox2.Text

        If Osuma.Checked Then
            result = num1 + num2
        End If
        If Oresta.Checked Then
            result = num1 - num2
        End If
        If Oproducto.Checked Then
            result = num1 * num2
        End If
        If Odivision.Checked Then
            result = num1 / num2
        End If
        If Oresiduo.Checked Then
            result = num1 Mod num2
        End If

        ' ASIGNO VARIABLE OPERACION AL LABEL
        Label3.Text = result

    End Sub

    ' LIMPIAMOS LOS INPUTS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label3.Text = ""
        TextBox1.Focus()
    End Sub

End Class

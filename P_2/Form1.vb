Public Class Form1
    'DOS TIPOS DE VARIABLES (GLOBALES Y LOCALES)
    'DELCARACION DE VARIABLES GLOBALES
    Dim resultado As Decimal

    'OPERACION SUMA
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero1, numero2 As Decimal
        'ASIGNAR LAS VARIABLES
        numero1 = TextBox1.Text
        numero2 = TextBox2.Text
        'OPERACION DE SUMA
        resultado = numero1 + numero2
        'MUESTRO EL RESULTADO
        Label3.Text = resultado
    End Sub

    'OPERACION RESTA
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1, num2 As Decimal
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        resultado = num1 - num2
        Label3.Text = Math.Round(resultado, 2)

    End Sub

    'MULTIPLICACION
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1, num2 As Decimal
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        resultado = num1 * num2
        Label3.Text = Math.Round(resultado, 2)
    End Sub

    'DIVISION
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1, num2 As Decimal
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        resultado = num1 / num2
        Label3.Text = Math.Round(resultado, 2)
    End Sub

    'RESIDUO
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim num1, num2 As Decimal
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        resultado = num1 Mod num2
        Label3.Text = Math.Round(resultado, 2)
    End Sub

    'CIERRA EL APLICATIVO
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'OPCIONES DE CERRAR
        'End
        Me.Close()
    End Sub

    'LIMPIAMOS EL FORM
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label3.Text = ""
        'ENFOCAMOS EL TEXTBOX1
        TextBox1.Focus()

    End Sub
End Class

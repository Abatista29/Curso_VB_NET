Public Class Form1
    'VARIABLES
    Dim num1 As Decimal
    Dim num2 As Decimal
    Dim resul As Decimal
    Dim operador As String
    Dim bandera As Integer = 0

    ' LIMPIAMOS EL TEXTBOX
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = ""
        num2 = 0
        num2 = 0
        resul = 0
    End Sub
    ' 7
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If bandera = 1 Then
            TextBox1.Text = ""
            bandera = 0
        End If
        TextBox1.Text = TextBox1.Text & "7"
    End Sub
    ' 8
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If bandera = 1 Then
            TextBox1.Text = ""
            bandera = 0
        End If
        TextBox1.Text = TextBox1.Text & "8"
    End Sub
    '9
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If bandera = 1 Then
            TextBox1.Text = ""
            bandera = 0
        End If
        TextBox1.Text = TextBox1.Text & "9"
    End Sub
    '4
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If bandera = 1 Then
            TextBox1.Text = ""
            bandera = 0
        End If
        TextBox1.Text = TextBox1.Text & "4"
    End Sub
    '5
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If bandera = 1 Then
            TextBox1.Text = ""
            bandera = 0
        End If
        TextBox1.Text = TextBox1.Text & "5"
    End Sub
    '6
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If bandera = 1 Then
            TextBox1.Text = ""
            bandera = 0
        End If
        TextBox1.Text = TextBox1.Text & "6"
    End Sub
    '1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If bandera = 1 Then
            TextBox1.Text = ""
            bandera = 0
        End If
        TextBox1.Text = TextBox1.Text & "1"
    End Sub
    '2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If bandera = 1 Then
            TextBox1.Text = ""
            bandera = 0
        End If
        TextBox1.Text = TextBox1.Text & "2"
    End Sub
    '3
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If bandera = 1 Then
            TextBox1.Text = ""
            bandera = 0
        End If
        TextBox1.Text = TextBox1.Text & "3"
    End Sub
    ' .
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If bandera = 1 Then
            TextBox1.Text = ""
            bandera = 0
        End If
        TextBox1.Text = TextBox1.Text & "."
    End Sub
    ' 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If bandera = 1 Then
            TextBox1.Text = ""
            bandera = 0
        End If
        TextBox1.Text = TextBox1.Text & "0"
    End Sub
    ' SUMA
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        num1 = TextBox1.Text
        TextBox1.Text = ""
        operador = "+"
    End Sub
    ' RESTA 
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        num1 = TextBox1.Text
        TextBox1.Text = ""
        operador = "-"
    End Sub
    ' MULTIPLICACION
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        num1 = TextBox1.Text
        TextBox1.Text = ""
        operador = "*"
    End Sub
    ' DIVISION
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        num1 = TextBox1.Text
        TextBox1.Text = ""
        operador = "/"
    End Sub
    ' = RESULTADO
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        num2 = TextBox1.Text

        Select Case operador
            Case "+"
                resul = num1 + num2
            Case "-"
                resul = num1 - num2
            Case "*"
                resul = num1 * num2
            Case "/"
                resul = num1 / num2
            Case Else
                MsgBox("OPERADOR INCORRECTO")
        End Select

        TextBox1.Text = resul

        bandera = 1
    End Sub
End Class

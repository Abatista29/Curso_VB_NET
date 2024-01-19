Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Enabled = False
        Button1.Enabled = False
        'Button2.Enabled = False
        ' VARIABLES
        Dim contador As Integer = 1
        Dim total As Decimal = 0

        While contador <= TextBox1.Text
            total = total + InputBox("Ingrese el dato numero " & contador)
            contador += 1
        End While

        ' RESULTADO DE LA OPERACION PROMEDIO
        Label2.Text = Format((total / TextBox1.Text), "Promedio: ###0.00")
        Label2.Visible = True

    End Sub
    ' BOTON NUEVO CALCULO
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'LIMPIAMOS LABEL
        Label2.Text = ""
        Label2.Visible = False
        'NOS UBICAMOS EN EL TEXTBOX1
        TextBox1.Text = ""
        TextBox1.Focus()
        'HABILITAMOS
        Button1.Enabled = True
        TextBox1.Enabled = True
    End Sub
End Class

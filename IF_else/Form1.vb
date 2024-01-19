Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text >= 5 Then
            Label2.Text = "Aprobado"
            Label2.ForeColor = Color.Green
        Else
            Label2.Text = "Reprobado"
            Label2.ForeColor = Color.Red
        End If
    End Sub

    'EVALUAMOS EL SALARIO DE UN EMPLEADO DEPENDIENDO DE LO QUE TRABAJA POR HORAS
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'DECLARAMOS VARIABLES OPERACION DE HORAS DOBLES
        Dim hrs_Dobles As Integer
        Dim hrs_Triples As Integer
        Dim subTotaldobles As Decimal
        Dim subTotalTriple As Decimal
        Dim total As Decimal

        ' menos de 40 horas se paga normal
        ' excedentes de 40 horas y menos de 50 horas se pagan dobles
        If TextBox1.Text <= 40 Then
            total = TextBox1.Text * TextBox2.Text
            Label12.Text = Format(Math.Round(total, 2), "$ ###,##0.#0") ' NORMAL
            Label11.Text = Format(Math.Round(0, 2), "$ ###,##0.#0") ' DOBLES
            Label10.Text = Format(Math.Round(0, 2), "$ ###,##0.#0") ' TRIPLES
            Label9.Text = Format(Math.Round(total, 2), "$ ###,##0.#0") ' TOTAL
        ElseIf TextBox1.Text > 40 And TextBox1.Text <= 50 Then
            ' SE SABE QUE YA HAY 40 HORAS TRABAJADAS Y SE * POR EL COSTO/HORA
            ' Horas normales
            total = 40 * TextBox2.Text
            Label12.Text = Format(Math.Round(total, 2), "$ ###,##0.#0") ' NORMAL
            ' Horas dobles
            hrs_Dobles = TextBox1.Text - 40
            subTotaldobles = (hrs_Dobles * TextBox2.Text) * 2
            Label11.Text = Format(Math.Round(subTotaldobles, 2), "$ ###,##0.#0") ' DOBLES
            ' Horas triples
            Label10.Text = Format(Math.Round(0, 2), "$ ###,##0.#0") ' TRIPLES
            ' Total
            total = total + subTotaldobles
            Label9.Text = Format(Math.Round(total, 2), "$ ###,##0.#0") ' TOTAL
        Else ' mas de 50 horas se paga el triple
            ' Horas normales
            total = 40 * TextBox2.Text
            Label12.Text = Format(Math.Round(total, 2), "$ ###,##0.#0") ' NORMAL
            ' Horas dobles
            subTotaldobles = (10 * TextBox2.Text) * 2
            Label11.Text = Format(Math.Round(subTotaldobles, 2), "$ ###,##0.#0") ' DOBLES
            ' Horas triples
            hrs_Triples = TextBox1.Text - 50
            subTotalTriple = (hrs_Triples * TextBox2.Text) * 3
            Label10.Text = Format(Math.Round(subTotalTriple, 2), "$ ###,##0.#0") ' TRIPLES
            ' Total
            total = total + subTotaldobles + subTotalTriple
            Label9.Text = Format(Math.Round(total, 2), "$ ###,##0.#0") ' TOTAL
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' LIMPIAMOS INPUTS
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label9.Text = ""
        Label10.Text = ""
        Label11.Text = ""
        Label12.Text = ""
        ' FOCUS A TEXTBOX INICIAL
        TextBox1.Focus()
    End Sub
End Class

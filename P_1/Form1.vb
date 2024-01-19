Public Class Form1
    Private Sub Bmuestra_boton_Click(sender As Object, e As EventArgs) Handles Bmuestra_boton.Click

        'CARGA MENSAJE DE AL LABEL
        Lmensaje.Text = Tmensaje.Text
        'LIMPIA EL TEXTBOX
        Tmensaje.Text = ""
        'ENFOCA EL TEXTBOX PARA SEGUIR ESCRIBIENDO
        Tmensaje.Focus()



    End Sub
End Class

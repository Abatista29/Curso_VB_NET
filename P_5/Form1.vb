Public Class Form1
    'BOTON AGREGAR
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'AGREGAR A LSTBOX 1
        If TextBox1.Text <> "" Then
            Lmsg_error.Text = ""
            ListBox1.Items.Add(TextBox1.Text)
            TextBox1.Text = ""
            TextBox1.Focus()
        Else
            Lmsg_error.Text = "Debe ingresar un nombre"
            TextBox1.Focus()
        End If

    End Sub
    'PASAR A LISTBOX 2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedItems.Count = 1 Then
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            ActualizaLabels()
            Lmsg_error.Text = ""
        Else
            Lmsg_error.Text = "Debe seleccionar un nombre"
        End If
    End Sub
    'PASAR A LISTBOX 1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListBox2.SelectedItems.Count = 1 Then
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
            ActualizaLabels()
            Lmsg_error.Text = ""
        Else
            Lmsg_error.Text = "Debe seleccionar un nombre"
        End If
    End Sub
    'PASAR TODOS LOS ITEMS AL LISTBOX 2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'DECLARO CONTADOR
        Dim contador As Integer
        If ListBox1.Items.Count > 0 Then
            For contador = 0 To (ListBox1.Items.Count - 1)
                ListBox2.Items.Add(ListBox1.Items.Item(contador))
            Next
            Lmsg_error.Text = ""
            ListBox1.Items.Clear()
            ActualizaLabels()
        Else
            Lmsg_error.Text = "No existen valores en la lista"
        End If
    End Sub
    'PASAR TODOS LOS ITEMS AL LISTBOX 1
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'DECLARO CONTADOR
        Dim contador As Integer
        If ListBox2.Items.Count > 0 Then
            For contador = 0 To (ListBox2.Items.Count - 1)
                ListBox1.Items.Add(ListBox2.Items.Item(contador))
            Next
            Lmsg_error.Text = ""
            ListBox2.Items.Clear()
            ActualizaLabels()
        Else
            Lmsg_error.Text = "No existen valores en la lista"
        End If
    End Sub
    'MANTIENE ACTUALIZADO LOS LABELS DE LOS ITEMS SELECCIONADO (1 Y 2)

    Private Sub ActualizaLabels()
        'LISTBOX 1
        If ListBox1.Items.Count > 0 Then
            Label2.Text = "Indice: " & ListBox1.SelectedIndex
            Label3.Text = "Nombre: " & ListBox1.SelectedItem
            Label4.Text = "Elementos: " & ListBox1.Items.Count()
            'si el listbox tiene items y no esta seleccionado dejar en blanco los labels hasta que se seleccione uno
        ElseIf ListBox1.Items.Count > 0 And ListBox1.SelectedIndex < 0 Then
            Label2.Text = "Indice: "
            Label3.Text = "Nombre: "
            Label4.Text = "Elementos: "
        Else
            Label2.Text = "Indice: "
            Label3.Text = "Nombre: "
            Label4.Text = "Elementos: "
        End If

        'LISTBOS 2
        If ListBox2.Items.Count > 0 Then
            Label7.Text = "Indice: " & ListBox2.SelectedIndex
            Label6.Text = "Nombre: " & ListBox2.SelectedItem
            Label5.Text = "Elementos: " & ListBox2.Items.Count()
            'si el listbox tiene items y no esta seleccionado dejar en blanco los labels hasta que se seleccione uno
        ElseIf ListBox1.Items.Count > 0 And ListBox1.SelectedIndex < 0 Then
            Label2.Text = "Indice: "
            Label3.Text = "Nombre: "
            Label4.Text = "Elementos: "
        Else
            Label7.Text = "Indice: "
            Label6.Text = "Nombre: "
            Label5.Text = "Elementos"
        End If

    End Sub
    'CONTENEDOR DEL LISTBOX_1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ActualizaLabels()
    End Sub
    'CONTENEDOR DE LISTBOX_2
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        ActualizaLabels()
    End Sub
    'ELIMINAR UN ELEMENTOS SELECCIONADO DE LISTBOX 1
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ListBox1.SelectedItems.Count > 0 Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            ActualizaLabels()
            Lmsg_error.Text = ""
        Else
            Lmsg_error.Text = "Seleccione un elemento a eliminar"
        End If
    End Sub
    'ELIMINAR TODOS LOS ELEMENTOS DE LISTBOX 1
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ListBox1.Items.Count > 0 Then
            ListBox1.Items.Clear()
            ActualizaLabels()
            Lmsg_error.Text = ""
        Else
            Lmsg_error.Text = "No existen elementos para eliminar"
        End If
    End Sub
    'ELIMINAR UN ELEMENTO DE LISTBOX 2
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If ListBox2.SelectedItems.Count > 0 Then
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
            ActualizaLabels()
            Lmsg_error.Text = ""
        Else
            Lmsg_error.Text = "Seleccione un elemento a eliminar"
        End If
    End Sub
    'ELIMINAR TODOS LOS ELEMENTOS DE LISTBOX 2
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If ListBox2.Items.Count > 0 Then
            ListBox2.Items.Clear()
            ActualizaLabels()
            Lmsg_error.Text = ""
        Else
            Lmsg_error.Text = "No existen elementos para eliminar"
        End If
    End Sub
End Class

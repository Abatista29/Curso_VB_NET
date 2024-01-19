<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mensaje = New System.Windows.Forms.Button()
        Me.Lmensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'mensaje
        '
        Me.mensaje.Location = New System.Drawing.Point(107, 83)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(126, 47)
        Me.mensaje.TabIndex = 0
        Me.mensaje.Text = "Mensaje"
        Me.mensaje.UseVisualStyleBackColor = True
        '
        'Lmensaje
        '
        Me.Lmensaje.AutoSize = True
        Me.Lmensaje.Location = New System.Drawing.Point(91, 32)
        Me.Lmensaje.Name = "Lmensaje"
        Me.Lmensaje.Size = New System.Drawing.Size(0, 20)
        Me.Lmensaje.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 190)
        Me.Controls.Add(Me.Lmensaje)
        Me.Controls.Add(Me.mensaje)
        Me.Name = "Form1"
        Me.Text = "Hola Mundo"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mensaje As Button
    Friend WithEvents Lmensaje As Label
End Class

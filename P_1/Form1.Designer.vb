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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Linstruccion = New System.Windows.Forms.Label()
        Me.Tmensaje = New System.Windows.Forms.TextBox()
        Me.Bmuestra_boton = New System.Windows.Forms.Button()
        Me.Lmensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Linstruccion
        '
        Me.Linstruccion.AutoSize = True
        Me.Linstruccion.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Linstruccion.Location = New System.Drawing.Point(44, 50)
        Me.Linstruccion.Name = "Linstruccion"
        Me.Linstruccion.Size = New System.Drawing.Size(220, 26)
        Me.Linstruccion.TabIndex = 0
        Me.Linstruccion.Text = "Escribe un mensaje:"
        '
        'Tmensaje
        '
        Me.Tmensaje.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tmensaje.Location = New System.Drawing.Point(281, 50)
        Me.Tmensaje.Name = "Tmensaje"
        Me.Tmensaje.Size = New System.Drawing.Size(470, 30)
        Me.Tmensaje.TabIndex = 1
        '
        'Bmuestra_boton
        '
        Me.Bmuestra_boton.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Bmuestra_boton.Location = New System.Drawing.Point(281, 112)
        Me.Bmuestra_boton.Name = "Bmuestra_boton"
        Me.Bmuestra_boton.Size = New System.Drawing.Size(470, 42)
        Me.Bmuestra_boton.TabIndex = 2
        Me.Bmuestra_boton.Text = "Mostrar Mensaje"
        Me.Bmuestra_boton.UseVisualStyleBackColor = True
        '
        'Lmensaje
        '
        Me.Lmensaje.AutoSize = True
        Me.Lmensaje.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lmensaje.Location = New System.Drawing.Point(100, 213)
        Me.Lmensaje.Name = "Lmensaje"
        Me.Lmensaje.Size = New System.Drawing.Size(0, 26)
        Me.Lmensaje.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 392)
        Me.Controls.Add(Me.Lmensaje)
        Me.Controls.Add(Me.Bmuestra_boton)
        Me.Controls.Add(Me.Tmensaje)
        Me.Controls.Add(Me.Linstruccion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Proyecto"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Linstruccion As Label
    Friend WithEvents Tmensaje As TextBox
    Friend WithEvents Bmuestra_boton As Button
    Friend WithEvents Lmensaje As Label
End Class

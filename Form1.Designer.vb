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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(191, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(377, 55)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Genera nuevo numero "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(103, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Introduce un número:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(344, 198)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(224, 26)
        Me.TextBox1.TabIndex = 2
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(107, 248)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(499, 181)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(107, 462)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(124, 56)
        Me.Limpiar.TabIndex = 4
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(521, 462)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 56)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 544)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Limpiar As Button
    Friend WithEvents Button2 As Button
End Class

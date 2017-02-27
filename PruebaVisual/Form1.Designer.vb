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
        Me.components = New System.ComponentModel.Container()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.btnMensaje = New System.Windows.Forms.Button()
        Me.btnCambiar2 = New System.Windows.Forms.Button()
        Me.lblMensaje2 = New System.Windows.Forms.Label()
        Me.cargar = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(327, 19)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(89, 24)
        Me.lblMensaje.TabIndex = 0
        Me.lblMensaje.Text = "Mensaje"
        '
        'btnMensaje
        '
        Me.btnMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMensaje.Location = New System.Drawing.Point(327, 64)
        Me.btnMensaje.Name = "btnMensaje"
        Me.btnMensaje.Size = New System.Drawing.Size(85, 27)
        Me.btnMensaje.TabIndex = 1
        Me.btnMensaje.Text = "Cambiar mensaje"
        Me.btnMensaje.UseVisualStyleBackColor = True
        '
        'btnCambiar2
        '
        Me.btnCambiar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiar2.Location = New System.Drawing.Point(535, 67)
        Me.btnCambiar2.Name = "btnCambiar2"
        Me.btnCambiar2.Size = New System.Drawing.Size(81, 24)
        Me.btnCambiar2.TabIndex = 4
        Me.btnCambiar2.Text = "Cambiar"
        Me.btnCambiar2.UseVisualStyleBackColor = True
        '
        'lblMensaje2
        '
        Me.lblMensaje2.AutoSize = True
        Me.lblMensaje2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje2.Location = New System.Drawing.Point(535, 19)
        Me.lblMensaje2.Name = "lblMensaje2"
        Me.lblMensaje2.Size = New System.Drawing.Size(82, 24)
        Me.lblMensaje2.TabIndex = 5
        Me.lblMensaje2.Text = "Mensaje"
        '
        'cargar
        '
        Me.cargar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cargar.Location = New System.Drawing.Point(373, 216)
        Me.cargar.Name = "cargar"
        Me.cargar.Size = New System.Drawing.Size(295, 204)
        Me.cargar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.cargar.TabIndex = 11
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Image = Global.PruebaVisual.My.Resources.Resources._367992_74be3bf69a377a2a1eeefbdec872b8591
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(265, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(616, 413)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Mensaje"
        '
        'Button5
        '
        Me.Button5.Image = Global.PruebaVisual.My.Resources.Resources.degradado1
        Me.Button5.Location = New System.Drawing.Point(3, 186)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(230, 61)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.PruebaVisual.My.Resources.Resources.degradado1
        Me.Button6.Location = New System.Drawing.Point(3, 125)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(230, 61)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "detener"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.PruebaVisual.My.Resources.Resources.degradado1
        Me.Button4.Location = New System.Drawing.Point(3, 64)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(230, 61)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Cargar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.PruebaVisual.My.Resources.Resources.degradado1
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 61)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cambiar mensaje"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(1009, 432)
        Me.Controls.Add(Me.cargar)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblMensaje2)
        Me.Controls.Add(Me.btnCambiar2)
        Me.Controls.Add(Me.btnMensaje)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMensaje As Label
    Friend WithEvents btnMensaje As Button
    Friend WithEvents btnCambiar2 As Button
    Friend WithEvents lblMensaje2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents cargar As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class

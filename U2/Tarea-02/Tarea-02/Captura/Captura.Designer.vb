<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Captura
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
        Me.OK = New System.Windows.Forms.Button()
        Me.txtValor_3 = New System.Windows.Forms.TextBox()
        Me.txtValor_2 = New System.Windows.Forms.TextBox()
        Me.txtValor_1 = New System.Windows.Forms.TextBox()
        Me.lblValor_3 = New System.Windows.Forms.Label()
        Me.lblValor_2 = New System.Windows.Forms.Label()
        Me.lblValor_1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(147, 180)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(75, 23)
        Me.OK.TabIndex = 13
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'txtValor_3
        '
        Me.txtValor_3.Location = New System.Drawing.Point(169, 113)
        Me.txtValor_3.Name = "txtValor_3"
        Me.txtValor_3.Size = New System.Drawing.Size(100, 20)
        Me.txtValor_3.TabIndex = 12
        '
        'txtValor_2
        '
        Me.txtValor_2.Location = New System.Drawing.Point(169, 86)
        Me.txtValor_2.Name = "txtValor_2"
        Me.txtValor_2.Size = New System.Drawing.Size(100, 20)
        Me.txtValor_2.TabIndex = 11
        '
        'txtValor_1
        '
        Me.txtValor_1.Location = New System.Drawing.Point(169, 60)
        Me.txtValor_1.Name = "txtValor_1"
        Me.txtValor_1.Size = New System.Drawing.Size(100, 20)
        Me.txtValor_1.TabIndex = 10
        '
        'lblValor_3
        '
        Me.lblValor_3.AutoSize = True
        Me.lblValor_3.Location = New System.Drawing.Point(100, 120)
        Me.lblValor_3.Name = "lblValor_3"
        Me.lblValor_3.Size = New System.Drawing.Size(39, 13)
        Me.lblValor_3.TabIndex = 9
        Me.lblValor_3.Text = "valor 3"
        '
        'lblValor_2
        '
        Me.lblValor_2.AutoSize = True
        Me.lblValor_2.Location = New System.Drawing.Point(100, 93)
        Me.lblValor_2.Name = "lblValor_2"
        Me.lblValor_2.Size = New System.Drawing.Size(39, 13)
        Me.lblValor_2.TabIndex = 8
        Me.lblValor_2.Text = "valor 2"
        '
        'lblValor_1
        '
        Me.lblValor_1.AutoSize = True
        Me.lblValor_1.Location = New System.Drawing.Point(100, 63)
        Me.lblValor_1.Name = "lblValor_1"
        Me.lblValor_1.Size = New System.Drawing.Size(39, 13)
        Me.lblValor_1.TabIndex = 7
        Me.lblValor_1.Text = "valor 1"
        '
        'Captura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 262)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txtValor_3)
        Me.Controls.Add(Me.txtValor_2)
        Me.Controls.Add(Me.txtValor_1)
        Me.Controls.Add(Me.lblValor_3)
        Me.Controls.Add(Me.lblValor_2)
        Me.Controls.Add(Me.lblValor_1)
        Me.Name = "Captura"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents OK As Button
    Private WithEvents txtValor_3 As TextBox
    Private WithEvents txtValor_2 As TextBox
    Private WithEvents txtValor_1 As TextBox
    Private WithEvents lblValor_3 As Label
    Private WithEvents lblValor_2 As Label
    Private WithEvents lblValor_1 As Label
End Class

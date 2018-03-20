<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProyectoDos
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
        Me.lblDato1 = New System.Windows.Forms.Label()
        Me.lblDato2 = New System.Windows.Forms.Label()
        Me.lblDato3 = New System.Windows.Forms.Label()
        Me.txtDato1 = New System.Windows.Forms.TextBox()
        Me.txtDato2 = New System.Windows.Forms.TextBox()
        Me.txtDato3 = New System.Windows.Forms.TextBox()
        Me.lblDato4 = New System.Windows.Forms.Label()
        Me.txtDato4 = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnIr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDato1
        '
        Me.lblDato1.AutoSize = True
        Me.lblDato1.Location = New System.Drawing.Point(107, 63)
        Me.lblDato1.Name = "lblDato1"
        Me.lblDato1.Size = New System.Drawing.Size(42, 13)
        Me.lblDato1.TabIndex = 0
        Me.lblDato1.Text = "Dato 1:"
        '
        'lblDato2
        '
        Me.lblDato2.AutoSize = True
        Me.lblDato2.Location = New System.Drawing.Point(107, 111)
        Me.lblDato2.Name = "lblDato2"
        Me.lblDato2.Size = New System.Drawing.Size(42, 13)
        Me.lblDato2.TabIndex = 1
        Me.lblDato2.Text = "Dato 2:"
        '
        'lblDato3
        '
        Me.lblDato3.AutoSize = True
        Me.lblDato3.Location = New System.Drawing.Point(107, 167)
        Me.lblDato3.Name = "lblDato3"
        Me.lblDato3.Size = New System.Drawing.Size(42, 13)
        Me.lblDato3.TabIndex = 2
        Me.lblDato3.Text = "Dato 3:"
        '
        'txtDato1
        '
        Me.txtDato1.Location = New System.Drawing.Point(227, 63)
        Me.txtDato1.Name = "txtDato1"
        Me.txtDato1.Size = New System.Drawing.Size(100, 20)
        Me.txtDato1.TabIndex = 3
        '
        'txtDato2
        '
        Me.txtDato2.Location = New System.Drawing.Point(227, 104)
        Me.txtDato2.Name = "txtDato2"
        Me.txtDato2.Size = New System.Drawing.Size(100, 20)
        Me.txtDato2.TabIndex = 4
        '
        'txtDato3
        '
        Me.txtDato3.Location = New System.Drawing.Point(227, 164)
        Me.txtDato3.Name = "txtDato3"
        Me.txtDato3.Size = New System.Drawing.Size(100, 20)
        Me.txtDato3.TabIndex = 5
        '
        'lblDato4
        '
        Me.lblDato4.AutoSize = True
        Me.lblDato4.Location = New System.Drawing.Point(370, 62)
        Me.lblDato4.Name = "lblDato4"
        Me.lblDato4.Size = New System.Drawing.Size(58, 13)
        Me.lblDato4.TabIndex = 6
        Me.lblDato4.Text = "Respuesta"
        '
        'txtDato4
        '
        Me.txtDato4.Location = New System.Drawing.Point(434, 59)
        Me.txtDato4.Name = "txtDato4"
        Me.txtDato4.Size = New System.Drawing.Size(100, 20)
        Me.txtDato4.TabIndex = 7
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(434, 106)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnIr
        '
        Me.btnIr.Location = New System.Drawing.Point(434, 156)
        Me.btnIr.Name = "btnIr"
        Me.btnIr.Size = New System.Drawing.Size(75, 23)
        Me.btnIr.TabIndex = 9
        Me.btnIr.Text = "Ir a"
        Me.btnIr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIr.UseVisualStyleBackColor = True
        '
        'ProyectoDos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 262)
        Me.Controls.Add(Me.btnIr)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtDato4)
        Me.Controls.Add(Me.lblDato4)
        Me.Controls.Add(Me.txtDato3)
        Me.Controls.Add(Me.txtDato2)
        Me.Controls.Add(Me.txtDato1)
        Me.Controls.Add(Me.lblDato3)
        Me.Controls.Add(Me.lblDato2)
        Me.Controls.Add(Me.lblDato1)
        Me.Name = "ProyectoDos"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDato1 As Label
    Friend WithEvents lblDato2 As Label
    Friend WithEvents lblDato3 As Label
    Friend WithEvents txtDato1 As TextBox
    Friend WithEvents txtDato2 As TextBox
    Friend WithEvents txtDato3 As TextBox
    Friend WithEvents lblDato4 As Label
    Friend WithEvents txtDato4 As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnIr As Button
End Class

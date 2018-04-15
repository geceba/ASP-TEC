<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTarea
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
        Me.lblRepeticiones = New System.Windows.Forms.Label()
        Me.lblValor1 = New System.Windows.Forms.Label()
        Me.lblValor2 = New System.Windows.Forms.Label()
        Me.lblValor3 = New System.Windows.Forms.Label()
        Me.txtRepeticiones = New System.Windows.Forms.TextBox()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.txtValor3 = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAlert = New System.Windows.Forms.Label()
        Me.lblProm = New System.Windows.Forms.Label()
        Me.lblPromProm = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRepeticiones
        '
        Me.lblRepeticiones.AutoSize = True
        Me.lblRepeticiones.Location = New System.Drawing.Point(86, 54)
        Me.lblRepeticiones.Name = "lblRepeticiones"
        Me.lblRepeticiones.Size = New System.Drawing.Size(84, 13)
        Me.lblRepeticiones.TabIndex = 0
        Me.lblRepeticiones.Text = "Cuantas veces?"
        '
        'lblValor1
        '
        Me.lblValor1.AutoSize = True
        Me.lblValor1.Location = New System.Drawing.Point(86, 100)
        Me.lblValor1.Name = "lblValor1"
        Me.lblValor1.Size = New System.Drawing.Size(43, 13)
        Me.lblValor1.TabIndex = 1
        Me.lblValor1.Text = "Valor 1:"
        '
        'lblValor2
        '
        Me.lblValor2.AutoSize = True
        Me.lblValor2.Location = New System.Drawing.Point(86, 132)
        Me.lblValor2.Name = "lblValor2"
        Me.lblValor2.Size = New System.Drawing.Size(43, 13)
        Me.lblValor2.TabIndex = 2
        Me.lblValor2.Text = "Valor 2:"
        '
        'lblValor3
        '
        Me.lblValor3.AutoSize = True
        Me.lblValor3.Location = New System.Drawing.Point(86, 163)
        Me.lblValor3.Name = "lblValor3"
        Me.lblValor3.Size = New System.Drawing.Size(40, 13)
        Me.lblValor3.TabIndex = 3
        Me.lblValor3.Text = "Valor 3"
        '
        'txtRepeticiones
        '
        Me.txtRepeticiones.Location = New System.Drawing.Point(268, 46)
        Me.txtRepeticiones.Name = "txtRepeticiones"
        Me.txtRepeticiones.Size = New System.Drawing.Size(100, 20)
        Me.txtRepeticiones.TabIndex = 4
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(175, 93)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 20)
        Me.txtValor1.TabIndex = 5
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(175, 125)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 20)
        Me.txtValor2.TabIndex = 6
        '
        'txtValor3
        '
        Me.txtValor3.Location = New System.Drawing.Point(175, 156)
        Me.txtValor3.Name = "txtValor3"
        Me.txtValor3.Size = New System.Drawing.Size(100, 20)
        Me.txtValor3.TabIndex = 7
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(417, 111)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(104, 33)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Promedio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Prom Prom"
        '
        'lblAlert
        '
        Me.lblAlert.AutoSize = True
        Me.lblAlert.Location = New System.Drawing.Point(469, 213)
        Me.lblAlert.Name = "lblAlert"
        Me.lblAlert.Size = New System.Drawing.Size(0, 13)
        Me.lblAlert.TabIndex = 11
        '
        'lblProm
        '
        Me.lblProm.AutoSize = True
        Me.lblProm.Location = New System.Drawing.Point(290, 201)
        Me.lblProm.Name = "lblProm"
        Me.lblProm.Size = New System.Drawing.Size(13, 13)
        Me.lblProm.TabIndex = 12
        Me.lblProm.Text = "0"
        '
        'lblPromProm
        '
        Me.lblPromProm.AutoSize = True
        Me.lblPromProm.Location = New System.Drawing.Point(290, 226)
        Me.lblPromProm.Name = "lblPromProm"
        Me.lblPromProm.Size = New System.Drawing.Size(13, 13)
        Me.lblPromProm.TabIndex = 13
        Me.lblPromProm.Text = "0"
        '
        'FormTarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 262)
        Me.Controls.Add(Me.lblPromProm)
        Me.Controls.Add(Me.lblProm)
        Me.Controls.Add(Me.lblAlert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtValor3)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.txtRepeticiones)
        Me.Controls.Add(Me.lblValor3)
        Me.Controls.Add(Me.lblValor2)
        Me.Controls.Add(Me.lblValor1)
        Me.Controls.Add(Me.lblRepeticiones)
        Me.Name = "FormTarea"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRepeticiones As Label
    Friend WithEvents lblValor1 As Label
    Friend WithEvents lblValor2 As Label
    Friend WithEvents lblValor3 As Label
    Friend WithEvents txtRepeticiones As TextBox
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents txtValor3 As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAlert As Label
    Friend WithEvents lblProm As Label
    Friend WithEvents lblPromProm As Label
End Class

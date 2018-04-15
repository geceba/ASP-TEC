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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSuma = New System.Windows.Forms.Label()
        Me.lblResta = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblMulti = New System.Windows.Forms.Label()
        Me.lblDivision = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Suma"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Resta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Multiplicacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Division"
        '
        'lblSuma
        '
        Me.lblSuma.AutoSize = True
        Me.lblSuma.Location = New System.Drawing.Point(141, 36)
        Me.lblSuma.Name = "lblSuma"
        Me.lblSuma.Size = New System.Drawing.Size(13, 13)
        Me.lblSuma.TabIndex = 4
        Me.lblSuma.Text = "0"
        '
        'lblResta
        '
        Me.lblResta.AutoSize = True
        Me.lblResta.Location = New System.Drawing.Point(141, 85)
        Me.lblResta.Name = "lblResta"
        Me.lblResta.Size = New System.Drawing.Size(13, 13)
        Me.lblResta.TabIndex = 5
        Me.lblResta.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(272, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 6
        '
        'lblMulti
        '
        Me.lblMulti.AutoSize = True
        Me.lblMulti.Location = New System.Drawing.Point(141, 131)
        Me.lblMulti.Name = "lblMulti"
        Me.lblMulti.Size = New System.Drawing.Size(13, 13)
        Me.lblMulti.TabIndex = 7
        Me.lblMulti.Text = "0"
        '
        'lblDivision
        '
        Me.lblDivision.AutoSize = True
        Me.lblDivision.Location = New System.Drawing.Point(141, 177)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(13, 13)
        Me.lblDivision.TabIndex = 8
        Me.lblDivision.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblDivision)
        Me.Controls.Add(Me.lblMulti)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblResta)
        Me.Controls.Add(Me.lblSuma)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSuma As Label
    Friend WithEvents lblResta As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblMulti As Label
    Friend WithEvents lblDivision As Label
End Class

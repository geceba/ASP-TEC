<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtOption = New System.Windows.Forms.TextBox()
        Me.lblIngresarOpcion = New System.Windows.Forms.Label()
        Me.lblOpciones = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(462, 182)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 23)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Apachurrame"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtOption
        '
        Me.txtOption.Location = New System.Drawing.Point(462, 144)
        Me.txtOption.Name = "txtOption"
        Me.txtOption.Size = New System.Drawing.Size(90, 20)
        Me.txtOption.TabIndex = 8
        '
        'lblIngresarOpcion
        '
        Me.lblIngresarOpcion.AutoSize = True
        Me.lblIngresarOpcion.Location = New System.Drawing.Point(459, 114)
        Me.lblIngresarOpcion.Name = "lblIngresarOpcion"
        Me.lblIngresarOpcion.Size = New System.Drawing.Size(93, 13)
        Me.lblIngresarOpcion.TabIndex = 7
        Me.lblIngresarOpcion.Text = "Ingrese su Opcion"
        '
        'lblOpciones
        '
        Me.lblOpciones.AutoSize = True
        Me.lblOpciones.Location = New System.Drawing.Point(140, 114)
        Me.lblOpciones.Name = "lblOpciones"
        Me.lblOpciones.Size = New System.Drawing.Size(142, 91)
        Me.lblOpciones.TabIndex = 6
        Me.lblOpciones.Text = "Opciones:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    1.- Captura de datos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    2.- Suma de datos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    3.- Resta de dato" &
    "s" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    4.- Multiplicacion de datos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    5.- Division de datos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    6.- Resultado" &
    "s"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(296, 30)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(166, 33)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "Formulario"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 262)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtOption)
        Me.Controls.Add(Me.lblIngresarOpcion)
        Me.Controls.Add(Me.lblOpciones)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Menu"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnAceptar As Button
    Private WithEvents txtOption As TextBox
    Private WithEvents lblIngresarOpcion As Label
    Private WithEvents lblOpciones As Label
    Private WithEvents lblTitulo As Label
End Class

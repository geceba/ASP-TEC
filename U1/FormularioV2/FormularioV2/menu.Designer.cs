namespace FormularioV2
{
    partial class menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.lblIngresarOpcion = new System.Windows.Forms.Label();
            this.txtOpcion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(219, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(166, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Formulario";
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Location = new System.Drawing.Point(63, 93);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(142, 91);
            this.lblOpciones.TabIndex = 1;
            this.lblOpciones.Text = "Opciones:\r\n    1.- Captura de datos\r\n    2.- Suma de datos\r\n    3.- Resta de dato" +
    "s\r\n    4.- Multiplicacion de datos\r\n    5.- Division de datos\r\n    6.- Resultado" +
    "s";
            // 
            // lblIngresarOpcion
            // 
            this.lblIngresarOpcion.AutoSize = true;
            this.lblIngresarOpcion.Location = new System.Drawing.Point(382, 93);
            this.lblIngresarOpcion.Name = "lblIngresarOpcion";
            this.lblIngresarOpcion.Size = new System.Drawing.Size(93, 13);
            this.lblIngresarOpcion.TabIndex = 2;
            this.lblIngresarOpcion.Text = "Ingrese su Opcion";
            // 
            // txtOpcion
            // 
            this.txtOpcion.Location = new System.Drawing.Point(385, 123);
            this.txtOpcion.Name = "txtOpcion";
            this.txtOpcion.Size = new System.Drawing.Size(90, 20);
            this.txtOpcion.TabIndex = 3;
            this.txtOpcion.TextChanged += new System.EventHandler(this.txtOpcion_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(385, 161);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Apachurrame";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 262);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtOpcion);
            this.Controls.Add(this.lblIngresarOpcion);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.lblTitulo);
            this.Name = "menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Label lblIngresarOpcion;
        private System.Windows.Forms.TextBox txtOpcion;
        private System.Windows.Forms.Button btnAceptar;
    }
}


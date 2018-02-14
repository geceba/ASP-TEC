namespace ProyUno
{
    partial class ProyUno
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblHrsTrab = new System.Windows.Forms.Label();
            this.lblPagHora = new System.Windows.Forms.Label();
            this.txtHrsTrab = new System.Windows.Forms.TextBox();
            this.txtPagHora = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPagoNormal = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtPagoExtra = new System.Windows.Forms.TextBox();
            this.txtHrsTrabExtra = new System.Windows.Forms.TextBox();
            this.lblPagoExtra = new System.Windows.Forms.Label();
            this.lblHrsTrabExtra = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblPagoExtra2 = new System.Windows.Forms.Label();
            this.lblPagoTotal = new System.Windows.Forms.Label();
            this.lblResultadoPagoExtra = new System.Windows.Forms.Label();
            this.lblResultadoPagoTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(29, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(126, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblHrsTrab
            // 
            this.lblHrsTrab.AutoSize = true;
            this.lblHrsTrab.Location = new System.Drawing.Point(29, 62);
            this.lblHrsTrab.Name = "lblHrsTrab";
            this.lblHrsTrab.Size = new System.Drawing.Size(48, 13);
            this.lblHrsTrab.TabIndex = 2;
            this.lblHrsTrab.Text = "Hrs Trab";
            // 
            // lblPagHora
            // 
            this.lblPagHora.AutoSize = true;
            this.lblPagHora.Location = new System.Drawing.Point(29, 119);
            this.lblPagHora.Name = "lblPagHora";
            this.lblPagHora.Size = new System.Drawing.Size(52, 13);
            this.lblPagHora.TabIndex = 3;
            this.lblPagHora.Text = "Pag Hora";
            // 
            // txtHrsTrab
            // 
            this.txtHrsTrab.Location = new System.Drawing.Point(126, 55);
            this.txtHrsTrab.Name = "txtHrsTrab";
            this.txtHrsTrab.Size = new System.Drawing.Size(100, 20);
            this.txtHrsTrab.TabIndex = 4;
            this.txtHrsTrab.TextChanged += new System.EventHandler(this.txtHrsTrab_TextChanged);
            // 
            // txtPagHora
            // 
            this.txtPagHora.Location = new System.Drawing.Point(126, 119);
            this.txtPagHora.Name = "txtPagHora";
            this.txtPagHora.Size = new System.Drawing.Size(100, 20);
            this.txtPagHora.TabIndex = 5;
            this.txtPagHora.TextChanged += new System.EventHandler(this.txtPagHora_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(109, 173);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 74);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPagoNormal
            // 
            this.lblPagoNormal.AutoSize = true;
            this.lblPagoNormal.Location = new System.Drawing.Point(287, 190);
            this.lblPagoNormal.Name = "lblPagoNormal";
            this.lblPagoNormal.Size = new System.Drawing.Size(68, 13);
            this.lblPagoNormal.TabIndex = 7;
            this.lblPagoNormal.Text = "Pago Normal";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(396, 190);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 8;
            // 
            // txtPagoExtra
            // 
            this.txtPagoExtra.Location = new System.Drawing.Point(399, 125);
            this.txtPagoExtra.Name = "txtPagoExtra";
            this.txtPagoExtra.Size = new System.Drawing.Size(100, 20);
            this.txtPagoExtra.TabIndex = 14;
            this.txtPagoExtra.TextChanged += new System.EventHandler(this.txtPagoExtra_TextChanged);
            // 
            // txtHrsTrabExtra
            // 
            this.txtHrsTrabExtra.Location = new System.Drawing.Point(399, 61);
            this.txtHrsTrabExtra.Name = "txtHrsTrabExtra";
            this.txtHrsTrabExtra.Size = new System.Drawing.Size(100, 20);
            this.txtHrsTrabExtra.TabIndex = 13;
            this.txtHrsTrabExtra.TextChanged += new System.EventHandler(this.txtHrsTrabExtra_TextChanged);
            // 
            // lblPagoExtra
            // 
            this.lblPagoExtra.AutoSize = true;
            this.lblPagoExtra.Location = new System.Drawing.Point(302, 125);
            this.lblPagoExtra.Name = "lblPagoExtra";
            this.lblPagoExtra.Size = new System.Drawing.Size(59, 13);
            this.lblPagoExtra.TabIndex = 12;
            this.lblPagoExtra.Text = "Pago Extra";
            // 
            // lblHrsTrabExtra
            // 
            this.lblHrsTrabExtra.AutoSize = true;
            this.lblHrsTrabExtra.Location = new System.Drawing.Point(302, 68);
            this.lblHrsTrabExtra.Name = "lblHrsTrabExtra";
            this.lblHrsTrabExtra.Size = new System.Drawing.Size(75, 13);
            this.lblHrsTrabExtra.TabIndex = 11;
            this.lblHrsTrabExtra.Text = "Hrs Trab Extra";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(399, 12);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 10;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(302, 15);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido";
            // 
            // lblPagoExtra2
            // 
            this.lblPagoExtra2.AutoSize = true;
            this.lblPagoExtra2.Location = new System.Drawing.Point(287, 219);
            this.lblPagoExtra2.Name = "lblPagoExtra2";
            this.lblPagoExtra2.Size = new System.Drawing.Size(59, 13);
            this.lblPagoExtra2.TabIndex = 15;
            this.lblPagoExtra2.Text = "Pago Extra";
            // 
            // lblPagoTotal
            // 
            this.lblPagoTotal.AutoSize = true;
            this.lblPagoTotal.Location = new System.Drawing.Point(287, 246);
            this.lblPagoTotal.Name = "lblPagoTotal";
            this.lblPagoTotal.Size = new System.Drawing.Size(59, 13);
            this.lblPagoTotal.TabIndex = 16;
            this.lblPagoTotal.Text = "Pago Total";
            // 
            // lblResultadoPagoExtra
            // 
            this.lblResultadoPagoExtra.AutoSize = true;
            this.lblResultadoPagoExtra.Location = new System.Drawing.Point(377, 219);
            this.lblResultadoPagoExtra.Name = "lblResultadoPagoExtra";
            this.lblResultadoPagoExtra.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoPagoExtra.TabIndex = 17;
            // 
            // lblResultadoPagoTotal
            // 
            this.lblResultadoPagoTotal.AutoSize = true;
            this.lblResultadoPagoTotal.Location = new System.Drawing.Point(361, 246);
            this.lblResultadoPagoTotal.Name = "lblResultadoPagoTotal";
            this.lblResultadoPagoTotal.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoPagoTotal.TabIndex = 18;
            // 
            // ProyUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 277);
            this.Controls.Add(this.lblResultadoPagoTotal);
            this.Controls.Add(this.lblResultadoPagoExtra);
            this.Controls.Add(this.lblPagoTotal);
            this.Controls.Add(this.lblPagoExtra2);
            this.Controls.Add(this.txtPagoExtra);
            this.Controls.Add(this.txtHrsTrabExtra);
            this.Controls.Add(this.lblPagoExtra);
            this.Controls.Add(this.lblHrsTrabExtra);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblPagoNormal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPagHora);
            this.Controls.Add(this.txtHrsTrab);
            this.Controls.Add(this.lblPagHora);
            this.Controls.Add(this.lblHrsTrab);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "ProyUno";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblHrsTrab;
        private System.Windows.Forms.Label lblPagHora;
        private System.Windows.Forms.TextBox txtHrsTrab;
        private System.Windows.Forms.TextBox txtPagHora;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPagoNormal;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtPagoExtra;
        private System.Windows.Forms.TextBox txtHrsTrabExtra;
        private System.Windows.Forms.Label lblPagoExtra;
        private System.Windows.Forms.Label lblHrsTrabExtra;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblPagoExtra2;
        private System.Windows.Forms.Label lblPagoTotal;
        private System.Windows.Forms.Label lblResultadoPagoExtra;
        private System.Windows.Forms.Label lblResultadoPagoTotal;
    }
}


namespace ProyectoDos
{
    partial class ProyectoDos
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
            this.valor1 = new System.Windows.Forms.Label();
            this.valor2 = new System.Windows.Forms.Label();
            this.valor3 = new System.Windows.Forms.Label();
            this.TxBDatoA = new System.Windows.Forms.TextBox();
            this.TxBDatoB = new System.Windows.Forms.TextBox();
            this.TxBDatoC = new System.Windows.Forms.TextBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPromProm = new System.Windows.Forms.Label();
            this.elBueno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // valor1
            // 
            this.valor1.AutoSize = true;
            this.valor1.Location = new System.Drawing.Point(139, 63);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(40, 13);
            this.valor1.TabIndex = 0;
            this.valor1.Text = "Valor 1";
            // 
            // valor2
            // 
            this.valor2.AutoSize = true;
            this.valor2.Location = new System.Drawing.Point(139, 93);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(40, 13);
            this.valor2.TabIndex = 1;
            this.valor2.Text = "Valor 2";
            // 
            // valor3
            // 
            this.valor3.AutoSize = true;
            this.valor3.Location = new System.Drawing.Point(139, 124);
            this.valor3.Name = "valor3";
            this.valor3.Size = new System.Drawing.Size(40, 13);
            this.valor3.TabIndex = 2;
            this.valor3.Text = "Valor 3";
            // 
            // TxBDatoA
            // 
            this.TxBDatoA.Location = new System.Drawing.Point(268, 55);
            this.TxBDatoA.Name = "TxBDatoA";
            this.TxBDatoA.Size = new System.Drawing.Size(100, 20);
            this.TxBDatoA.TabIndex = 3;
            this.TxBDatoA.TextChanged += new System.EventHandler(this.TxBDatoA_TextChanged);
            // 
            // TxBDatoB
            // 
            this.TxBDatoB.Location = new System.Drawing.Point(268, 86);
            this.TxBDatoB.Name = "TxBDatoB";
            this.TxBDatoB.Size = new System.Drawing.Size(100, 20);
            this.TxBDatoB.TabIndex = 4;
            this.TxBDatoB.TextChanged += new System.EventHandler(this.TxBDatoB_TextChanged);
            // 
            // TxBDatoC
            // 
            this.TxBDatoC.Location = new System.Drawing.Point(268, 116);
            this.TxBDatoC.Name = "TxBDatoC";
            this.TxBDatoC.Size = new System.Drawing.Size(100, 20);
            this.TxBDatoC.TabIndex = 5;
            this.TxBDatoC.TextChanged += new System.EventHandler(this.TxBDatoC_TextChanged);
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(214, 178);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(51, 13);
            this.lblPromedio.TabIndex = 6;
            this.lblPromedio.Text = "Promedio";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(299, 177);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 7;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(397, 88);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(86, 23);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Apachurrame";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cuantas veces?";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(229, 228);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Promedio de Promedio";
            // 
            // lblPromProm
            // 
            this.lblPromProm.AutoSize = true;
            this.lblPromProm.Location = new System.Drawing.Point(331, 204);
            this.lblPromProm.Name = "lblPromProm";
            this.lblPromProm.Size = new System.Drawing.Size(0, 13);
            this.lblPromProm.TabIndex = 13;
            // 
            // elBueno
            // 
            this.elBueno.Location = new System.Drawing.Point(268, 20);
            this.elBueno.Name = "elBueno";
            this.elBueno.Size = new System.Drawing.Size(100, 20);
            this.elBueno.TabIndex = 14;
            this.elBueno.TextChanged += new System.EventHandler(this.elBueno_TextChanged);
            // 
            // ProyectoDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 261);
            this.Controls.Add(this.elBueno);
            this.Controls.Add(this.lblPromProm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.TxBDatoC);
            this.Controls.Add(this.TxBDatoB);
            this.Controls.Add(this.TxBDatoA);
            this.Controls.Add(this.valor3);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.valor1);
            this.Name = "ProyectoDos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label valor1;
        private System.Windows.Forms.Label valor2;
        private System.Windows.Forms.Label valor3;
        private System.Windows.Forms.TextBox TxBDatoA;
        private System.Windows.Forms.TextBox TxBDatoB;
        private System.Windows.Forms.TextBox TxBDatoC;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPromProm;
        private System.Windows.Forms.TextBox elBueno;
    }
}


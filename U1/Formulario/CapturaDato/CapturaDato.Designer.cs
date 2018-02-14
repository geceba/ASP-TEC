namespace CapturaDato
{
    partial class CapturaDato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapturaDato));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxValor1 = new System.Windows.Forms.TextBox();
            this.txtBoxValor2 = new System.Windows.Forms.TextBox();
            this.txtBoxValor3 = new System.Windows.Forms.TextBox();
            this.regresarDesdeDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(31, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(31, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor 3:";
            // 
            // txtBoxValor1
            // 
            this.txtBoxValor1.Location = new System.Drawing.Point(88, 24);
            this.txtBoxValor1.Name = "txtBoxValor1";
            this.txtBoxValor1.Size = new System.Drawing.Size(64, 20);
            this.txtBoxValor1.TabIndex = 3;
            this.txtBoxValor1.TextChanged += new System.EventHandler(this.txtBoxValor1_TextChanged);
            // 
            // txtBoxValor2
            // 
            this.txtBoxValor2.Location = new System.Drawing.Point(88, 55);
            this.txtBoxValor2.Name = "txtBoxValor2";
            this.txtBoxValor2.Size = new System.Drawing.Size(64, 20);
            this.txtBoxValor2.TabIndex = 4;
            this.txtBoxValor2.TextChanged += new System.EventHandler(this.txtBoxValor2_TextChanged);
            // 
            // txtBoxValor3
            // 
            this.txtBoxValor3.Location = new System.Drawing.Point(88, 88);
            this.txtBoxValor3.Name = "txtBoxValor3";
            this.txtBoxValor3.Size = new System.Drawing.Size(64, 20);
            this.txtBoxValor3.TabIndex = 5;
            this.txtBoxValor3.TextChanged += new System.EventHandler(this.txtBoxValor3_TextChanged);
            // 
            // regresarDesdeDatos
            // 
            this.regresarDesdeDatos.BackColor = System.Drawing.Color.Transparent;
            this.regresarDesdeDatos.Location = new System.Drawing.Point(265, 50);
            this.regresarDesdeDatos.Name = "regresarDesdeDatos";
            this.regresarDesdeDatos.Size = new System.Drawing.Size(59, 69);
            this.regresarDesdeDatos.TabIndex = 6;
            this.regresarDesdeDatos.Text = "OK";
            this.regresarDesdeDatos.UseVisualStyleBackColor = false;
            this.regresarDesdeDatos.Click += new System.EventHandler(this.regresarDesdeDatos_Click);
            // 
            // CapturaDato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(354, 236);
            this.Controls.Add(this.regresarDesdeDatos);
            this.Controls.Add(this.txtBoxValor3);
            this.Controls.Add(this.txtBoxValor2);
            this.Controls.Add(this.txtBoxValor1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CapturaDato";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capturar Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxValor1;
        private System.Windows.Forms.TextBox txtBoxValor2;
        private System.Windows.Forms.TextBox txtBoxValor3;
        private System.Windows.Forms.Button regresarDesdeDatos;
    }
}


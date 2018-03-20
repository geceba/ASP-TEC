namespace Menu
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
            this.lblValor_1 = new System.Windows.Forms.Label();
            this.lblValor_2 = new System.Windows.Forms.Label();
            this.lblValor_3 = new System.Windows.Forms.Label();
            this.txtValor_1 = new System.Windows.Forms.TextBox();
            this.txtValor_2 = new System.Windows.Forms.TextBox();
            this.txtValor_3 = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValor_1
            // 
            this.lblValor_1.AutoSize = true;
            this.lblValor_1.Location = new System.Drawing.Point(50, 68);
            this.lblValor_1.Name = "lblValor_1";
            this.lblValor_1.Size = new System.Drawing.Size(39, 13);
            this.lblValor_1.TabIndex = 0;
            this.lblValor_1.Text = "valor 1";
            // 
            // lblValor_2
            // 
            this.lblValor_2.AutoSize = true;
            this.lblValor_2.Location = new System.Drawing.Point(50, 98);
            this.lblValor_2.Name = "lblValor_2";
            this.lblValor_2.Size = new System.Drawing.Size(39, 13);
            this.lblValor_2.TabIndex = 1;
            this.lblValor_2.Text = "valor 2";
            // 
            // lblValor_3
            // 
            this.lblValor_3.AutoSize = true;
            this.lblValor_3.Location = new System.Drawing.Point(50, 125);
            this.lblValor_3.Name = "lblValor_3";
            this.lblValor_3.Size = new System.Drawing.Size(39, 13);
            this.lblValor_3.TabIndex = 2;
            this.lblValor_3.Text = "valor 3";
            // 
            // txtValor_1
            // 
            this.txtValor_1.Location = new System.Drawing.Point(119, 65);
            this.txtValor_1.Name = "txtValor_1";
            this.txtValor_1.Size = new System.Drawing.Size(100, 20);
            this.txtValor_1.TabIndex = 3;
            this.txtValor_1.TextChanged += new System.EventHandler(this.txtValor_1_TextChanged);
            // 
            // txtValor_2
            // 
            this.txtValor_2.Location = new System.Drawing.Point(119, 91);
            this.txtValor_2.Name = "txtValor_2";
            this.txtValor_2.Size = new System.Drawing.Size(100, 20);
            this.txtValor_2.TabIndex = 4;
            this.txtValor_2.TextChanged += new System.EventHandler(this.txtValor_2_TextChanged);
            // 
            // txtValor_3
            // 
            this.txtValor_3.Location = new System.Drawing.Point(119, 118);
            this.txtValor_3.Name = "txtValor_3";
            this.txtValor_3.Size = new System.Drawing.Size(100, 20);
            this.txtValor_3.TabIndex = 5;
            this.txtValor_3.TextChanged += new System.EventHandler(this.txtValor_3_TextChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(97, 185);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 6;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.txtValor_3);
            this.Controls.Add(this.txtValor_2);
            this.Controls.Add(this.txtValor_1);
            this.Controls.Add(this.lblValor_3);
            this.Controls.Add(this.lblValor_2);
            this.Controls.Add(this.lblValor_1);
            this.Name = "menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor_1;
        private System.Windows.Forms.Label lblValor_2;
        private System.Windows.Forms.Label lblValor_3;
        private System.Windows.Forms.TextBox txtValor_1;
        private System.Windows.Forms.TextBox txtValor_2;
        private System.Windows.Forms.TextBox txtValor_3;
        private System.Windows.Forms.Button OK;
    }
}


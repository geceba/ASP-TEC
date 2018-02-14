namespace Proyecto03
{
    partial class Form1
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
            this.lblPromProm = new System.Windows.Forms.Label();
            this.TxBPromProms = new System.Windows.Forms.TextBox();
            this.btnDesplegar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPromProm
            // 
            this.lblPromProm.AutoSize = true;
            this.lblPromProm.Location = new System.Drawing.Point(188, 96);
            this.lblPromProm.Name = "lblPromProm";
            this.lblPromProm.Size = new System.Drawing.Size(118, 13);
            this.lblPromProm.TabIndex = 0;
            this.lblPromProm.Text = "Promedio de Promedios";
            // 
            // TxBPromProms
            // 
            this.TxBPromProms.Location = new System.Drawing.Point(404, 93);
            this.TxBPromProms.Name = "TxBPromProms";
            this.TxBPromProms.Size = new System.Drawing.Size(140, 20);
            this.TxBPromProms.TabIndex = 1;
            // 
            // btnDesplegar
            // 
            this.btnDesplegar.Location = new System.Drawing.Point(216, 169);
            this.btnDesplegar.Name = "btnDesplegar";
            this.btnDesplegar.Size = new System.Drawing.Size(87, 23);
            this.btnDesplegar.TabIndex = 2;
            this.btnDesplegar.Text = "Desplegar";
            this.btnDesplegar.UseVisualStyleBackColor = true;
            this.btnDesplegar.Click += new System.EventHandler(this.btnDesplegar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(404, 169);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(87, 23);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 261);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnDesplegar);
            this.Controls.Add(this.TxBPromProms);
            this.Controls.Add(this.lblPromProm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPromProm;
        private System.Windows.Forms.TextBox TxBPromProms;
        private System.Windows.Forms.Button btnDesplegar;
        private System.Windows.Forms.Button btnRegresar;
    }
}


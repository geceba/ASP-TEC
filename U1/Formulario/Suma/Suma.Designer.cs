namespace Suma
{
    partial class Suma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suma));
            this.regresarDesdeSuma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regresarDesdeSuma
            // 
            this.regresarDesdeSuma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("regresarDesdeSuma.BackgroundImage")));
            this.regresarDesdeSuma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regresarDesdeSuma.Location = new System.Drawing.Point(225, 256);
            this.regresarDesdeSuma.Name = "regresarDesdeSuma";
            this.regresarDesdeSuma.Size = new System.Drawing.Size(60, 58);
            this.regresarDesdeSuma.TabIndex = 3;
            this.regresarDesdeSuma.UseVisualStyleBackColor = true;
            this.regresarDesdeSuma.Click += new System.EventHandler(this.regresarDesdeSuma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(46, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Suma Realizada";
            // 
            // Suma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regresarDesdeSuma);
            this.MaximizeBox = false;
            this.Name = "Suma";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regresarDesdeSuma;
        private System.Windows.Forms.Label label1;
    }
}


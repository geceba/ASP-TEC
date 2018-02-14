namespace Multiplicacion
{
    partial class Multiplicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Multiplicacion));
            this.label1 = new System.Windows.Forms.Label();
            this.regresarDesdeMulti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multiplicación Realizada";
            // 
            // regresarDesdeMulti
            // 
            this.regresarDesdeMulti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("regresarDesdeMulti.BackgroundImage")));
            this.regresarDesdeMulti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regresarDesdeMulti.Location = new System.Drawing.Point(225, 260);
            this.regresarDesdeMulti.Name = "regresarDesdeMulti";
            this.regresarDesdeMulti.Size = new System.Drawing.Size(60, 58);
            this.regresarDesdeMulti.TabIndex = 1;
            this.regresarDesdeMulti.UseVisualStyleBackColor = true;
            this.regresarDesdeMulti.Click += new System.EventHandler(this.regresarDesdeMulti_Click);
            // 
            // Multiplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 317);
            this.Controls.Add(this.regresarDesdeMulti);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Multiplicacion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiplicación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button regresarDesdeMulti;
    }
}


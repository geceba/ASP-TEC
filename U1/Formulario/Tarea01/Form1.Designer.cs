namespace Tarea01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOption = new System.Windows.Forms.Label();
            this.txtBxOption = new System.Windows.Forms.TextBox();
            this.lblTextOption = new System.Windows.Forms.Label();
            this.btnMandarOpcion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitle.Location = new System.Drawing.Point(236, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(173, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Formulario";
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.BackColor = System.Drawing.Color.Transparent;
            this.lblOption.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOption.Location = new System.Drawing.Point(89, 79);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(180, 112);
            this.lblOption.TabIndex = 1;
            this.lblOption.Text = "Opciones:\r\n  1.- Captura de datos\r\n  2.- Suma de datos\r\n  3.- Resta de datos\r\n  4" +
    ".- Multiplacion de datos\r\n  5.- Division de datos\r\n  6.- Resultados";
            // 
            // txtBxOption
            // 
            this.txtBxOption.Location = new System.Drawing.Point(409, 101);
            this.txtBxOption.Name = "txtBxOption";
            this.txtBxOption.Size = new System.Drawing.Size(100, 20);
            this.txtBxOption.TabIndex = 2;
            this.txtBxOption.TextChanged += new System.EventHandler(this.txtBxOption_TextChanged);
            // 
            // lblTextOption
            // 
            this.lblTextOption.AutoSize = true;
            this.lblTextOption.BackColor = System.Drawing.Color.Transparent;
            this.lblTextOption.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTextOption.Location = new System.Drawing.Point(409, 79);
            this.lblTextOption.Name = "lblTextOption";
            this.lblTextOption.Size = new System.Drawing.Size(91, 13);
            this.lblTextOption.TabIndex = 3;
            this.lblTextOption.Text = "Ingrese la opcion:";
            // 
            // btnMandarOpcion
            // 
            this.btnMandarOpcion.BackColor = System.Drawing.Color.Transparent;
            this.btnMandarOpcion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMandarOpcion.BackgroundImage")));
            this.btnMandarOpcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMandarOpcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMandarOpcion.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMandarOpcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMandarOpcion.Location = new System.Drawing.Point(409, 131);
            this.btnMandarOpcion.Name = "btnMandarOpcion";
            this.btnMandarOpcion.Size = new System.Drawing.Size(100, 60);
            this.btnMandarOpcion.TabIndex = 4;
            this.btnMandarOpcion.Text = "Apachúrrame";
            this.btnMandarOpcion.UseVisualStyleBackColor = false;
            this.btnMandarOpcion.Click += new System.EventHandler(this.btnMandarOpcion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 227);
            this.Controls.Add(this.btnMandarOpcion);
            this.Controls.Add(this.lblTextOption);
            this.Controls.Add(this.txtBxOption);
            this.Controls.Add(this.lblOption);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMULARIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOption;
        private System.Windows.Forms.TextBox txtBxOption;
        private System.Windows.Forms.Label lblTextOption;
        private System.Windows.Forms.Button btnMandarOpcion;
    }
}


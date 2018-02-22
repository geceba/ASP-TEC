namespace ArchivosForm
{
    partial class Archivos
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.sueldo = new System.Windows.Forms.Label();
            this.edad = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(131, 88);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(116, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(131, 129);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(116, 20);
            this.txtSueldo.TabIndex = 1;
            this.txtSueldo.TextChanged += new System.EventHandler(this.txtSueldo_TextChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(363, 84);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(118, 20);
            this.txtEdad.TabIndex = 2;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(363, 129);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(118, 20);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(72, 91);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(44, 13);
            this.nombre.TabIndex = 4;
            this.nombre.Text = "Nombre";
            // 
            // sueldo
            // 
            this.sueldo.AutoSize = true;
            this.sueldo.Location = new System.Drawing.Point(72, 132);
            this.sueldo.Name = "sueldo";
            this.sueldo.Size = new System.Drawing.Size(38, 13);
            this.sueldo.TabIndex = 5;
            this.sueldo.Text = "sueldo";
            // 
            // edad
            // 
            this.edad.AutoSize = true;
            this.edad.Location = new System.Drawing.Point(326, 88);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(31, 13);
            this.edad.TabIndex = 6;
            this.edad.Text = "edad";
            // 
            // telefono
            // 
            this.telefono.AutoSize = true;
            this.telefono.Location = new System.Drawing.Point(312, 132);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(45, 13);
            this.telefono.TabIndex = 7;
            this.telefono.Text = "telefono";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(94, 292);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 48);
            this.btn_agregar.TabIndex = 8;
            this.btn_agregar.Text = "Agregar Registro";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(230, 292);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(75, 48);
            this.btn_mostrar.TabIndex = 9;
            this.btn_mostrar.Text = "Mostrar Registro";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(349, 296);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 40);
            this.btn_salir.TabIndex = 10;
            this.btn_salir.Text = "salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Archivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 406);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.sueldo);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtNombre);
            this.Name = "Archivos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label sueldo;
        private System.Windows.Forms.Label edad;
        private System.Windows.Forms.Label telefono;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_salir;
    }
}


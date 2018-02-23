using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivosForm
{
    public partial class Archivos : Form
    {
        string nom;
        decimal sueldo_;
        Int32 edad_;
        string telefono_;
        Int16 c = 0;

        public Archivos()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                nom = Convert.ToString(txtNombre.Text);
            }
            
        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {
            if(txtSueldo.Text != "")
            {
                sueldo_ = Convert.ToDecimal(txtSueldo.Text);
            }
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            if(txtEdad.Text != "")
            {
               edad_ = Convert.ToInt32(txtEdad.Text);
            }
            
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if(txtTelefono.Text != "")
            {
                telefono_ = Convert.ToString(txtTelefono.Text);
            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            //StreamReader file;
            string file = ("C:/Users/gcetzal/Desktop/Agenda.txt");
            string[] reg = File.ReadAllLines(file);
            Int16 contador = Convert.ToInt16(reg.Length/4);

            /*
             * if(c < contador)
             * {
             *     ejecuta
             * } 
             * else 
             * {
             *  MessageBox("Son todas las listas")  ignore el comentario, estaba pensando
             * }
             */
            c++;
            
            if (c <= contador)
            {
                if(c %2 == 0)
                {
                    txtNombre.Text = reg[(c * c)];
                    txtSueldo.Text = reg[(c * c) + 1];
                    txtEdad.Text = reg[(c * c) + 2];
                    txtTelefono.Text = reg[(c * c) + 3];
                }
                
                else {
                    txtNombre.Text = reg[(c * c) - 1];
                    txtSueldo.Text = reg[(c * c)];
                    txtEdad.Text = reg[(c * c) + 1];
                    txtTelefono.Text = reg[(c * c) + 2];
                    
                }
            }
            else
            {
                MessageBox.Show("Lista Completa");
                resetearTextBox();
                c = 0;
            }
            //txtNombre.Text = ""+reg.Length;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            StreamWriter registro;
            registro = new StreamWriter("C:/Users/gcetzal/Desktop/Agenda.txt", true);

         
                registro.WriteLine(nom);
                registro.WriteLine(sueldo_);
                registro.WriteLine(edad_);
                registro.WriteLine(telefono_);

            

            registro.Close();
            resetearTextBox();
        }

        public void resetearTextBox()
        {
            txtNombre.Text = "";
            txtSueldo.Text = "";
            txtTelefono.Text = "";
            txtEdad.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapturaDato
{
    public partial class CapturaDato : Form
    {
        decimal[] opciones = new decimal[3];


        public CapturaDato()
        {
            InitializeComponent();
        }

        
        private void regresarDesdeDatos_Click(object sender, EventArgs e)
        {
            Tarea01.Form1 menuPrincipal = new Tarea01.Form1();
            this.Hide();
            menuPrincipal.recuperar(opciones);
            menuPrincipal.Show();
        }

        private void txtBoxValor1_TextChanged(object sender, EventArgs e)
        {
            if(txtBoxValor1.Text != "")
            {
                opciones[0] = Convert.ToDecimal(txtBoxValor1.Text);
            }
        }

        private void txtBoxValor2_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxValor2.Text != "")
            {
                opciones[1] = Convert.ToDecimal(txtBoxValor2.Text);
            }
        }

        private void txtBoxValor3_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxValor3.Text != "")
            {
                opciones[2] = Convert.ToDecimal(txtBoxValor3.Text);
            }
        }

       
        
    }
}

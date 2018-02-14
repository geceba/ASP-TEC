using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma
{
    public partial class Suma : Form
    {
        bool aux;
        public Suma()
        {
            InitializeComponent();
        }

        private void regresarDesdeSuma_Click(object sender, EventArgs e)
        {
            Tarea01.Form1 menuPrincipal = new Tarea01.Form1();
            this.Hide();
            menuPrincipal.revalidar(aux);
            menuPrincipal.Show();
        }

        public decimal sumar(decimal[] valor)
        {
            decimal resultado = (valor[0] + valor[1] + valor[2]);
            //decimal resultado = (2+2+2);
            return resultado;
        }

        public bool prueba(bool x)
        {
            aux = x;
            return aux;
        }
    }
}

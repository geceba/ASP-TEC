using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resta
{
    public partial class Resta : Form
    {
        public Resta()
        {
            InitializeComponent();
        }

        private void regresarDesdeResta_Click(object sender, EventArgs e)
        {
            Tarea01.Form1 menuPrincipal = new Tarea01.Form1();
            this.Hide();
            menuPrincipal.Show();
        }

        public decimal restar(decimal[] valor)
        {
            decimal resultado = (valor[0] - valor[1] - valor[2]);
            return resultado;
        }
    }
}

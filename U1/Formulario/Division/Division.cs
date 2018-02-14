using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Division
{
    public partial class Division : Form
    {
        public Division()
        {
            InitializeComponent();
        }

        private void regresarDesdeDivision_Click(object sender, EventArgs e)
        {
            Tarea01.Form1 menuPrincipal = new Tarea01.Form1();
            this.Hide();
            menuPrincipal.Show();
        }

        public decimal dividir(decimal[] valor)
        {
            decimal resultado = (valor[0] + valor[1] + valor[2]) / 3;
            return resultado;
        }
    }
}

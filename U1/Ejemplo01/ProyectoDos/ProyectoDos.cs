using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDos
{
    public partial class ProyectoDos : Form
    {
        Int16 a, b, c;
        decimal d;
        Libreria.Libreria o = new Libreria.Libreria();

        public ProyectoDos()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //d = (a + b + c) / 3;
            d = o.calPromedio(a, b, c);
            lblResultado.Text = Convert.ToString(d);
        }

        private void TxBDatoA_TextChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt16(TxBDatoA.Text);
        }

        private void TxBDatoB_TextChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt16(TxBDatoB.Text);
        }

        private void TxBDatoC_TextChanged(object sender, EventArgs e)
        {
            c = Convert.ToInt16(TxBDatoC.Text);
        }
    }
}

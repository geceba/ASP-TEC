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
        Int16 a, b, c, cuantos, contador;
        decimal d, resultadoProm;
        decimal[] guardarProm  = new decimal[10];

        Libreria.Libreria o = new Libreria.Libreria();

        public ProyectoDos()
        {
            InitializeComponent();
            elBueno.Enabled = true;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //d = (a + b + c) / 3;
            d = o.calPromedio(a, b, c);
            lblResultado.Text = Convert.ToString(d);

            contador++;
            guardarProm[contador - 1] = d;

            //lblMensaje.Text = Convert.ToString(""+cuantos);
            if (contador == cuantos)
            {
                resultadoProm = o.calProm(guardarProm, cuantos);
                lblPromProm.Text = "" + resultadoProm;
                lblMensaje.Text = Convert.ToString("Ya son N veces");
            } else
            {
                TxBDatoA.Text = "";
                TxBDatoB.Text = "";
                TxBDatoC.Text = "";
            }

        }

        private void elBueno_TextChanged(object sender, EventArgs e)
        {
            cuantos = Convert.ToInt16(elBueno.Text);
        }

        private void TxBDatoA_TextChanged(object sender, EventArgs e)
        {
            elBueno.Enabled = false;
            if (TxBDatoA.Text!="")
            {
                a = Convert.ToInt16(TxBDatoA.Text);
            }
            
        }

        private void TxtBoxCuantos_TextChanged(object sender, EventArgs e)
        {
            //cuantos = Convert.ToInt16(TxtBoxCuantos.Text);
        }

        private void TxBDatoB_TextChanged(object sender, EventArgs e)
        {
            if (TxBDatoB.Text != "")
            {
                b = Convert.ToInt16(TxBDatoB.Text);
            }
           
        }

        private void TxBDatoC_TextChanged(object sender, EventArgs e)
        {
            if (TxBDatoC.Text != "")
            {
                c = Convert.ToInt16(TxBDatoC.Text);
            }
            
        }
    }
}

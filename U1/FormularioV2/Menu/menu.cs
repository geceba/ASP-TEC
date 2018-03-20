using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class menu : Form
    {
        decimal[] valores = new decimal[3];
        FormularioV2.menu objFormulario = new FormularioV2.menu();
        public menu()
        {
            InitializeComponent();
        }

        private void txtValor_1_TextChanged(object sender, EventArgs e)
        {
            if( txtValor_1.Text != "")
            {
                valores[0] = Convert.ToDecimal(txtValor_1.Text);
            }
        }

        private void txtValor_2_TextChanged(object sender, EventArgs e)
        {
            if (txtValor_2.Text != "")
            {
                valores[1] = Convert.ToDecimal(txtValor_2.Text);
            }
        }

        private void txtValor_3_TextChanged(object sender, EventArgs e)
        {
            if (txtValor_3.Text != "")
            {
                valores[2] = Convert.ToDecimal(txtValor_3.Text);
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Hide();
            objFormulario.recuperarInfo(valores);
            objFormulario.Show();

        }
    }
}

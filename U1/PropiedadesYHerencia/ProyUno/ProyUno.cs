using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyUno
{
    public partial class ProyUno : Form
    {
       
        public ProyUno()
        {
            InitializeComponent();
        }
        //ClaseBase.ClaseBase objuno = new ClaseBase.ClaseBase();
        ClassDerivada.ClassDerivada objuno = new ClassDerivada.ClassDerivada();

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            objuno.pNombre = txtNombre.Text;
        }

        private void txtHrsTrab_TextChanged(object sender, EventArgs e)
        {
            objuno.pHrsTrab = Convert.ToInt16(txtHrsTrab.Text);
        }

        private void txtPagHora_TextChanged(object sender, EventArgs e)
        {
            objuno.pPagHora = Convert.ToDecimal(txtPagHora.Text);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal pagoNormal, sueldoSueldoExt, pagoTotal;
            //Referencia a mi clase base
            
            pagoNormal = objuno.SueldoNormal(objuno.pHrsTrab, objuno.pPagHora);
            lblResultado.Text = Convert.ToString(pagoNormal);

            sueldoSueldoExt = objuno.SueldoExt(objuno.pHrsTrabEx, objuno.pPagHoraEx);
            lblResultadoPagoExtra.Text = Convert.ToString(sueldoSueldoExt);

            pagoTotal = objuno.SueldOTotal(objuno.pHrsTrabEx, objuno.pPagHoraEx);
            lblResultadoPagoTotal.Text = Convert.ToString(pagoTotal);

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            objuno.pApellido = txtApellido.Text;
        }

        private void txtHrsTrabExtra_TextChanged(object sender, EventArgs e)
        {
            objuno.pHrsTrabEx = Convert.ToInt16(txtHrsTrabExtra.Text);
        }

        private void txtPagoExtra_TextChanged(object sender, EventArgs e)
        {
            objuno.pPagHoraEx = Convert.ToDecimal(txtPagoExtra.Text);
        }
    }
}

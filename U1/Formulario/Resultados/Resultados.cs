using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resultados
{
    public partial class Resultados : Form
    {
        
        public Resultados()
        {
            InitializeComponent();
           

        }

        public void algo(decimal a)
        {
           txtBoxSumaResultado.Text = Convert.ToString(a);
        }
        

        private void regresarDesdeResultados_Click(object sender, EventArgs e)
        {
            Tarea01.Form1 menuPrincipal = new Tarea01.Form1();
            this.Hide();
            menuPrincipal.Show();
        }
    }
}

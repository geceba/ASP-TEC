using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto03
{
    public partial class Form1 : Form
    {
        decimal[] Copia = new decimal[10];
        decimal Respuesta;
        Int16 CopiaDos = 0, undefined = 0;
        Libreria.Libreria app = new Libreria.Libreria();
        public Form1()
        {
            InitializeComponent();
            TxBPromProms.Enabled = false;
        }

        private void btnDesplegar_Click(object sender, EventArgs e)
        {
            //Necesito llamar el metodo para calcular el promedio de promedios,
            //obtener ese dato y desplegarlo
            //No conozco el vector
            //Necesito el metodo donde se reciba la infomracion del vector


            Respuesta = app.calProm(Copia, undefined);
            TxBPromProms.Text = Convert.ToString(Respuesta);

        }
        public void recibe(decimal[] aux, Int16 numero)
        {
            for(Int16 i=0; i <numero; i++)
            {
                //Copiar los valores de aux a un vector local
                Copia[i] = aux[i];
            }
            undefined = numero;
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Ir a preyectoDos
            //DEFINO MI OBJETO PARA LLAMAR A PROYECTO DOS DE FORMA LOCAL
            ProyectoDos.ProyectoDos objeto = new ProyectoDos.ProyectoDos();
            this.Hide();
            objeto.Show();
        }
    }
}

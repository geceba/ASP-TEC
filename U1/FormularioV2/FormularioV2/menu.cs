using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioV2
{
    public partial class menu : Form
    {
        Int16 opcion;
        decimal[] recuperado = new decimal[3];
        decimal[] respuesta = new decimal[5];
        decimal sum = 0, resta = 0, multi = 0, div = 0;
        bool band1 = false, band2 = false, band3 = false, band4 = false;
        public menu()
        {
            InitializeComponent();
        }

        private void txtOpcion_TextChanged(object sender, EventArgs e)
        {
            if(txtOpcion.Text != "")
            {
                opcion = Convert.ToInt16(txtOpcion.Text);
            }
        }

       
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Menu.menu objMenu = new Menu.menu();
            switch (opcion)
            {
                case 1:
                    this.Hide();
                    objMenu.Show();
                    break;
                case 2:
                    MessageBox.Show("Suma realizada");
                    band1 = true;
                    respuesta[0] = suma(recuperado, band1);
                    break;
                case 3:
                    MessageBox.Show("Resta realzada");
                    band2 = true;
                    respuesta[1] = restita(recuperado, band2);
                    
                    break;
                case 4:
                    MessageBox.Show("Multiplicacion realizada");
                    band3 = true;
                    respuesta[2] = multiplicacion(recuperado, band3);
                    
                    break;
                case 5:
                    MessageBox.Show("Division realizada");
                    band4 = true;
                    break;
                case 6:
                    break;
                default:
                    txtOpcion.Text = "";
                    //Aqui se imprime las respuesta guardadas en el arreglo
                    MessageBox.Show("Querido Usuario lea las opciones");
                    break;
            }
        }


        public decimal[] recuperarInfo(decimal[] algunValor)
        {
            for(Int16 i = 0; i < algunValor.Length; i++)
            {
                recuperado[i] = algunValor[1];
            }

            return recuperado;
        }

        public decimal suma(decimal[] arraySuma, bool band)
        {
            if(band == true)
            {
                for (Int16 i = 0; i < arraySuma.Length; i++)
                {
                    sum += arraySuma[i];
                }
            }
            else
            {
                sum = 0;
            }
            
            return sum;
        }

        public decimal restita(decimal[] arrayResta, bool band)
        {
            if(band == true)
            {
                for (Int16 i = 0; i < arrayResta.Length; i++)
                {
                    resta -= arrayResta[i];
                }
            }
            else
            {
                resta = 0;
            }
            
            return resta;
        }

        public decimal multiplicacion(decimal[] arrayMulti, bool band)
        {
            if(band == true)
            {
                for (Int16 i = 0; i < arrayMulti.Length; i++)
                {
                    multi *= arrayMulti[i];
                }
            }
            else
            {
                multi = 0;
            }
            
            return multi;
        }
    }
}

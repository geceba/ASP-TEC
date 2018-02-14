using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea01
{
    public partial class Form1 : Form
    {
        Int16 Option;
        decimal[] search = new decimal[3];
        decimal[] forzar = new decimal[3];
        bool bandSuma = false, bandResta = false, bandMulti = false, bandDivision = false;
        bool bandSuma2 = false, bandResta2 = false, bandMulti2 = false, bandDivision2 = false;
        decimal sumar = 0, restar = 0, multiplicar = 0, dividir = 0, TRATA;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtBxOption_TextChanged(object sender, EventArgs e)
        {
            if (txtBxOption.Text != "")
            {
                Option = Convert.ToInt16(txtBxOption.Text);
            }
            
        }

        private void btnMandarOpcion_Click(object sender, EventArgs e)
        {
            CapturaDato.CapturaDato obj = new CapturaDato.CapturaDato();
            
         
            switch (Option)
            {
                case 1:
                    CapturaDato.CapturaDato capturaDato = new CapturaDato.CapturaDato();
                    this.Hide();      
                    capturaDato.Show();
                    break;

                case 2:
                    Suma.Suma suma = new Suma.Suma();
                    this.Hide();
                    // sumar = suma.sumar(search);
                    
                    bandSuma = suma.prueba(true);
                    //MessageBox.Show("" + bandSuma);
                    suma.Show();
                    break;

                case 3:
                    Resta.Resta resta = new Resta.Resta();
                    this.Hide();
                    resta.restar(search);
                    resta.Show();
                    break;

                case 4:
                    Multiplicacion.Multiplicacion multi = new Multiplicacion.Multiplicacion();
                    this.Hide();
                    multi.multiplicar(search);
                    multi.Show();
                    break;

                case 5:
                    Division.Division division = new Division.Division();
                    this.Hide();
                    division.dividir(search);
                    division.Show();
                    break;

                case 6:
                    Resultados.Resultados result = new Resultados.Resultados();
                    Suma.Suma objsumar = new Suma.Suma();
                    this.Hide();
                    TRATA = objsumar.sumar(search);
                    MessageBox.Show(""+forzar[0]);
                    
                    sumar = bandSuma ? 3 : 2;                   
                    result.algo(sumar);
                    result.Show();
                    break;

                default:
                    txtBxOption.Text = "";
                    MessageBox.Show("Querido Usuario... LEA LAS OPCIONES");
                    break;
            }
        }

        public decimal[] recuperar(decimal[] algunValor)
        {
            
            for(Int16 i = 0; i<3; i++)
            {
                search[i] = algunValor[i];
            }
            Array.Copy(search, forzar, 3);
            MessageBox.Show(""+forzar[0] + forzar[1]+forzar[2]);
            
            return search;
        }

        public bool revalidar(bool algo)
        {
            bandSuma = algo;
            return bandSuma2;
        }

    }
}

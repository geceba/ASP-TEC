using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
    public class ClaseBase
    {
        //Definir las propiedades de mis atributos
        //Atrubuto Nombre
        //No debe ser accesible mas que por su propiedad
        private string nombre;
        private decimal PagHora;
        private Int16 HrsTrab;
        //Defino la prpiedad para el atributo nombre
        public string pNombre
        {
            get //Obtener imprimir desplegar
            {
                return nombre;
            }
            set //poner, capturar o leer
            {
                nombre = value;
            }
        }

        public decimal pPagHora
        {
            get
            {
                return PagHora;
            }
            set
            {
                PagHora = value;
            }
        }

        public Int16 pHrsTrab
        {
            get
            {
                return HrsTrab;
            }
            set
            {
                HrsTrab = value;
            }
        }

        public decimal SueldoNormal(Int16 a, decimal b)
        {
            decimal sn;
            sn = a * b;
            return sn;
        }
    }
}

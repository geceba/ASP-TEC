using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDerivada
{
    public class ClassDerivada : ClaseBase.ClaseBase
    {
        //Definir las propiedades de mis atributos
        //Atrubuto Nombre
        //No debe ser accesible mas que por su propiedad
        private string apellido;
        private decimal PagHoraEx;
        private Int16 HrsTrabEx;
        //Defino la prpiedad para el atributo nombre
        public string pApellido
        {
            get //Obtener imprimir desplegar
            {
                return apellido;
            }
            set //poner, capturar o leer
            {
                apellido = value;
            }
        }

        public decimal pPagHoraEx
        {
            get
            {
                return PagHoraEx;
            }
            set
            {
                PagHoraEx = value;
            }
        }

        public Int16 pHrsTrabEx
        {
            get
            {
                return HrsTrabEx;
            }
            set
            {
                HrsTrabEx = value;
            }
        }

        public decimal SueldoExt(Int16 a, decimal b)
        {
            decimal sn;
            sn = a * b;
            return sn;
        }
        public decimal SueldOTotal(Int16 a, decimal b)
        {
            decimal sn;
            sn = (pHrsTrab * pPagHora) + (a * b);
            return sn;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Libreria
    {
        public decimal calPromedio(Int16 x, Int16 y, Int16 z)
        {
            decimal w;
            w = (x + y + z) / 3;
            return w;
        }

        public void resultadoProm(decimal v)
        {
            Console.Write("");
            Console.WriteLine(v);
        }
        public decimal calProm(decimal[] m, Int16 k)
        {
            decimal resp=0;

            for (Int16 i=0; i< k; i++)
            {
                resp += m[i];
            }
            resp = resp / k;

            return resp;
        }

        public void mostrarPromProm(decimal calc)
        {
            Console.WriteLine("El promedio de los promedios es: {0} ", calc);
            //Console.Write(calc);
        }
    }
}

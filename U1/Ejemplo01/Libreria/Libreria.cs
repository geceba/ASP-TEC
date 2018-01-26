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
    }
}

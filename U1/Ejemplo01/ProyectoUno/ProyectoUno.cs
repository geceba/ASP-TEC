using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUno
{
    class ProyectoUno
    {
        /*decimal calPromedio(Int16 x, Int16 y, Int16 z)
        {
            decimal w;
            w = (x + y + z) / 3;
            return w;
        }

        void resultadoProm(decimal v)
        {
            Console.Write("");
            Console.WriteLine(v);
        }
        */
        static void Main(string[] args)
        {
            Int16 a, b, c;
            Int16 cantidad;
            decimal d;
            String e;

            Libreria.Libreria obj = new Libreria.Libreria();
            //Entrada de datos

            Console.WriteLine("Cuantas veces quieres repetir");
            cantidad = Convert.ToInt16(Console.ReadLine());

            for (Int16 i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingresa el valor de a: ");
                a = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Ingresa el valor de b: ");
                b = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Ingresa el valor de c: ");
                c = Convert.ToInt16(Console.ReadLine());

                d = obj.calPromedio(a, b, c);
                obj.resultadoProm(d);

                Console.ReadLine();
            }

            
        }
    }
}

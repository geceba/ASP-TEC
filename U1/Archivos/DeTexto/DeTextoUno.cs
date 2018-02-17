using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace DeTexto
{
    class DeTextoUno
    {
        //Atributos
        String nombre;
        decimal sueldo;
        Int16 edad;
        String telefono;
        

        public void EscribeDatos()
        {
            Int16 ciclo, cantidad;

            //Generar el archivo
            StreamWriter registro;
            registro = new StreamWriter("C:/Users/gcetzal/Desktop/Agenda.txt", true);

            Console.WriteLine("Cuantas veces");
            cantidad = Convert.ToInt16(Console.ReadLine());

            for (ciclo = 0; ciclo < cantidad; ciclo++)
            {
                Console.WriteLine("Nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("Sueldo");
                sueldo = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Edad");
                edad = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Telefono");
                telefono = Console.ReadLine();

                //3 .- Grabar
                registro.WriteLine(nombre);
                registro.WriteLine(sueldo);
                registro.WriteLine(edad);
                registro.WriteLine(telefono);

            }
            registro.Close();
        }

        public void leeDatos()
        {
            StreamReader sr = new StreamReader("C:/Users/gcetzal/Desktop/Agenda.txt");
            String sLine = "";
            ArrayList arrText = new ArrayList();

            while (sLine != null)
            {
                sLine = sr.ReadLine();
                if (sLine != null)
                arrText.Add(sLine);
            }

            sr.Close();
            
            foreach(string sOutput in arrText)
            
            Console.WriteLine(sOutput);
            Console.ReadLine();
            

        }
        public void escribeBinario()
        {
            Int16 ciclo, cantidad;

            //Generar el archivo
            Stream registro;
            registro = File.Open("C:/Users/gcetzal/Desktop/Agenda2.bin", FileMode.Append, FileAccess.Write);

            BinaryWriter Dato = new BinaryWriter(registro);

            Console.WriteLine("Cuantas veces");
            cantidad = Convert.ToInt16(Console.ReadLine());

            for (ciclo = 0; ciclo < cantidad; ciclo++)
            {
                Console.WriteLine("Nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("Sueldo");
                sueldo = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Edad");
                edad = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Telefono");
                telefono = Console.ReadLine();

                //3 .- Grabar
                Dato.Write(nombre);
                Dato.Write(sueldo);
                Dato.Write(edad);
                Dato.Write(telefono);

            }
            registro.Close();
        }
        public void leeBinario()
        {
            Stream registro;
            registro = File.Open("C:/Users/gcetzal/Desktop/Agenda2.bin", FileMode.Open, FileAccess.Read);

            BinaryReader Dato = new BinaryReader(registro);

            do
            {
                //Grabar
                nombre = Dato.ReadString();
                Console.WriteLine("Nombre:{0}", nombre);
                sueldo = Dato.ReadDecimal();
                Console.WriteLine("Sueldo_{0}", sueldo);
                edad = Dato.ReadInt16();
                Console.WriteLine("Edad:{0}", edad);
                telefono = Dato.ReadString();
                Console.WriteLine("Telefono:{0}", telefono);
                Console.ReadLine();

            } while (Dato.PeekChar()!=-1);

            registro.Close();
        }

        static void Main(string[] args)
        {
            DeTextoUno obj = new DeTextoUno();
            //obj.leeDatos();
            obj.leeBinario();
        }
    }
}

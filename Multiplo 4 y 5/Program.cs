using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Multiplo_4_y_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplo3;
            int multiplo5;
            int total = 0;
            int x;
            string linea;
            int numero;

            multiplo3 = 0;
            multiplo5 = 0;

            Console.Write("Selecciona la cantidad de numeros a ingresar: ");
            total = int.Parse(Console.ReadLine());


            for (x = 1; x <= total; x++)
            {
                Console.Write("Ingresa un numero: ");
                linea = Console.ReadLine();
                numero = int.Parse(linea);
                if (numero % 3 == 0)
                {
                    multiplo3 = multiplo3 + 1;
                }
                
                if (numero % 5 == 0)
                    {
                     multiplo5 = multiplo5 + 1;

                    }
                

            }
            Console.WriteLine("Multiplos de 3");
            Console.WriteLine(multiplo3);
            Console.WriteLine("Multiplos de 5");
            Console.WriteLine(multiplo5);
            Console.ReadKey();

        }
    }
}

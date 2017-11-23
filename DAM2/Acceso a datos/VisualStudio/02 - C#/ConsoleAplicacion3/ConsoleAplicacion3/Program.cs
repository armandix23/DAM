using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAplicacion3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tabla = { 12, 23, 34, 5 };

            for (int i = 0; i < tabla.Length; i++)
            {
                Console.WriteLine(tabla[i]);
            }
            Console.ReadKey();

            //Operadores sobre tipos
            if((3 / 7) is System.Int32)
            {
                Console.WriteLine("Es de tipo entero");
            }
            else
            {
                Console.WriteLine("No es de tipo entero");
            }
            Console.ReadKey();
        }
    }
}

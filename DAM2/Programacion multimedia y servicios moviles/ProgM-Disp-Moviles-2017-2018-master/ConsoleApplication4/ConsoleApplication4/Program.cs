using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Fecha f1 = new Fecha(10,2,2017),
                  f2 = new Fecha(12, 2, 2017);

            Console.WriteLine(12 + " " + 23);
            Console.WriteLine("{0} {1}", 12, 23);

            // Fecha bisiesta, aumentar el mes, numero días desde 1/1
            // 3 Fechas, leerlas por pantalla, escribir la menor.
        }
    }
}

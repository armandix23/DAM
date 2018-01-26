using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationFechas
{
    class Program
    {
        static void Main(string[] args)
        {
            Fecha f1 = new Fecha(30, 12, 2016 ),
                  f2 = new Fecha(3, 07, 2017),
                  f3 = new Fecha(2, 12, 2017),
                  f4 = new Fecha(12, 1, 2017);

            f1.dia

            if (f1.EsMayor(f2) && f1.EsMayor(f3) && f1.EsMayor(f4))
                Console.WriteLine(f1.Escribe());
            else
                if ((f2.EsMayor(f3) && f2.EsMayor(f4)))
                   Console.WriteLine(f2.Escribe());
                else
                   if (f3.EsMayor(f4))
                       Console.WriteLine(f3.Escribe());
                   else
                       Console.WriteLine(f4.Escribe());

           

            Console.WriteLine("Dia de " + f1.Escribe() + " son " +
                              f1.ContarDias());

            Console.ReadKey();


        }
    }
}

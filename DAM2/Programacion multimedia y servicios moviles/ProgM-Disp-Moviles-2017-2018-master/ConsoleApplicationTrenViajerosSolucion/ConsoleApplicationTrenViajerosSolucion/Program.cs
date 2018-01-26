using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTrenViajerosSolucion
{
    class Program
    {
        static void Main(string[] args)
        {
            Tren miTren = new Tren();
            int nVagon, nAsiento, nMaletas;
            string clase, destino;

            do
            {
                Billete b = new Billete();

                Console.WriteLine("Introduce vagon:");
                nVagon = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduce asiento:");
                nAsiento = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduce clase:");
                clase = Console.ReadLine();
                Console.WriteLine("Introduce destino:");
                destino = Console.ReadLine();
                Console.WriteLine("Introduce nº maletas:");
                nMaletas = Int32.Parse(Console.ReadLine());
                if (nVagon != -100)
                {
                    miTren.GetVagon(nVagon).
                           GetBillete(nAsiento).
                           Modificar(clase, destino, nMaletas);
                }
            } while (nVagon != -100);

            // 1. Cambiar a preferente los 5 primeros asientos 
            //    vagon 0
            miTren.GetVagon(0).GetBillete(0).SetClase("preferente");
            miTren.GetVagon(0).GetBillete(1).SetClase("preferente");
            miTren.GetVagon(0).GetBillete(2).SetClase("preferente");
            miTren.GetVagon(0).GetBillete(3).SetClase("preferente");

            // 2. Revisar asientos de los dos último vagones
            miTren.Revisar(2);
            miTren.Revisar(3);

            // 3. Escribir cantidad de maletas de cada vagón
            for (int i = 0; i < 4; i++)
                Console.WriteLine("Vagon {0} - Maletas {1}", i + 1,
                                  miTren.NMaletas(i));

            Console.ReadKey();
        }
    }
}

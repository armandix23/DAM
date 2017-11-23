using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNombres
{
    class Program
    {
        static void Main(string[] args)
        {
            String [] nombres = { "Andres","Zara","Jose", "Luis", "Marcos"};

            // Crear un atributo llamado orderList para guarcar los nombre ordenadamente. 
            var orderList = new List<string>();
            orderList.AddRange(nombres);

            Console.WriteLine("Lista no ordenada");
            for (int i = 0; i < nombres.Length; i++)
              {
                  Console.WriteLine(nombres[i]);
              }
            Console.WriteLine();

            orderList.Sort();
            Console.WriteLine("Lista Ordenada");
            foreach (var lista in orderList)
            {
                Console.WriteLine(lista);
            }
            Console.ReadKey();
        }
    }
}

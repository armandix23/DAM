using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static public void OrdenarTabla()
        {
            string[] lista = { "Pepe", "Raul","Carlos Rodrigo",
                               "Alberto",
                               "David","Ana", "Juan",
                               "Carlos Alberto"};

            for(int i=0;i<lista.Length-1;i++)
            {
                for(int j=0;j<(lista.Length-1)-i;j++)
                {
                    if ( lista[j].CompareTo(lista[j+1]) > 0 )
                    {
                        // Intercambiar j --> j+1
                        string aux;
                        aux = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = aux;
                    }
                }
            }
            foreach(string nombre in lista)
            {
                Console.WriteLine(nombre);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            OrdenarTabla();

            int[] tabla = { 11, 22, 33, 44 };
            int numero2;

            for(int i=0;i<4;i++)
            {
                numero2 = tabla[i];
                Console.WriteLine(tabla[i]);
            }
            Console.ReadKey();

            foreach(int numero in tabla)
            {
                Console.WriteLine(numero);
            }

            if ( (3.0 / 7) is System.Int32 )
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

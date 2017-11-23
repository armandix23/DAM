using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromos
{
    class Program
    {
        static bool esPalindromo(string cadena)
        {
            int i, j;
            bool iguales = true;

            i = 0;
            j = cadena.Length - 1;
            while (iguales && (i<j))
            {
                if (cadena[i] == cadena[j])
                    iguales = true;
                else
                    iguales = false;
                i++;
                j--;
            }
            return iguales;
        }
        static void Main(string[] args)
        {
            string cadena;
            Console.WriteLine("Introduce cadena: ");
            cadena = Console.ReadLine();

            if(esPalindromo(cadena))
                Console.WriteLine("Es un palindromo");
            else
                Console.WriteLine("La cadena no es un palindromo");
            
            Console.ReadKey();

        }   
    }
}

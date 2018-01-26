using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationPalindromoSolucion
{
    class Program
    {
        static bool EsPalindromo(string cadena)
        {
            int i, j;
            bool iguales = true;

            i = 0;
            j = cadena.Length - 1;
            while ( iguales && (i<j) )
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

        static bool EsPalindromo2(string cadena)
        {
            string reves = "";

            reves = cadena.Reverse();

            for (int i = 0; i < cadena.Length; i++)
            {
                reves = cadena[i] + reves;
            }
            if (cadena == reves)
                return true;
            else
                return false;
        }


        static void Main(string[] args)
        {
            string cadena;
            Console.WriteLine("Introduce cadena: ");
            cadena = Console.ReadLine();
            if (EsPalindromo2(cadena))
                Console.WriteLine("La cadena es un palíndromo");
            else
                Console.WriteLine("La cadena no es un palíndromo");
            Console.ReadKey();

            Persona p = new Persona();

            p.setNombre("Pepe");
            p.Nombre = "Pepe"; 

            if ( p.Nombre == "Casa")




        }
    }
}

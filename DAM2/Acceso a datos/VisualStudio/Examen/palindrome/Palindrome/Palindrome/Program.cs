using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    /*
     Crear un programa que lea una frase por pantalla y determine si la frase se trata de un palindromo.
    */
    class Program
    {
        const int palindromo = 1;
        const int nopalindromo = 0;
        
        // Aqui se comprueba las letras desde el inicio hasta el final
        static int verificar(int pos, char[] palabra, int longitud)
        {
            if(palabra[pos] == palabra[longitud -pos -1])
                {
                    if (pos < longitud - pos)
                     {
                        return (verificar(++pos, palabra, longitud));
                     }
                     else
                    {
                        return (palindromo);
                    }
             }
            return (nopalindromo);
        }
        static void Main(string[] args)
        {
            char[] caracteres;
            Console.WriteLine("Introduzca una palabra: ");
            string s = Console.ReadLine();
            caracteres = new char[s.Length];
            caracteres = s.ToCharArray(0, s.Length);

            if (verificar(0, caracteres, s.Length) == palindromo)
            {
                Console.WriteLine("la palabra es un palindromo.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("La palabra no es un palindromo");
                Console.ReadKey();
            }
        }
    }
}

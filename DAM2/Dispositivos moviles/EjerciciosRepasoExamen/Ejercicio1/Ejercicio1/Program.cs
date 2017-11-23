using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Programa que lea una cadena y un nº.
// Añada en la posicion del numero "HOLA"
// cad ="pepito" y nº2 -> pepHOLAito
namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra, nueva = "";
            int num;
            Console.WriteLine("Palabra");
            palabra = Console.ReadLine();
            Console.WriteLine("Numero");
            num = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
                nueva += palabra[i];

            nueva += "hola";

            for (int i = num; i < palabra.Length; i++)
                nueva += palabra[i];

            Console.WriteLine(nueva);
            Console.ReadKey();

        }

      }

}
    


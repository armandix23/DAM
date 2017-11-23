using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationMetodos
{
    class Program
    {
        // Crear un metodo con una variable
        static public int Sumar(ref int n1, int n2)
        {
            int res;
            res = n1 + n2;
            n1 = 10000;
            return n1 + n2;
        }

        static void SumarRef(int n1, int n2, ref int sum)
        {
            sum = n1 + n2;
        }

        static void SumarOut(int n1, int n2, out int sum)
        {
            sum = n1 + n2;
        }

        static void Main(string[] args)
        {
            //Crear dos variables
            int numero1, numero2, resultado; ;

            Console.WriteLine("Introduce numero 1: ");
            //Convertir la cadena en entero (parse convierte en lo que tu pidas)
            numero1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce numero 2: ");
            numero2 = Int32.Parse(Console.ReadLine());

            // 1. Llamada Tradicional
            //resultado = Sumar(ref numero1, numero2);
            //Console.WriteLine("La suma es: " + resultado);
            //Console.WriteLine("El numero 1 es: " + numero1);
            //Console.ReadKey();

           // resultado = 0;

            // 2. Llamada con ref
           // SumarRef(numero1, numero2, ref resultado);
           // Console.WriteLine("La suma es: " + resultado);
           // Console.WriteLine("El numero 1 es: " + numero1);
          //  Console.ReadKey();

            // 3. Llamada con out
            SumarOut(numero1, numero2, out resultado);
            Console.WriteLine("La suma es: " + resultado);
            Console.WriteLine("El numero 1 es: " + numero1);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationDelegados
{
    class Program
    {
        // En la declaración del delegado se define:
        //    - El valor de retorno
        //    - Los parámetros de la función
        delegate void PunteroFuncionConStringNumero(string nombre, int numero);

        delegate void PunteroFuncionConString(string nombre);

        static void EscribeNombre(string nom, int numero)
        {
            for (int i = 0; i < numero; i++)
                Console.WriteLine(nom);
        }
        static void EscribeMayus(string nom)
        {
            Console.WriteLine(nom.ToUpper());
        }
        static void EscribeMinus(string nom)
        {
            Console.WriteLine(nom.ToLower());
        }
        static void EscribeNormal(string nom)
        {
            Console.WriteLine(nom);
        }

        static void Main(string[] args)
        {
            // 1. Puntero a función y llamada 
            PunteroFuncionConStringNumero pFuncion1 = new PunteroFuncionConStringNumero(EscribeNombre);
            pFuncion1("Pepe", 10);
            Console.ReadKey();

            // 2. Array de punteros a funciones 
            PunteroFuncionConString[] tabla = new PunteroFuncionConString[3];
            tabla[0] = new PunteroFuncionConString(EscribeMayus);
            tabla[1] = new PunteroFuncionConString(EscribeMinus);
            tabla[2] = new PunteroFuncionConString(EscribeNormal);

            for (int i = 0; i < tabla.Length; i++)
                tabla[i]("Pepito");
            Console.ReadKey();
        }
    }
}

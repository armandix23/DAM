using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1º) Suma" + "\n" 
                        + "2º) Resta" + "\n" 
                        + "3º) Multiplicación" + "\n" 
                        + "4º) División" + "\n");

            Console.Write("Seleccione una opción: ");

            switch (Console.Read())
            {
                case '1':
                    Console.Write("Suma..");
                    // Continuar lógica y extraer métodos //
                    break;
                case '2':
                    Console.Write("Resta..");
                    // Continuar lógica y extraer métodos //
                    break;
                case '3':
                    Console.Write("Multiplicación..");
                    // Continuar lógica y extraer métodos //
                    break;
                case '4':
                    Console.Write("División..");
                    // Continuar lógica y extraer métodos //
                    break;
            }
            Console.ReadKey();
        }
    }
}

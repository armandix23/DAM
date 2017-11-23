using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationFormasdeOperar
{
    class Program
    {
        public static int menu()
        {
            int numElegido = 0;

            Console.WriteLine("1.- Parametro de tipo real y que devuelve el numero sin decimales" + "\n");
            Console.WriteLine("2.- Parametro de tipo real y otro  entero. Se almacena sobre el segundo parámetro " + "\n");
            Console.WriteLine("3.- Parametro de tipo real. Dara el mismo numero sobreescribido" + "\n");
            Console.WriteLine("4.- Parametro de tipo real , otro  entero y devuelve el numero de decimales del entero" + "\n");
            Console.WriteLine("5.- Tipo real, otro entero, y otro real,  almacena sobre el tercer parametro  los decimales indicados por el segundo." + "\n");
            Console.WriteLine("6.- Tipo real, y otro entero. Almacena sobre el real los decimales indicados por el segundo parametro" + "\n");
            Console.WriteLine("9.- Salir del programa" + "\n");

            numElegido = Int32.Parse(Console.ReadLine());

            return numElegido;
        }
        //************************************************************************//
        //************************************************************************//
        // Entre comentarios pongo otra opcion , sin llegar a utilizar Math.      //
        //************************************************************************//
        //************************************************************************//
        
        public static double Ejercicio1(ref double num1)
        {
            return num1 = Math.Truncate(num1);
            /*
             * int conversion = Convert.ToInt32(num1);
             * return conversion;
             */
        }

        public static void Ejercicio2(double num1, ref int num)
        {
            num1 = Math.Truncate(num1);
            num += Convert.ToInt32(num1);

            /*
             * num = (int)num1;
             * return num;
             */

        }
        public static void Ejercicio3(ref double num1)
        {
            num1 = Math.Truncate(num1);

            /*
             return double(num1)
             */
        }

        public static double Ejercicio4(double num1, int num)
        {
            return Math.Round(num1, num);
            /*
             num = 2;
             num1 = Math.Round(num1, num);
             Console.WriteLine(num1);             
             */

        }
        public static void Ejercicio5(double num1, int num, ref double caja)
        {
            caja += Math.Round(num1, num);

            /*
             num = 2;
             caja = Math.Round(num1, num);
             return caja;
            */
        }

        public static void Ejercicio6(ref double num1, int num)
        {
            num1 += Math.Round(num1, num);

            /*
             num = 2;
             num1 = Math.Round(num1, num);
             return num1;
             */
        }
        static void Main(string[] args)
        {
            int opcion; // Elegir opcion del menu
            double numero = 764.784, caja = 0; ; // numero por defecto. // Caja para almacenar valores
            int decimales = 2; // Decimales que queremos quitar

            do
            {
                opcion = menu();
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Ejercicio1(ref numero);
                        Console.WriteLine(numero + "\n");
                        break;

                    case 2:
                        Console.Clear();
                        Ejercicio2(numero, ref decimales);
                        Console.WriteLine(decimales + "\n");
                        break;

                    case 3:
                        Console.Clear();
                        Ejercicio3(ref numero);
                        Console.WriteLine(numero + "\n");
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine(Ejercicio4(numero, decimales) + "\n");
                        break;

                    case 5:
                        Console.Clear();
                        Ejercicio5(numero, decimales, ref caja);
                        Console.WriteLine(caja + "\n");
                        break;

                    case 6:
                        Console.Clear();
                        Ejercicio6(ref numero, decimales);
                        Console.WriteLine(numero + "\n");
                        break;
                }
            } while (opcion != 9);

        }
    }
}

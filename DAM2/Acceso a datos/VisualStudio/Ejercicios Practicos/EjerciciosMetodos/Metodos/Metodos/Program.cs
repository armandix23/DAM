using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    {
        public static int menu()
        {
            int numero = 0;
            Console.WriteLine("Menu" + "\n");
            Console.WriteLine("1. Un parámetro de tipo real y devuelve el número tras truncar la parte decimal a 0 decimales.");
            Console.WriteLine("2. Un parámetro de tipo real y otro parámetro de tipo entero. El método almacena sobre el segundo parámetro el número tras truncar la parte decimal a 0 decimales.");
            Console.WriteLine("3. Un parámetro de tipo real. El método almacena sobre el primer parámetro el número tras truncar la parte decimal a 0 decimales");
            Console.WriteLine("4. Un parámetro de tipo real y otro parámetro de tipo entero y devuelve el número tras truncar la parte decimal a los decimales indicado por el segundo parámetro.");
            Console.WriteLine("5. Un parámetro de tipo real, otro parámetro de tipo entero y otro parámetro de tipo real. El método almacena sobre el tercer parámetro el número tras truncar la parte decimal a los decimales indicado por el segundo parámetro");
            Console.WriteLine("6. Un parámetro de tipo real y otro parámetro de tipo entero. Almacena sobre el primer parámetro el número tras truncar la parte decimal a los decimales indicado por el segundo parámetro");
            Console.WriteLine("\n");
            numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }

        static public double metodo1(ref double nume1)
        {
            return nume1 = Math.Truncate(nume1);
        }

        static public void metodo2(double nume1, ref int num)
        {
            nume1 = Math.Truncate(nume1);
            num += Convert.ToInt32(nume1);
        }

        static public void metodo3(ref double nume1)
        {
            nume1 = Math.Truncate(nume1);
        }

        static public void metodo4(double nume1, ref double pru)
        {
            pru = Math.Round(nume1, 2);
        }

        static public void metodo5(double nume1, int num, ref double pru)
        { 
            pru += Math.Round(nume1, num);
        }

        static public void metodo6(double nume1, int num)
        {
            nume1 += Math.Round(nume1, num);
        }

        static void Main(string[] args)
        {
            int option;
            int num = 2;
            double numero = 764.783, pru = 0;

            do
            {
                option = menu();
                
                switch (option)
                {
                    case 1:
                        metodo1(ref numero);
                        Console.WriteLine(numero + "\n");
                        break;
                    case 2:
                        metodo2(numero, ref num);
                        Console.WriteLine(num + "\n");
                        break;
                    case 3:
                       metodo3(ref numero);
                        Console.WriteLine(numero + "\n");
                        break;
                    case 4:
                       metodo4(numero, ref pru);
                        Console.WriteLine(pru);
                        break;
                    case 5:
                       metodo5(numero, num , ref pru);
                        Console.WriteLine(pru);
                        break;
                    case 6:
                       metodo6(numero, num);
                        Console.WriteLine(numero);
                        break;
                }
            } while (option != 7);
        }
    }
}

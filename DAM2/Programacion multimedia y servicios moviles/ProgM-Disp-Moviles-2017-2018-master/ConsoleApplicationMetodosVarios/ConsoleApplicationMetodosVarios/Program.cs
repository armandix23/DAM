using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationMetodosVarios
{
    class Program
    {

        static public int MostrarOpciones()
        {
            Console.WriteLine("OPCIONES");
            Console.WriteLine("1. Truncar v1");
            Console.WriteLine("2. Truncar v2");
            Console.WriteLine("3. Truncar v3");
            Console.WriteLine("4. Truncar v4");
            Console.WriteLine("5. Truncar v5");
            Console.WriteLine("6. Truncar v6");
            Console.WriteLine("7. Salir");
            return Int32.Parse(Console.ReadLine());
        }

        static public int Truncar(double numero)
        {
            int numEntero = 0,
                pesoCifra = 1;
            do
            {
                numEntero = ((((int)numero) % 10) * pesoCifra) + numEntero;
                pesoCifra *= 10;
                numero /= 10;
            } while ( ((int)numero) != 0);
            return numEntero;
        }

        static public void Truncar(double numero,ref int numEntero)
        {
            int pesoCifra = 1;

            numEntero = 0;
            do
            {
                numEntero = ((((int)numero) % 10) * pesoCifra) + numEntero;
                pesoCifra *= 10;
                numero /= 10;
            } while (((int)numero) != 0);
        }

        static public void Truncar(ref double numero)
        {
            int numEntero = 0,
                pesoCifra = 1;

            do
            {
                numEntero = ((((int)numero) % 10) * pesoCifra) + numEntero;
                pesoCifra *= 10;
                numero /= 10;
            } while (((int)numero) != 0);
            numero = numEntero;
        }

        static public double TruncarDecimales(double numero,int cantidad)
        {
            int pesoCifra = 1;

            for (int i = 1; i <= cantidad; i++)
                pesoCifra *= 10;
            numero = numero * pesoCifra;
            numero = Truncar(numero);
            numero = numero / pesoCifra;
            return numero;
        }

        static public void TruncarDecimales(double numero, int cantidad,ref double numeroT)
        {
            int pesoCifra = 1;

            for (int i = 1; i <= cantidad; i++)
                pesoCifra *= 10;
            numero = numero * pesoCifra;
            numero = Truncar(numero);
            numeroT = numero / pesoCifra;
        }

        static public void TruncarDecimales(ref double numero, int cantidad)
        {
            int pesoCifra = 1;

            for (int i = 1; i <= cantidad; i++)
                pesoCifra *= 10;
            numero = numero * pesoCifra;
            numero = Truncar(numero);
            numero = numero / pesoCifra;
        }


        static void Main(string[] args)
        {
            int opcion, numeroEntero, numCifras;
            double numeroDecimal, numeroDecimalTruncado;

            do
            {
                opcion = MostrarOpciones();
                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("Introduce numero: ");
                        numeroDecimal = Double.Parse(Console.ReadLine());
                        numeroEntero = Truncar(numeroDecimal);
                        Console.WriteLine("El numero truncado es " + numeroEntero);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Introduce numero: ");
                        numeroDecimal = Double.Parse(Console.ReadLine());
                        numeroEntero = 0;
                        Truncar(numeroDecimal,ref numeroEntero);
                        Console.WriteLine("El numero truncado es " + numeroEntero);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Introduce numero: ");
                        numeroDecimal = Double.Parse(Console.ReadLine());
                        Truncar(ref numeroDecimal);
                        Console.WriteLine("El numero truncado es " + numeroDecimal);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Introduce numero: ");
                        numeroDecimal = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce cifras: ");
                        numCifras = Int32.Parse(Console.ReadLine());
                        numeroDecimalTruncado = TruncarDecimales(numeroDecimal, numCifras);
                        Console.WriteLine("El numero truncado es " + numeroDecimalTruncado);
                        break;
                    case 5:
                        Console.WriteLine("Introduce numero: ");
                        numeroDecimal = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce cifras: ");
                        numCifras = Int32.Parse(Console.ReadLine());
                        numeroDecimalTruncado = 0;
                        TruncarDecimales(numeroDecimal, numCifras, ref numeroDecimalTruncado);
                        Console.WriteLine("El numero truncado es " + numeroDecimalTruncado);
                        break;
                    case 6:
                        Console.WriteLine("Introduce numero: ");
                        numeroDecimal = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce cifras: ");
                        numCifras = Int32.Parse(Console.ReadLine());
                        TruncarDecimales(ref numeroDecimal, numCifras);
                        Console.WriteLine("El numero truncado es " + numeroDecimal);
                        break;
                }
            } while (opcion != 7);
        }
    }
}

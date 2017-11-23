using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horario
{
    class Program
    {
        public static int menu()
        {
            int numero = 0;
            Console.WriteLine("Menu" + "\n");
            Console.WriteLine("1. Asignar Programa");
            Console.WriteLine("2. Borrar Programa");
            Console.WriteLine("3. Escribir Dia");
            Console.WriteLine("3. Escribir Semana");
            Console.WriteLine("5. Salir");
            Console.WriteLine("\n");
            numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }

        static void Main(string[] args)
        {
            Semana miTV = new Semana();
            Programa miProgramaTV;

            int opcion, duracionP, numeroDia, numeroHorario;
            string nombreP, contenidoP;

            do {
                opcion = menu();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduce nombre Programa: ");
                        nombreP = Console.ReadLine();
                        Console.WriteLine("Introduce contenido Programa: ");
                        contenidoP = Console.ReadLine();
                        Console.WriteLine("Introduce duracion programa:");
                        duracionP = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce numero dia:");
                        numeroDia = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce horario:");
                        numeroHorario = Int32.Parse(Console.ReadLine());

                        miProgramaTV = new Programa(nombreP, contenidoP, duracionP);
                        miTV.SetPrograma(miProgramaTV, numeroDia, numeroHorario);
                        Console.ReadKey();
                        break;
                    case 2:
                       
                        break;
                    case 3:
                        Console.WriteLine("Introduce numero dia:");
                        numeroDia = Int32.Parse(Console.ReadLine());
                        miTV.Escribir(numeroDia);
                        Console.ReadKey();
                        break;

                    case 4:
                        miTV.Escribir();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Salir del Programa");
                        break;
                }
            } while (opcion != 5);
        }
    }
}

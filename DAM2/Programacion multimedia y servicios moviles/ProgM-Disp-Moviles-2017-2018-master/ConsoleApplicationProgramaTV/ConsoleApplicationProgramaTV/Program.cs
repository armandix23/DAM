using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationProgramaTV
{
    class Program
    {

        static public int MostrarOpciones()
        {
            Console.WriteLine("OPCIONES");
            Console.WriteLine("1. Asignar Programa");
            Console.WriteLine("2. Borrar Programa");
            Console.WriteLine("3. Escribir Dia");
            Console.WriteLine("4. Escribir Semana");
            Console.WriteLine("7. Salir");
            return Int32.Parse(Console.ReadLine());
        }


        static void Main(string[] args)
        {
            Semana miTV = new Semana();
            Programa miProgramaTV;

            int opcion, duracionP, numeroDia, numeroHorario;
            string nombreP, contenidoP;

            do
            {
                opcion = MostrarOpciones();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduce nombre programa: ");
                        nombreP = Console.ReadLine();
                        Console.WriteLine("Introduce contenido programa: ");
                        contenidoP = Console.ReadLine();
                        Console.WriteLine("Introduce duracion programa: ");
                        duracionP = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce numero dia: ");
                        numeroDia = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce horario: ");
                        numeroHorario = Int32.Parse(Console.ReadLine());
                        miProgramaTV = new Programa(nombreP, contenidoP, duracionP);
                        miTV.SetPrograma(miProgramaTV, numeroDia, numeroHorario);
                        break;
                    case 3:
                        Console.WriteLine("Introduce numero dia: ");
                        numeroDia = Int32.Parse(Console.ReadLine());
                        miTV.Escribir(numeroDia);
                        Console.ReadKey();
                        break;
                    case 4:
                        miTV.Escribir();
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 7);
        }
      }
}

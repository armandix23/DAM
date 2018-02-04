using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Tienda_Electronica
{
    class Program
    {
        static public int MostrarOpciones()
        {
            Console.WriteLine("OPCIONES");
            Console.WriteLine("1. Comprar ordenador");
            Console.WriteLine("2. Comprar tablet");
            Console.WriteLine("3. Comprar movil");
            Console.WriteLine("4. Anotar venta");
            Console.WriteLine("5. Eliminar venta");
            Console.WriteLine("6. Mostrar ventas");
            Console.WriteLine("7. Mostrar ventas por tipo");
            Console.WriteLine("8. Salir");
            return Int32.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Ordenador O1 = new Ordenador();
            Movil M1 = new Movil();
            Tablet T1 = new Tablet();

            int opcion, duracionP, numeroDia, numeroHorario;
            string marca, nombre;

            do
            {
                opcion = MostrarOpciones();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduce nombre marca: ");
                        marca = Console.ReadLine();
                        Console.WriteLine("Introduce nombre del ordenador ");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Introduce duracion programa: ");
                        duracionP = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce numero dia: ");
                        numeroDia = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce horario: ");
                        numeroHorario = Int32.Parse(Console.ReadLine());
                        
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("Introduce nombre programa: ");
                        nombreP = Console.ReadLine();
                        
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Introduce numero dia: ");
                        numeroDia = Int32.Parse(Console.ReadLine());
                        
                        Console.ReadKey();
                        break;
                    case 4:
                        
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 7);

        }
    }
}

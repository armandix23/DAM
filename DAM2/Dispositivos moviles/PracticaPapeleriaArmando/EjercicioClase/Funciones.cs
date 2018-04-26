using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioClase
{
    class Funciones
    {
        
        static public int MostrarOpciones()
        {
            Console.WriteLine("OPCIONES");
            Console.WriteLine("1. Comprar accesorio");
            Console.WriteLine("2. Comprar repografia");
            Console.WriteLine("3. Comprar consumible");
            Console.WriteLine("4. Eliminar una compra realizada");
            Console.WriteLine("5. Modificar una compra");
            Console.WriteLine("6. Listado de compras realizadas en un mes concreto");
            Console.WriteLine("7. Listado de compras realizadas para un tipo concreto");
            Console.WriteLine("8. Listado  de  compras  realizadas  para  un  cliente  concreto: ");
            Console.WriteLine("9. Resumen  de compras por  producto");
            Console.WriteLine("10. Resumen  de compras totales");
            Console.WriteLine("11. Eliminar un cliente:");
            Console.WriteLine("12. Salir");
            return Int32.Parse(Console.ReadLine());
        }

        
    }
}

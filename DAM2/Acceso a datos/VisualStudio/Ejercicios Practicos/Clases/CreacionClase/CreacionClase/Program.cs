using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionClase
{
    // Devolver numero de dias desde 1 enero hasta anio actual

    // Escribir la mayor de todas las fechas (Metodo burbuja)


    class Program
    {
        public static void Imprimir(Fecha[] fechas)
        {
            for (int i = 0; i < fechas.Length; i++)
            {
                Console.WriteLine("El dia es: " + fechas[i].Dia + " del mes: " + fechas[i].Mes + " del aniso: " + fechas[i].Anio);
            }
        }

        static void Main(string[] args)
        {
            // Crear un Array de Objetos
            Fecha[] fechas = new Fecha[4];
            fechas[0] = new Fecha(23, 2, 2012);
            fechas[1] = new Fecha(12, 2, 2017);
            fechas[2] = new Fecha(20, 3, 2017);
            fechas[3] = new Fecha(19, 8, 2017);

            if (fechas[0].EsMayor(fechas[1]) && fechas[0].EsMayor(fechas[2]) && fechas[0].EsMayor(fechas[3]))
                Console.WriteLine(fechas[0].Escribe());
            else
                if ((fechas[1].EsMayor(fechas[2]) && fechas[1].EsMayor(fechas[3])))
                Console.WriteLine(fechas[1].Escribe());
            else
                   if (fechas[2].EsMayor(fechas[3]))
                Console.WriteLine(fechas[2].Escribe());
            else
                Console.WriteLine(fechas[3].Escribe());



            Console.WriteLine("Dia de " + fechas[0].Escribe() + " son " +
                              fechas[0].ContarDias());

            Console.ReadKey();

        }
    }
}

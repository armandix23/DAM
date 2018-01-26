using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Crear potencias
            Potencia p1 = new Potencia(2, 8),
                     p2 = new Potencia(2, 6),
                     p3 = new Potencia(2, 4),
                     pRes;
            double valor;


            // 2. Llamar métodos
            p1.Multiplicar(p2);
            pRes = p2.MultiplicarP(p3);
            valor = pRes.Valor();
            Console.WriteLine(p1.Escribir());
            Console.WriteLine("EL valor es: " + valor);

            // 3. Calcular mayor
            if ( (p1.getExponente() > p2.getExponente()) &&
                 (p1.getExponente() > p3.getExponente()) )
                Console.WriteLine(p1.Escribir());
            else if (p2.getExponente() > p3.getExponente())
                Console.WriteLine(p2.Escribir());
            else
                Console.WriteLine(p3.Escribir());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad3
{
    /*
        Crear una clase para gestionar potencias de numeros (con base y exponente). Debera permitir las
        siguientes operaciones: multiplicar dos potencias, dividir dos potencias, obtener el valor numerico
        de una potencia y elevar una potencia a un exponente dado. Completar con un programa principal que 
        cree potencias, llame a los metodos anteriores e imprima por pantalla la potencia con la base y el
        exponente mas alto. 
    */
    class Principal
    {
        static void Main(string[] args)
        {
            Potencia p1 = new Potencia(2, 8),
                     p2 = new Potencia(2, 6),
                     p3 = new Potencia(2, 4),
                     pRes;
            double valor;

            p1.Multiplicar(p2);
            pRes = p2.MultiplicarP(p3);
            valor = p3.Valor();
            Console.WriteLine(p1.Imprimir());
            Console.WriteLine("El valor es:" + valor);

            if (p1.getExponente() > p2.getExponente() && p1.getExponente() > p3.getExponente())
                Console.WriteLine(p1.Imprimir());
            else
                if (p2.getExponente() > p3.getExponente())
                Console.WriteLine(p2.Imprimir());
            else
                Console.WriteLine(p3.Imprimir());

            Console.ReadKey();
        }
    }
}

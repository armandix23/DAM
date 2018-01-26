using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationEjerciciosRepaso
{
    class Program
    {
        public static int LongitudCadena(string s)
        {
            if (s == "")
                return 0;
            else
                return 1 + LongitudCadena(s.Remove(0, 1));
        }

        public static int Interpretar(string linea)
        {
            int op1 = 0, op2 = 0, resul = 0;
            char oper = ' ';
            // Buscar alguno de los operadores +,-,*,/
            for (int i = 0; i < linea.Length; i++)
            {
                if ( linea[i] == '+' || linea[i] == '-' ||
                     linea[i] == '*' || linea[i] == '/')
                {
                    op1 = Int32.Parse(linea.Substring(0, i));
                    oper = linea[i];
                    op2 = Int32.Parse(linea.Substring(i + 1, linea.Length - (i + 1)));
                }
            }

            // Analizar la expresión
            switch (oper)
            {
                case '+':
                    resul = op1 + op2;
                    break;
                case '-':
                    resul = op1 - op2;
                    break;
                case '*':
                    resul = op1 * op2;
                    break;
                case '/':
                    resul = op1 / op2;
                    break;
            }
            return resul;
        }


        static void Main(string[] args)
        {
            string nombre, expresion;
            int resultado;

            Console.WriteLine("Introduce una cadena: ");
            nombre = Console.ReadLine();
            Console.WriteLine("La longitud de " + nombre + " es " + LongitudCadena(nombre));
            Console.ReadKey();

            Console.WriteLine("Introduce una expresión: ");
            expresion = Console.ReadLine();
            resultado = Interpretar(expresion);
            Console.WriteLine("El resultado de la expresión " + expresion + " es " + resultado);
            Console.ReadKey();
        }

    }
}

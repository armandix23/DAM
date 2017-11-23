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
    class Potencia
    {
        private int b;
        private int exp;

        public Potencia(int nuevoBase, int nuevoExp)
        {
            b = nuevoBase;
            exp = nuevoExp;
        }

        public int getExponente()
        {
            return exp;
        }

        public void Multiplicar(Potencia p)
        {
            if (b == p.b)
            {
                exp = exp + p.exp;
            }
        }

        public Potencia MultiplicarP(Potencia p)
        {
            Potencia nueva = new Potencia(0, 0);
            if (this.b == p.b)
            {
                nueva.b = this.b;
                nueva.exp = this.exp + p.exp;

            }
            return nueva;
        }

        public void Dividir(Potencia p)
        {
            if (b == p.b)
            {
                exp = exp - p.exp;
            }
        }

        public void Elevar(int e)
        {
           exp = exp * e;
        }
    
        public double Valor()
        {
            int v = 1;
            for (int i = 1; i <= exp; i++)
                v *= b;
            return v;
        }

        public string Imprimir()
        {
            return "Base: " + b + " Expon: " + exp;
        }
    }
}

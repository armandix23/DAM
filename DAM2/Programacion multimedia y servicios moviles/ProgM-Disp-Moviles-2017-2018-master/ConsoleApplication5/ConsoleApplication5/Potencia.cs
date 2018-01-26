using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Potencia
    {
        private int b;
        private int exp;

        public Potencia(int nuevaBase,int nuevoExp)
        {
            b = nuevaBase;
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
            return v; // Math.Pow(b, exp);
        }

        public string Escribir()
        {
            return "Base: " + b + " Expon: " + exp;
        }


    }
}

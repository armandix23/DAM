using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMoviles
{
    class CamaraWEB
    {
        private string marca;
        private string objetivo;
        private int peso;
        private int resolucion;
        private int valor;

        public CamaraWEB()
        {
            marca = "";
            objetivo = "";
            peso = 0;
            resolucion = 0;
            valor = 0;
        }

        public CamaraWEB(string m, string o, int p, int r, int v)
        {
            marca = m;
            objetivo = o;
            peso = p;
            resolucion = r;
            valor = v;
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Objetivo
        {
            get
            {
                return objetivo;
            }

            set
            {
                objetivo = value;
            }
        }

        public int Peso
        {
            get
            {
                return peso;
            }

            set
            {
                peso = value;
            }
        }

        public int Resolucion
        {
            get
            {
                return resolucion;
            }

            set
            {
                resolucion = value;
            }
        }

        public int Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public string Escribir()
        {
            return "Marca: "        + marca      + " " +
                   "Objetivo: "     + objetivo   + " " +
                   "Peso: "         + peso       + " " + 
                   "Resolucion: "   + resolucion + " " +
                   "Valor: "        + valor;
        }

        public void vaciar()
        {
            marca = "";
            objetivo = "";
            peso = 0;
            resolucion = 0;
            valor = 0;
        }
    }
}

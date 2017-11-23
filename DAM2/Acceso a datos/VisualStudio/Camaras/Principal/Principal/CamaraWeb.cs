using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class CamaraWeb
    {
        string marca;
        string objetivo;
        double peso;
        int mPixels;
        int maxZoom;

        //Creamo el constructor
        public CamaraWeb(string marca, string objetivo, double peso, int mPixels, int maxZoom)
        {
            this.marca = marca;
            this.objetivo = objetivo;
            this.peso = peso;
            this.mPixels = mPixels;
            this.maxZoom = maxZoom;
        }

        public void Escribir()
        {
            Console.WriteLine("Marca: " + marca + " Objetivo: " + objetivo + " Peso: " + peso + 
                " Maximo Pixels: " + mPixels + " Maximo ZOOM: " + maxZoom);
        }

        public void Vaciar()
        {
            Console.WriteLine("Marca: " + "" + " Objetivo: " + "" + " Peso: " + "" +
                "Maximo Pixels: " + "" + " Maximo ZOOM: " + "");
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

        public double Peso
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

        public int MPixels
        {
            get
            {
                return mPixels;
            }

            set
            {
                mPixels = value;
            }
        }

        public int MaxZoom
        {
            get
            {
                return maxZoom;
            }

            set
            {
                maxZoom = value;
            }
        }
    }
}

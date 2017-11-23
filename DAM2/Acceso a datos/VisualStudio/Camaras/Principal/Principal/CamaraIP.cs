using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class CamaraIP
    {
        string marca;
        string objetivo;
        double peso;
        string direccionMac;
        string direccionIP;

        // Creamos el constructor
        public CamaraIP(string marca, string objetivo, double peso, string direccionMac, string direccionIP)
        {
            this.marca = marca;
            this.objetivo = objetivo;
            this.peso = peso;
            this.direccionMac = direccionMac;
            this.direccionIP = direccionIP;
        }

        public void Escribir()
        {
            Console.WriteLine("Marca: " + marca + " Objetivo: " + objetivo + " Peso: " + peso + 
                " Direccion MAC: " + direccionMac + " Direccion IP: " + direccionIP);
        }

        public void Vaciar()
        {
            Console.WriteLine("Marca: " + "" + " Objetivo: " + "" + " Peso: " + "" +
                " Direccion MAC: " + "" + " Direccion IP: " + "");
        }

        public void Modificar(double p)
        {
            Peso = p;
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

        public string DireccionMac
        {
            get
            {
                return direccionMac;
            }

            set
            {
                direccionMac = value;
            }
        }

        public string DireccionIP
        {
            get
            {
                return direccionIP;
            }

            set
            {
                direccionIP = value;
            }
        }
    }
}

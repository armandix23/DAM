using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTelevision
{
    class Programa
    {
        private string nombre;
        private string contenido;
        private int horas;

        public Programa()
        {
            nombre = "";
            contenido = "";
            horas = 0;
        }

        public Programa(string n, string c, int h)
        {
            nombre = n;
            contenido = c;
            horas = h;
        }
        public string Escibir()
        {
            return "Nombre: " + nombre +
                "Contenido: " + contenido +
                "Duracion: " + horas;
        }
        public string borrarP()
        {
            nombre = "";
            contenido = "";
            horas = 0;

            return "Nombre: " + nombre +
                   "Contenido: " + contenido +
                   "Duracion: " + horas; 
        }

    }

    
}

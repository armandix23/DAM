using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationProgramaTV
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
        public Programa(string n,string c,int h)
        {
            nombre = n;
            contenido = c;
            horas = h;
        }

        public string Escribir()
        {
            return "Nombre: " + nombre +
                "Contenido: " + contenido +
                "Duracion: " + horas;
        }
    }
}

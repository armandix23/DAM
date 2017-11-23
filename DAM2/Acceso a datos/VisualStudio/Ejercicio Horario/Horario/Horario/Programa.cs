using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horario
{
    class Programa
    {
        private string nombreProg;
        private string contenido;
        private int horas;

        public Programa()
        {
            nombreProg = "";
            contenido = "";
            horas = 0;
        }

        public Programa(string n, string c, int h)
        {
            nombreProg = n;
            contenido = c;
            horas = h;
        }

        public String Escribir()
        {
            return "Nombre: " + nombreProg + " Contenido: " + contenido + " Duracion" + horas;
        }
    }
}

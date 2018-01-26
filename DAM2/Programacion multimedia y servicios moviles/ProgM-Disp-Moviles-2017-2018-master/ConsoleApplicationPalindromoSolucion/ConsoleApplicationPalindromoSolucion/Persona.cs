using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationPalindromoSolucion
{
    class Persona
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre;  }
            set { nombre = value;  }
        }

        public void setNombre(string v)
        {
            nombre =  v;
        }
        public string getNombre()
        {
            return nombre;
        }
    }
}

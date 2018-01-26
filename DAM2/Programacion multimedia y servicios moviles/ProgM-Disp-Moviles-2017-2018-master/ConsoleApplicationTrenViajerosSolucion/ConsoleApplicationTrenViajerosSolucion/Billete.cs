using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTrenViajerosSolucion
{
    class Billete
    {
        private string clase;
        private string destino;
        private int cantidad;
        private bool revisado;

        public Billete()
        {
            clase = "turista";
            destino = "";
            cantidad = 0;
            revisado = false;
        }
        public void Revisar()
        {
            revisado = true;
        }

        public int GetCantidad()
        {
            return cantidad;
        }

        public void SetClase(string cl)
        {
            clase = cl;
        }
        public void Modificar(string cl, string d, int ca)
        {
            clase = cl;
            destino = d;
            cantidad = ca;
        }
    }
}

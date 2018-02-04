using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Tienda_Electronica
{
    class Ordenador : Productos
    {
        int velocidad;
        int npuertos;

        public Ordenador()
        {
            velocidad = 0;
            npuertos = 0;
        }

        public Ordenador(int velocidad, int npuertos, string n, string ma, int me, int p) : base(n, ma, me, p)
        {
            this.velocidad = velocidad;
            this.npuertos = npuertos;
            this.nombre = n;
            this.marca = ma;
            this.memoriaRAM = me;
            this.precio = p;
        }
    }
}

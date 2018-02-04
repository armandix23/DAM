using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Tienda_Electronica
{
    class Tablet : Productos
    {
        int resolucion;
        int duracionBat;
        
        public Tablet()
        {
            resolucion = 0;
            duracionBat = 0;
        }

        public Tablet(int resolucion, int duracionBat, string n, string ma, int me, int p) : base(n, ma, me, p)
        {
            this.resolucion = resolucion;
            this.duracionBat = duracionBat;
            this.nombre = n;
            this.marca = ma;
            this.memoriaRAM = me;
            this.precio = p;
        }
    }
}

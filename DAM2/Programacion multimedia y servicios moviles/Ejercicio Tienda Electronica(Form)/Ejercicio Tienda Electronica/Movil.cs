using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Tienda_Electronica
{
    class Movil : Productos
    {
        //Propiedades
        string sistOpe;
        int duracionBat;
        int almacenamiento;

        public Movil()
        {
            sistOpe = "";
            duracionBat = 0;
            almacenamiento = 0;
        }

        public Movil(string sistOpe, int duracionBat, int almacenamiento, string n, string ma, int me ,int p) : base(n,ma,me,p)
        {
            this.sistOpe = sistOpe;
            this.duracionBat = duracionBat;
            this.almacenamiento = almacenamiento;
            this.nombre = n;
            this.marca = ma;
            this.memoriaRAM = me;
            this.precio = p;

        }
    }
}

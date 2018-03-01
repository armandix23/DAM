using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Tienda_Electronica.Class
{
    class Tablet : Productos
    {
        private int resolucion;
        private int duracionBat;

        

        public Tablet() : base()
        {
            Resolucion = 0;
            DuracionBat = 0;
        }

        public Tablet(int resolucion, int duracionBat, string n, string ma, int me, int p) : base(n, ma, me, p)
        {
            this.Resolucion = resolucion;
            this.DuracionBat = duracionBat;
        }

        public int Resolucion
        {
            get
            {
                return resolucion;
            }

            set
            {
                resolucion = value;
            }
        }

        public int DuracionBat
        {
            get
            {
                return duracionBat;
            }

            set
            {
                duracionBat = value;
            }
        }
    }

}

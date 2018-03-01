using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Tienda_Electronica
{
    class Movil : Productos
    {
        string sistOpe;
        int duracionBat;
        int almacenamiento;


        public Movil()
        {
            SistOpe = "";
            DuracionBat = 0;
            Almacenamiento = 0;
        }

        public Movil(string sistOpe, int duracionBat, int almacenamiento, string n, string ma, int me ,int p) : base(n,ma,me,p)
        {
            this.SistOpe = sistOpe;
            this.DuracionBat = duracionBat;
            this.Almacenamiento = almacenamiento;
        }

        public string SistOpe
        {
            get
            {
                return sistOpe;
            }

            set
            {
                sistOpe = value;
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

        public int Almacenamiento
        {
            get
            {
                return almacenamiento;
            }

            set
            {
                almacenamiento = value;
            }
        }
    }
}

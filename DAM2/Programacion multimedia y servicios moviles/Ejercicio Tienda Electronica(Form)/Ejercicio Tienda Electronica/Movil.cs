using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Tienda_Electronica.Class
{
    class Movil : Productos
    {
        //Propiedades
        private string sistOpe;
        private int duracionBat;
        private int almacenamiento;


        public Movil(string sistOpe, int duracionBat, int almacenamiento, string nombre, string marca, int memoria, int precio) : base(nombre, marca, memoria, precio)
        {
            this.SistOpe = sistOpe;
            this.DuracionBat = duracionBat;
            this.Almacenamiento = almacenamiento;
            

        }
        public Movil() : base()
        {
            SistOpe = "";
            DuracionBat = 0;
            Almacenamiento = 0;
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

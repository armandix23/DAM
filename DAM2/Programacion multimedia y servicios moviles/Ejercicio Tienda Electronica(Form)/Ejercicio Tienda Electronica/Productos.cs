using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Tienda_Electronica
{
    class Productos
    {
        protected string nombre;
        protected string marca;
        protected int memoriaRAM;
        protected int precio;

        public Productos()
        {
            nombre = "";
            marca = "";
            memoriaRAM = 0;
            precio = 0;
        }

        public Productos(string nombre, string marca, int memoriaRAM, int precio)
        {
            this.nombre = nombre;
            this.marca = marca;
            this.memoriaRAM = memoriaRAM;
            this.precio = precio;
        }
    }
    

}

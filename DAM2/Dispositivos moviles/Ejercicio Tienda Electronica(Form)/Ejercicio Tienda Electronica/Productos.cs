using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Tienda_Electronica
{
    class Productos
    {
        private string nombre;
        private string marca;
        private int memoriaRAM;
        private int precio;

        

        public Productos()
        {
            Nombre = "";
            Marca = "";
            MemoriaRAM = 0;
            Precio = 0;
        }

        public Productos(string nombre, string marca, int memoriaRAM, int precio)
        {
            this.Nombre = nombre;
            this.Marca = marca;
            this.MemoriaRAM = memoriaRAM;
            this.Precio = precio;
        }

        protected string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        protected string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        protected int MemoriaRAM
        {
            get
            {
                return memoriaRAM;
            }

            set
            {
                memoriaRAM = value;
            }
        }

        protected int Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }
    }
    

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioClase
{
    class Accesorio : Producto
    {
        private int peso;
        private string material;

        public Accesorio() 
        {
            peso = 0;
            material = "";
        }

        public Accesorio(string nombre, string tipoProducto, int codigoProducto, int precio, int peso, string material)
            : base(nombre, tipoProducto, codigoProducto, precio)
        {
            this.peso = peso;
            this.material = material;
        }

        // Getter and Setter
        public int Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
    }
}

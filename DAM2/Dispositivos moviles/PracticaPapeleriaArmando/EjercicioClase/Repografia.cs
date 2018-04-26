using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioClase
{
    class Repografia : Producto
    {
        private string material;
        private string color;
        private string fabricante;        

        public Repografia() 
        {
            material = "";
            color = "";
            fabricante = "";
        }

        public Repografia(string nombre, string tipoProducto, int codigoProducto, int precio, string material, string color, string fabricante)
            : base(nombre, tipoProducto, codigoProducto, precio)
        {
            this.material = material;
            this.color = color;
            this.fabricante = fabricante;
        }

        // Getter and Setter
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioClase
{
    class Producto
    {
        private string nombre;
        private string tipoProducto;        
        private int codigoProducto;        
        private int precio;
        
        public Producto() 
        {
            nombre = "";
            tipoProducto = "";
            codigoProducto = 0;
            precio = 0;
        }

        public Producto(string nombre, string tipoProducto, int codigoProducto, int precio) 
        {
            this.nombre = nombre;
            this.tipoProducto = tipoProducto;
            this.codigoProducto = codigoProducto;
            this.precio = precio;
        }

        // Getter and Setter
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int CodigoProducto
        {
            get { return codigoProducto; }
            set { codigoProducto = value; }
        }
        public string TipoProducto
        {
            get { return tipoProducto; }
            set { tipoProducto = value; }
        }
    }
}

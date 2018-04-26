using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioClase
{
    class Consumible : Producto 
    {
        private string fechaFabricacion;
        private int peso;        

        public Consumible() 
        {
            fechaFabricacion = "";
            peso = 0;
        }

        public Consumible(string nombre, string tipoProducto, int codigoProducto, int precio, string fechaFabricacion, int peso) : base(nombre, tipoProducto,codigoProducto,precio)
        {
            this.fechaFabricacion = fechaFabricacion;
            this.peso = peso;
        }

        // Getter and Setter
        public string FechaFabricacion
        {
            get { return fechaFabricacion; }
            set { fechaFabricacion = value; }
        }
        public int Peso
        {
            get { return peso; }
            set { peso = value; }
        }
    }
}

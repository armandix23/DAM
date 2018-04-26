using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioClase
{
    class Cliente
    {
        private string nombre;
        private string dni;      
        private string direccion;       
        private int telefono;

       
        public Cliente() 
        {
            nombre = "";
            dni = "";
            direccion = "";
            telefono = 0;
        }

        public Cliente(string nombre, string dni, string direccion, int telefono) 
        {
            this.nombre = nombre;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public string mostrarClientes()
        {
            return "Nombre Cliente: " + nombre + "Fecha: " + "DNI: " + dni + " Direccion: " + direccion + "Telefono: " + telefono;
        }

        // Getter and Setter
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

    }
}

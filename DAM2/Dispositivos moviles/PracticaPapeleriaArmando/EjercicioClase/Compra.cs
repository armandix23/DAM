using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioClase
{
    class Compra : Producto
    {
        private int dia;
        private int mes;        
        private int anio;        
        private int importe;        
        private int codCli;
       
        public Compra() 
        {
            dia = 0;
            mes = 0;
            anio = 0;
            importe = 0;
            codCli = 0;
        }

        public Compra(string nombre, string tipoProducto, int codigoProducto, int precio, int dia, int mes, int anio, int importe, int codCli)
            : base(nombre, tipoProducto, codigoProducto, precio)
        {
            this.dia = dia;
            this.mes = mes;
            this.anio = anio;
            this.importe = importe;
            this.codCli = codCli;
        }
        public string mostrarCompras() 
        {
            return "Codigo Cliente:" + codCli + " Fecha:" + " Dia:" + dia + " Mes:" + mes + " Año:" + anio + " Importe:" + importe +"€";        
        }

        // Getter and Setter
        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }
        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }
        public int Importe
        {
            get { return importe; }
            set { importe = value; }
        }
        public int CodCli
        {
            get { return codCli; }
            set { codCli = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationClases
{
    class Fecha
    {
        // Atributos
        int dia, mes, anio;

        // Constructores
        public Fecha()
        {
            dia = 1;
            mes = 1;
            anio = 1970;
        }

        public Fecha(int d, int m , int a)
        {
            dia = d;
            mes = m;
            anio = a;
        }
    
        public int Anio()
        {
            return this.anio;
        }

        public int Mes()
        {
            return this.mes;
        }

        public int Dia()
        {
            return this.dia;
        }
        public void sumarMes()
        {
            mes = mes + 1;
            if( mes == 13)
            {
                this.anio = anio + 1;
                this.mes = 0;
            }
        }
        public void imprimeFechas()
        {
            Console.Write(this.dia  + " - ");
            Console.Write(this.mes  + " - ");
            Console.Write(this.anio + "\n");
        }
    }
}

/*
 1. Determina si la fecha corresponde con año bisiesto
 2. Aumentar el mes ++
 3. Devuelva nº dias desde el 1 enero año entero
 4. Crear 3 fechas y leer los valores de las fechas por pantalla
    - Escriba mayor de todas
 */

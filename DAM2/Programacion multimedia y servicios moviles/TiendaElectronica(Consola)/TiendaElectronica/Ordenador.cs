﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Tienda_Electronica
{
    class Ordenador : Productos
    {
        int velocidad;
        int npuertos;

       
        public Ordenador()
        {
            Velocidad = 0;
            Npuertos = 0;
        }

        public Ordenador(int velocidad, int npuertos, string n, string ma, int me, int p) : base(n, ma, me, p)
        {
            this.Velocidad = velocidad;
            this.Npuertos = npuertos;
        }

        public int Velocidad
        {
            get
            {
                return velocidad;
            }

            set
            {
                velocidad = value;
            }
        }

        public int Npuertos
        {
            get
            {
                return npuertos;
            }

            set
            {
                npuertos = value;
            }
        }

    }

}

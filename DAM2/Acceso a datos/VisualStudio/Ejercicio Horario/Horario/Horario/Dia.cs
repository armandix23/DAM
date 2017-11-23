using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horario
{
    class Dia
    {
        private Programa[] tablaPrograma;
        private string nombreDia;

        public Dia()
        {
            nombreDia = "";
            tablaPrograma = new Programa[5];
            for (int i = 0; i < tablaPrograma.Length; i++)
                tablaPrograma[i] = new Programa();
        }

        // Crear el nombre de dia para poder modificarlo luego
        public Dia(String n)
        {
            nombreDia = n;
            tablaPrograma = new Programa[5];
            for (int i = 0; i < tablaPrograma.Length; i++)
                tablaPrograma[i] = new Programa();
        }

        public void SetPrograma(Programa p, int hora)
        {
            tablaPrograma[hora] = p;
        }

        public void Escribir()
        {
            Console.WriteLine(nombreDia);
            for (int i = 0; i < tablaPrograma.Length; i++)
                Console.WriteLine(tablaPrograma[i].Escribir());
        }
    }
}

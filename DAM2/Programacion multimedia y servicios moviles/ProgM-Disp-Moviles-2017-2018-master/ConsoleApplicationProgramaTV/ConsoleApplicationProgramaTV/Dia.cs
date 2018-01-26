using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationProgramaTV
{
    class Dia
    {
        private Programa[] tablaPrograma;
        private string nombre;

        public Dia()
        {
            nombre = "";
            tablaPrograma = new Programa[5];
            for (int i = 0; i < tablaPrograma.Length; i++)
                tablaPrograma[i] = new Programa();
        }
        public Dia(string n)
        {
            nombre = n;
            tablaPrograma = new Programa[5];
            for (int i = 0; i < tablaPrograma.Length; i++)
                tablaPrograma[i] = new Programa();
        }

        public void SetPrograma(Programa p,int horario)
        {
            tablaPrograma[horario] = p;
        }

        public void Escribir()
        {
            Console.WriteLine(nombre);
            for (int i = 0; i < tablaPrograma.Length; i++)
                Console.WriteLine(tablaPrograma[i].Escribir());
        }



    }
}

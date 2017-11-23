using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTelevision
{
    class Dia
    {
        private Programa[] tablaPrograma;
        private string nombre;

        public Dia(string n)
        {
            nombre = n;
            tablaPrograma = new Programa[5]; // Tabla con 5 posiciones
            for (int i = 0; i < tablaPrograma.Length; i++)
                tablaPrograma[i] = new Programa();
        }
       
        public void setPrograma(Programa p, int horario)
        {
            tablaPrograma[horario] = p;
        }

        public void Escribir()
        {
            Console.WriteLine(nombre);
            for (int i = 0; i < tablaPrograma.Length; i++)
             Console.WriteLine(tablaPrograma[i].Escibir());
        }

        public void borrarP()
        {
            Console.WriteLine(nombre);
            for (int i = 0; i < tablaPrograma.Length; i++)
                Console.WriteLine(tablaPrograma[i].Escibir());
        }
    }
}

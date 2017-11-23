using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTelevision
{
    class Semana
    {
      private Dia[] tablaDias;

        public Semana()
        {
            tablaDias = new Dia[5];
            tablaDias[0] = new Dia("Lunes");
            tablaDias[0] = new Dia("Martes");
            tablaDias[0] = new Dia("Miercoles");
            tablaDias[0] = new Dia("Jueves");
            tablaDias[0] = new Dia("Viernes");
        }

        public void setPrograma(Programa p, int dia, int horario)
        {
            tablaDias[dia].setPrograma(p, horario);
        }

        public void Escribir()
        {
            
            for (int i = 0; i < tablaDias.Length; i++)
            tablaDias[i].Escribir();
        }

        public void borrarP()
        {

            for (int i = 0; i < tablaDias.Length; i++)
                tablaDias[i].borrarP();
        }
        public void Escribir(int dia)
        {
                tablaDias[dia].Escribir();
        }
    }
}

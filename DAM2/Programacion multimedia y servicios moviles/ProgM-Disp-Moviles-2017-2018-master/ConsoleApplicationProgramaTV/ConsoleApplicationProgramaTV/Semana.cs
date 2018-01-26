using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationProgramaTV
{
    class Semana
    {
        private Dia[] tablaDias;

        public Semana()
        {
            tablaDias = new Dia[5];
            tablaDias[0] = new Dia("Lunes");
            tablaDias[1] = new Dia("Martes");
            tablaDias[2] = new Dia("Miercoles");
            tablaDias[3] = new Dia("Jueves");
            tablaDias[4] = new Dia("Viernes");
        }

        public void SetPrograma(Programa p,int dia,int horario)
        {
            tablaDias[dia].SetPrograma(p, horario);
        }

        public void Escribir()
        {
            for (int i = 0; i < tablaDias.Length; i++)
                tablaDias[i].Escribir();
        }
        public void Escribir(int dia)
        {
          tablaDias[dia].Escribir();
        }


    }
}

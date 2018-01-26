using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTrenViajerosSolucion
{
    class Vagon
    {
        private Billete[] plazas;

        public Vagon()
        {
            plazas = new Billete[50];
            for (int i = 0; i < plazas.Length; i++)
                plazas[i] = new Billete();
        }

        public Billete GetBillete(int i)
        {
            return plazas[i];
        }

        public void Revisar()
        {
            for (int i = 0; i < 50; i++)
                plazas[i].Revisar();
        }

        public int NMaletas()
        {
            int num = 0;
            for (int i = 0; i < 50; i++)
            {
                num += plazas[i].GetCantidad();
            }
            return num;
        }
    }
}

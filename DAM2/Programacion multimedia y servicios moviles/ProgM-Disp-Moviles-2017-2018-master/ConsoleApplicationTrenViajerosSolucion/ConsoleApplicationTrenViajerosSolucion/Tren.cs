using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTrenViajerosSolucion
{
    class Tren
    {
        private Vagon[] vagones;

        public Tren()
        {
            vagones = new Vagon[4];
            for (int i = 0; i < 4; i++)
                vagones[i] = new Vagon();
        }
        public Vagon GetVagon(int i)
        {
            return vagones[i];
        }
        public void Revisar(int i)
        {
            vagones[i].Revisar();
        }
        public int NMaletas(int i)
        {
            return vagones[i].NMaletas();
        }
    }
}

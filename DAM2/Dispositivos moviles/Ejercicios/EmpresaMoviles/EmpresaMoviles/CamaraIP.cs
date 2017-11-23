using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMoviles
{
    class CamaraIP
    {
        private string marca;
        private string objetivo;
        private int peso;
        private string dirMAC;
        private string dirIP;

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Objetivo
        {
            get
            {
                return objetivo;
            }

            set
            {
                objetivo = value;
            }
        }

        public int Peso
        {
            get
            {
                return peso;
            }

            set
            {
                peso = value;
            }
        }

        public string DirMAC
        {
            get
            {
                return dirMAC;
            }

            set
            {
                dirMAC = value;
            }
        }

        public string DirIP
        {
            get
            {
                return dirIP;
            }

            set
            {
                dirIP = value;
            }
        }

        public CamaraIP()
        {
            marca = "";
            objetivo = "";
            peso = 0;
            dirMAC = "";
            dirIP = "";
        }

        public CamaraIP(string m, string o, int p, string dM, string dI)
        {
            marca = m;
            objetivo = o;
            peso = p;
            dirMAC = dM;
            dirIP = dI;
        }

        public string Escribir()
        {
            return "Marca: "     + marca        + " " +
                   "Objetivo: "  + objetivo     + " " +
                   "Peso: "      + peso         + " " +
                   "dirMAC: "    + dirMAC       + " " +
                   "dirIP: "     + dirIP;
        }
        public string getDir()
        {
            return dirIP;
        }
        public void setDir(String dirIP)
        {
            this.dirIP = dirIP;
        }
        public void vaciar()
        {
            marca = "";
            objetivo = "";
            peso = 0;
            dirMAC = "";
            dirIP = "";
        }

        public void modificar(int peso)
        {
            this.peso = peso;
        }
        
    }
}

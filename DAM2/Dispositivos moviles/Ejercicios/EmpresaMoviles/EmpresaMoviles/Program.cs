using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMoviles
{
    class Program {
        public static void asignar(CamaraIP camIp1, CamaraIP camIp2, CamaraWEB camWEB1, CamaraWEB camWEB2)
        {

            camIp1.DirIP = camIp2.DirIP;
            camIp2.DirMAC = camIp1.DirMAC;
            camWEB2.Resolucion = camWEB1.Resolucion;
            camWEB1.Marca = camWEB2.Marca;
        }
        static void Main(string[] args)
        {
            

            CamaraWEB camWEB1 = new CamaraWEB("Nikon","Fijo",100,1000,1200),
                      camWEB2 = new CamaraWEB("Sansun","Movil",200,9999,450);

            CamaraIP camIp1 = new CamaraIP("Xiaomi","Fijo",100,"192.167.121.12","122.121.122.122"),
                     camIp2 = new CamaraIP("BQ","Auto",230,"230.200.200.12","231.76.23.12");

            Console.WriteLine("Camaras web");
            Console.WriteLine(camWEB1.Escribir());
            Console.WriteLine(camWEB2.Escribir());
            Console.WriteLine("Camaras IP");
            Console.WriteLine(camIp1.Escribir());
            Console.WriteLine(camIp2.Escribir());

            Console.WriteLine("Camara web 1 vacia");
            camWEB1.vaciar();
            Console.WriteLine(camWEB1.Escribir());
            Console.WriteLine("Camara IP 2 vacia");
            camIp2.vaciar();
            Console.WriteLine(camIp2.Escribir());

            //Modificar el peso de la CamaraIP a 12 Kg.
            camIp2.modificar(12);
            Console.WriteLine(camIp2.Escribir());

           /* Asignar a la 1ª CamaraIP la dirección IP de la 2ª CamaraIP.
            Asignar a la 2ª CamaraIP la dirección MAC de la 1ª CamaraIP.
            Asignar a la 2º CamaraWeb la resolución de la 2ª CamaraWeb.
            Asignar a la 1ª CamaraWeb la marca de la CamaraIP*/
            asignar(camIp1,camIp2,camWEB1,camWEB2);
            Console.WriteLine(camWEB1.Escribir());
            Console.WriteLine(camWEB2.Escribir());
            Console.WriteLine(camIp1.Escribir());
            Console.WriteLine(camIp2.Escribir());
            Console.ReadKey();
        }
    }
}

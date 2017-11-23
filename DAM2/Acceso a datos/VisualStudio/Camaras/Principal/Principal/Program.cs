using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Una empresa de equipos electrónicos necesita gestionar cámaras de seguridad. Para ello, crear dos clases: 
    CamaraIP: Indicando marca, objetivo, peso, dirección MAC y dirección IP.
    CamaraWeb: Indicando marca, objetivo, peso, resolución en Mpixels y valor máximo de zoom.

Crear en las 2 clases los siguientes métodos públicos:
    Escribe: Escribe en una cadena todos los datos de la clase.
    Vacia: Vaciar el contenido de todos los atributos de la clase.

El programa creará 4 objetos: 2 CamaraIP, 2 CamaraWeb y realizar las siguientes tareas (en el orden indicado): 
    Modificar el peso de la CamaraIP a 12 Kg.
    Asignar a la 1ª CamaraIP la dirección IP de la 2ª CamaraIP.
    Asignar a la 2ª CamaraIP la dirección MAC de la 1ª CamaraIP.
    Asignar a la 2º CamaraWeb la resolución de la 2ª CamaraWeb.
    Asignar a la 1ª CamaraWeb la marca de la CamaraIP.
*/

namespace Principal
{
    class Program
    {
        public static void Asignar(CamaraIP cp1, CamaraIP cp2, CamaraWeb cw1, CamaraWeb cw2)
        {
            
            
            cp1.DireccionIP = cp2.DireccionIP;
            
            cp2.DireccionMac = cp1.DireccionMac;
            
            cw2.MPixels = cw1.MPixels;
            
            cw1.Marca = cp1.Marca;
        }

        static void Main(string[] args)
        {
            // Creamos Objetos camaras IP
            CamaraIP cp1 = new CamaraIP("Xiaomi","Automatico",1.20,"88:DD:22:3E:44:33", "192.168.1.4");
            CamaraIP cp2 = new CamaraIP("Samsung", "Automatico", 2.50, "90:AD:20:3F:22:54", "192.168.1.200");

            // Creamos Objetos camaras WEB
            CamaraWeb cw1 = new CamaraWeb("LG","Manual",2.10,15,12);
            CamaraWeb cw2 = new CamaraWeb("Lenovo", "Manual", 2.10, 10, 8);

            cp1.Escribir();
            cp2.Escribir();

            cw1.Escribir();
            cw2.Escribir();

            Asignar(cp1,cp2,cw1,cw2);

            Console.WriteLine("");
            Console.WriteLine("Asignar a la 1ª CamaraIP la dirección IP de la 2ª CamaraIP.");
            cp1.Escribir();
            Console.WriteLine("");
            Console.WriteLine("Asignar a la 2ª CamaraIP la dirección MAC de la 1ª CamaraIP");
            cp2.Escribir();
            Console.WriteLine("");
            Console.WriteLine("Asignar a la 1ª CamaraWeb la marca de la CamaraIP.");
            cw1.Escribir();
            Console.WriteLine("");
            Console.WriteLine("Asignar a la 2º CamaraWeb la resolución de la 1ª CamaraWeb.");
            cw2.Escribir();
            Console.ReadKey();

        }
    }
}

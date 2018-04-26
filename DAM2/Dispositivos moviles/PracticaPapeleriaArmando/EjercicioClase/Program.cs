using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EjercicioClase
{
    class Program 
    {
     
        static void Main(string[] args)
        {

            // Apartado Clientes
            int opcion;

            List<Cliente> listaClientes = new List<Cliente>();
            
                    // Cuente los clientes
                    int elegido = listaClientes.Count();

            //APARTADO COMPRAS
            List<Compra> listaCompra = new List<Compra>();
            List<Compra> listaCompra2 = new List<Compra>();
            List<Compra> listaCompra3 = new List<Compra>();

            Compra c1 = new Compra();
            Compra c2 = new Compra();
            Compra c3 = new Compra();

            int elegidoCompras = listaCompra.Count;

            // MENU OPCIONES
            do
            {
                opcion = Funciones.MostrarOpciones();
               
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Comprando accesorio..");                        
                        c1.TipoProducto = Console.ReadLine();
                        Console.WriteLine("Que cliente quieres");
                        c1.CodCli = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Elige día");
                        c1.Dia = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Elige mes");
                        c1.Mes = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Elige año");
                        c1.Anio = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Elige importe");
                        c1.Importe = Int32.Parse(Console.ReadLine());
                        listaCompra.Add(c1);
                        Console.ReadKey();
                            Console.Clear();

                        break;

                    case 2:
                        Console.WriteLine("Comprando repografia..");
                        c2.TipoProducto = Console.ReadLine();
                        Console.WriteLine("Que cliente quieres");
                        c2.CodCli = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Elige día");
                        c2.Dia = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Elige mes");
                        c2.Mes = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Elige año");
                        c2.Anio = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Elige importe");
                        c2.Importe = Int32.Parse(Console.ReadLine());
                        listaCompra2.Add(c2);
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 3:
                        Console.WriteLine("Comprando consumible");
                        c3.TipoProducto = Console.ReadLine();
                        Console.WriteLine("Que cliente quieres");
                        c3.CodCli = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Elige día");
                        c3.Dia = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Elige mes");
                        c3.Mes = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Elige año");
                        c3.Anio = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Elige importe");
                        c3.Importe = Int32.Parse(Console.ReadLine());
                        listaCompra3.Add(c3);
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 4:
                        Console.WriteLine("Que compra deseas borrar");
                        elegidoCompras = Int32.Parse(Console.ReadLine());
                        try
                        {
                            listaCompra.RemoveAt(elegidoCompras);                            
                            listaCompra2.RemoveAt(elegidoCompras);                           
                            listaCompra3.RemoveAt(elegidoCompras);
                            Console.WriteLine("La compra ha sido borrado");
                        }
                        catch (ArgumentOutOfRangeException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        Console.ReadKey();
                            Console.Clear();
                        break;



                    case 5:
                        Console.WriteLine("¿Que compra quiere modificar 0-infinito?");
                        int elegidoCompra = Int32.Parse(Console.ReadLine());

                        /// COMPRA1
                        Console.WriteLine("Compra actual");
                            foreach (Compra n in listaCompra)
                                {
                                    Console.WriteLine(n.mostrarCompras());
                                }
                        Console.WriteLine("¿Que día quiere?");
                        listaCompra.ElementAt(elegidoCompra).Dia = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("¿Que mes quiere?");
                        listaCompra.ElementAt(elegidoCompra).Mes = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("¿Que año quiere?");
                        listaCompra.ElementAt(elegidoCompra).Anio = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("¿Que importe quiere?");
                        listaCompra.ElementAt(elegidoCompra).Importe = Int32.Parse(Console.ReadLine());
                            foreach (Compra n in listaCompra)
                                {                           
                                Console.WriteLine(n.mostrarCompras());                            
                                }

                        // COMPRA2
                        Console.WriteLine("Compra actual");
                            foreach (Compra n in listaCompra2)
                                {
                                    Console.WriteLine(n.mostrarCompras());
                                }
                        Console.WriteLine("¿Que día quiere?");
                        listaCompra2.ElementAt(elegidoCompra).Dia = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("¿Que mes quiere?");
                        listaCompra2.ElementAt(elegidoCompra).Mes = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("¿Que año quiere?");
                        listaCompra2.ElementAt(elegidoCompra).Anio = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("¿Que importe quiere?");
                        listaCompra2.ElementAt(elegidoCompra).Importe = Int32.Parse(Console.ReadLine());
                            foreach (Compra n in listaCompra2)
                                {                           
                                Console.WriteLine(n.mostrarCompras());                            
                                }
                        //COMPRA3
                        Console.WriteLine("Compra actual");
                            foreach (Compra n in listaCompra3)
                                {
                                    Console.WriteLine(n.mostrarCompras());
                                }
                        Console.WriteLine("¿Que día quiere?");
                        listaCompra3.ElementAt(elegidoCompra).Dia = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("¿Que mes quiere?");
                        listaCompra3.ElementAt(elegidoCompra).Mes = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("¿Que año quiere?");
                        listaCompra3.ElementAt(elegidoCompra).Anio = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("¿Que importe quiere?");
                        listaCompra3.ElementAt(elegidoCompra).Importe = Int32.Parse(Console.ReadLine());
                            foreach (Compra n in listaCompra3)
                                {                           
                                Console.WriteLine(n.mostrarCompras());                            
                                }
                        Console.ReadKey();
                            Console.Clear();

                        break;

                    case 6:

                        int mesElegido = 0;
                        int mostrar = 0;

                        //COMPRA 1
                        Console.WriteLine("Que mes deseas visualizar");
                        mesElegido = Int32.Parse(Console.ReadLine());

                        for (int i = 0; i < listaCompra.Count; i++)
                        {

                            if (mesElegido.Equals(listaCompra.ElementAt(i).Mes))
                            {
                                foreach (Compra n in listaCompra)
                                {
                                    if (mesElegido == n.Mes)
                                    {
                                        Console.WriteLine(n.mostrarCompras());
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("No hay compras realizadas en ese mes:" + mesElegido);
                            }
                        }

                        //COMPRA 2
                        Console.WriteLine("Que mes deseas visualizar");
                        mesElegido = Int32.Parse(Console.ReadLine());

                        for (int i = 0; i < listaCompra2.Count; i++)
                        {

                            if (mesElegido.Equals(listaCompra2.ElementAt(i).Mes))
                            {
                                foreach (Compra n in listaCompra2)
                                {
                                    if (mesElegido == n.Mes)
                                    {
                                        Console.WriteLine(n.mostrarCompras());
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("No hay compras realizadas en ese mes:" + mesElegido);
                            }
                        }

                        //COMPRA 3
                        Console.WriteLine("Que mes deseas visualizar");
                        mesElegido = Int32.Parse(Console.ReadLine());

                        for (int i = 0; i < listaCompra3.Count; i++)
                        {

                            if (mesElegido.Equals(listaCompra3.ElementAt(i).Mes))
                            {
                                foreach (Compra n in listaCompra3)
                                {
                                    if (mesElegido == n.Mes)
                                    {
                                        Console.WriteLine(n.mostrarCompras());
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("No hay compras realizadas en ese mes:" + mesElegido);
                            }
                        }
                        Console.ReadKey();
                            Console.Clear();
                        break;

                    case 7:
                         if (listaCompra.Count == 0)
                            {
                                Console.WriteLine("No tiene ninguna consulta");
                            }
                            else
                            {
                                Console.WriteLine("Dime el tipo de producto consultar en formato letra");
                                string tipoElegido = Console.ReadLine();

                             // COMPRA1
                                foreach (Compra n in listaCompra)
                                {
                                    if (tipoElegido == n.TipoProducto)
                                    {
                                        Console.WriteLine(n.mostrarCompras());
                                    }
                                }
                                
                             // COMPRA2
                                foreach (Compra n in listaCompra2)
                                {
                                    if (tipoElegido == n.TipoProducto)
                                    {
                                        Console.WriteLine(n.mostrarCompras());
                                    }
                                }

                             // COMPRA3
                                foreach (Compra n in listaCompra3)
                                {
                                    if (tipoElegido == n.TipoProducto)
                                    {
                                        Console.WriteLine(n.mostrarCompras());
                                    }
                                }
                            }


                            Console.ReadKey();
                            Console.Clear();

                        break;

                    case 8:
                            if (listaCompra.Count == 0)
                            {
                                Console.WriteLine("No tiene ninguna consulta");
                            }
                            else
                            {
                                Console.WriteLine("Dime el cliente a consultar en formato número");
                                int tipoElegido =  Int32.Parse(Console.ReadLine());

                                // COMPRA 1
                                foreach (Compra n in listaCompra)
                                {
                                    if (tipoElegido == n.CodCli)
                                    {
                                        Console.WriteLine(n.mostrarCompras());
                                    }
                                }

                                // COMPRA 2
                                foreach (Compra n in listaCompra2)
                                {
                                    if (tipoElegido == n.CodCli)
                                    {
                                        Console.WriteLine(n.mostrarCompras());
                                    }
                                }

                                // COMPRA 3
                                foreach (Compra n in listaCompra3)
                                {
                                    if (tipoElegido == n.CodCli)
                                    {
                                        Console.WriteLine(n.mostrarCompras());
                                    }
                                }
                             }
                                Console.ReadKey();
                                Console.Clear();
                        break;

                    case 9:
                     
                        int cantidad = 0;
                        int importeTotal = 0;

                       

                        if(c1.TipoProducto == "a")
                            
                            if (c1.TipoProducto == "a")
                            for (int i = 0; i < listaCompra.Count; i++)
                                if (listaCompra.ElementAt(i).TipoProducto == "a")
                                    importeTotal += listaCompra.ElementAt(i).Importe;
                            cantidad++;
                            foreach (Compra n in listaCompra)
                            {
                                Console.WriteLine("Accesorios");
                                    Console.WriteLine(n.mostrarCompras());                               
                            }


                         if(c2.TipoProducto == "r")                           
                            if (c2.TipoProducto == "r")
                            for (int i = 0; i < listaCompra2.Count; i++)
                                if (listaCompra2.ElementAt(i).TipoProducto == "r")
                                    importeTotal += listaCompra2.ElementAt(i).Importe;
                            cantidad++;

                            foreach (Compra n in listaCompra2)
                            {
                                Console.WriteLine("Repografia");
                                    Console.WriteLine(n.mostrarCompras());
                                
                            }
                        if(c3.TipoProducto == "c")                           
                            if (c3.TipoProducto == "c")
                            for (int i = 0; i < listaCompra3.Count; i++)
                                if (listaCompra3.ElementAt(i).TipoProducto == "r")
                                    importeTotal += listaCompra3.ElementAt(i).Importe;
                            cantidad++;

                            foreach (Compra n in listaCompra3)
                            {
                                Console.WriteLine("Consumible");
                                    Console.WriteLine(n.mostrarCompras());
                                
                            }
                        Console.ReadKey();
                                Console.Clear();

                        break;

                    case 10:

                        break;

                    case 11:
                        if (listaClientes.Count != 0)
                        {
                            Console.WriteLine("No tiene ningun cliente");
                        }
                        else
                        {
                            Console.WriteLine("Que cliente deseas borrar");
                            elegido = Int32.Parse(Console.ReadLine());
                            try
                            {
                                listaClientes.RemoveAt(elegido);
                                Console.WriteLine("El cliente ha sido borrado");
                            }
                            catch (ArgumentOutOfRangeException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                         Console.ReadKey();
                                Console.Clear();
                        break;
                }
            } while (opcion != 12);
        }

       
    }
}

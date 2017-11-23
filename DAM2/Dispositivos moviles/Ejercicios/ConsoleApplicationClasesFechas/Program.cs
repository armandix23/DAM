using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationClases
{ // POO Programacion Orientada a Objetos
    class Program
    {
        static void Main(string[] args)
        {
            Fecha f1 = new Fecha(22, 08, 1994),
                  f2 = new Fecha(4, 5, 1982),
                  f3 = new Fecha(1, 1, 2016),
                  f4 = new Fecha(12, 12, 2017);


            Console.Write("1º) Determina si la fecha corresponde con año bisiesto" + "\n" +
                          "2º) Aumentar el mes ++" + "\n" +
                          "3º) Devuelve nº dias desde el 1 enero año entero" + "\n" +
                          "4º) Determinar el mayor de las fechas" + "\n");

            Console.Write("Seleccione una opción: ");

           

            switch (Console.Read())
            {
                case '1':
                    Console.Write("Determina si la fecha corresponde con año bisiesto" + "\n");

                    if (f1.Anio() % 4 == 0)
                    {
                        Console.Write("f1.->" + "Es bisiesto" + "\n");
                    }
                    else
                    {
                        Console.Write("f1.->" + "No es bisiesto" + "\n");
                    }


                    if (f2.Anio() % 4 == 0)
                    {
                        Console.Write("f2.->" + "Es bisiesto" + "\n");
                    }
                    else
                    {
                        Console.Write("f2.->" + "No es bisiesto" + "\n");
                    }

                    if (f3.Anio() % 4 == 0)
                    {
                        Console.Write("f3.->" + "Es bisiesto" + "\n");
                    }
                    else
                    {
                        Console.Write("f3.->" + "No es bisiesto" + "\n");
                    }

                    Console.ReadKey();
                    break;

                case '2':
                    Console.Write(" Aumentar el mes ++" + "\n");

                    f1.sumarMes();
                    f2.sumarMes();
                    f3.sumarMes();
                    f4.sumarMes();

                    f1.imprimeFechas();
                    f2.imprimeFechas();
                    f3.imprimeFechas();
                    f4.imprimeFechas();

                    Console.ReadKey();

                    break;

                case '3':
                    Console.Write("Devuelve nº dias desde el 1 enero año entero");
                    int totalf1 = 0;
                    int totalf2 = 0;
                    int totalf3 = 0;

                    do
                    {
                        if (f1.Mes() == 2)
                        {
                            f1.sumarMes();
                            totalf1 = totalf1 + 27;
                        }

                        if (f1.Mes() % 2 != 0)
                        {
                            f1.sumarMes();
                            totalf1 = totalf1 + 30;
                        }

                        if (f1.Mes() % 2 == 0)
                        {
                            f1.sumarMes();
                            totalf1 = totalf1 + 31;
                        }
                    } while (f4.Dia() != f1.Dia() && f4.Mes() != f1.Mes());

                    do
                    {
                        if (f2.Mes() == 2)
                        {
                            f2.sumarMes();
                            totalf2 = totalf2 + 27;
                        }

                        if (f2.Mes() % 2 != 0)
                        {
                            f2.sumarMes();
                            totalf2 = totalf2 + 30;
                        }

                        if (f2.Mes() % 2 == 0)
                        {
                            f2.sumarMes();
                            totalf2 = totalf2 + 31;
                        }
                    } while (f4.Dia() != f2.Dia() && f4.Mes() != f2.Mes());


                    do
                    {
                        if (f3.Mes() == 2)
                        {
                            f3.sumarMes();
                            totalf3 = totalf3 + 27;
                        }

                        if (f3.Mes() % 2 != 0)
                        {
                            f3.sumarMes();
                            totalf3 = totalf3 + 30;
                        }

                        if (f3.Mes() % 2 == 0)
                        {
                            f3.sumarMes();
                            totalf3 = totalf3 + 31;
                        }
                    } while (f4.Dia() != f3.Dia() && f4.Mes() != f3.Mes());

                    Console.Write("total de días f1: " + totalf1 + "\n");
                    Console.Write("total de días f1: " + totalf2 + "\n");
                    Console.Write("total de días f1: " + totalf3 + "\n");

                    Console.ReadKey();

                    break;

                case '4':
                    Console.Write("Determinar el mayor de las fechas");
                    f1.imprimeFechas();
                    f2.imprimeFechas();
                    f3.imprimeFechas();

                    Console.ReadKey();

                    break;
                }
            
        }
    }
}

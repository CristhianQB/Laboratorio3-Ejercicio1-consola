using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Ejercicio1_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que futa tansportará");
            Console.WriteLine("(0)Naranja");
            Console.WriteLine("(1)Fresa");
            Console.WriteLine("(2)Mango");
            string frutaTexto = Console.ReadLine();

            Console.WriteLine("Cantidad de cajas");
            int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es su distancia");
            string distanciaTexto = Console.ReadLine();

            int fruta = int.Parse(frutaTexto);
            int distancia = int.Parse(distanciaTexto);

            switch (fruta)
            {
                case 0:
                    if (distancia < 30)
                    {
                        int total = cantidad * distancia * 2;
                        Console.WriteLine("El total es de: " + total + " soles");
                    }
                    else
                    {
                       int total = cantidad * distancia * 4;
                        Console.WriteLine("El total es de: " + total + " soles");
                    }
                    break;

                case 1:
                    if (distancia < 30)
                    {
                        int total = cantidad * distancia * 6;
                        Console.WriteLine("El total es de: " + total + " soles");
                    }
                    else
                    {
                        int total = cantidad * distancia * 9;
                        Console.WriteLine("El total es de: " + total + " soles");
                    }
                    break;

                case 2:
                    if (distancia < 30)
                    { 
                        int total = cantidad * distancia * 3;
                        Console.WriteLine("El total es de: " + total + " soles");
                    }
                    else
                    {
                        int total = cantidad * distancia * 5;
                        Console.WriteLine("El total es de: " + total + " soles");
                    }
                    break;
            }

            Console.ReadKey();

        }
    }
}

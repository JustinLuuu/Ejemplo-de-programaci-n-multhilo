using System;
using System.Collections.Generic;
using System.Threading;

namespace Ejemplo_Multithreads
{
    class Program
    {        
        static double NUMERO { get; set; } = 1000;

        static void Main(string[] args)
        {
            Thread hilo1 = new Thread(new ThreadStart(Restador1));
            Thread hilo2 = new Thread(new ThreadStart(Restador2));

            hilo1.Start();
            hilo2.Start();

            Console.ReadKey();
        }

        static void Restador1()
        {
            while (NUMERO > 0)
            {
                NUMERO--;
                Console.WriteLine($"(Metodo Restador1)  ha restado, ahora el valor actual de la variable es: {NUMERO}");
            }
        }

        static void Restador2()
        {
            while (NUMERO > 0)
            {
                NUMERO--;
                Console.WriteLine($"(Metodo Restador2)  ha restado, ahora el valor actual de la variable es: {NUMERO}");
            }
        }
    }
}

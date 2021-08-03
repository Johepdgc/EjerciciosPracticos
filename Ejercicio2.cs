using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPractico1
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            Int32 a;
            Int32 b;

            Console.WriteLine("Escribe a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe b");
            b = Convert.ToInt32(Console.ReadLine());

            Int32 arit = (a + b) * (a - b);
            Console.WriteLine(arit);
            Console.ReadKey();

        }
    }
}

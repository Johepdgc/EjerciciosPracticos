using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPractico1
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            Int32 dividendo;
            Int32 divisor;

            Console.WriteLine("Divisiones");
            Console.WriteLine("Ingrese un numero entero");
            dividendo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero entero");
            divisor = Convert.ToInt32(Console.ReadLine());

            if (divisor >= 1)
            {
                Int32 cociente = dividendo / divisor;
                Console.WriteLine(cociente);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Error; no se puede dividir entre cero.");
                Console.ReadKey();
            }
        }
    }
}

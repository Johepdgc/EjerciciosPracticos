using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPractico1
{
    class Ejercicio5
    {
        enum products { Alimento, Medicina, Herramienta, Electronica, Carroceria, Entretenimiento }
        static void Main(string[] args)
        {
            Console.WriteLine("Tienda de programación");
            Console.WriteLine("Escoja un producto:");
            Console.WriteLine(products.Alimento);
            Console.WriteLine(products.Herramienta);
            Console.WriteLine(products.Electronica);
            Console.WriteLine(products.Entretenimiento);
            Console.WriteLine(products.Carroceria);
            Console.WriteLine(products.Medicina);
            string producto = Console.ReadLine();
            Double IVA = 5 * 0.13;
            if (producto == "Medicina")
            {
                Console.WriteLine("El precio a pagar es de ${0}", 5.00);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El precio a pagar es de ${0}", 5.00 + IVA);
                Console.ReadKey();
            }
        }
    }
}

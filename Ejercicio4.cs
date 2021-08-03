using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPractico1
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            Double celsius;

            Console.WriteLine("Conversor de temperatura");
            Console.WriteLine("Escribe los grados centigrados para convertirlos a fahrenheit");
            celsius = Convert.ToDouble(Console.ReadLine());

            Double fahrenheit = (celsius * 1.8) + 32;
            Console.WriteLine("De centigrados a fahrenheit tenemos {0}", fahrenheit);
            Console.ReadKey();
        }
    }
}

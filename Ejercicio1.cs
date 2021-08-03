using System;
//Ejercicio practico saludo y nombre
namespace EjercicioPractico1
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre");
            String name = Console.ReadLine();
            Console.WriteLine("Hola! Es un placer conocerte! {0}",name);
            Console.ReadKey();
        }
    }
}

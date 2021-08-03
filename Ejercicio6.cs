using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPractico1
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingreso de notas");
            Console.WriteLine("Ingrese el nombre del estudiante");
            string name = Console.ReadLine();
            Console.WriteLine("Ingrese la nota del 30%");
            Double nota1;
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del 35%");
            Double nota2;
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del otro 35%");
            Double nota3;
            nota3 = Convert.ToDouble(Console.ReadLine());

            double porcentaje1 = nota1 * 0.30;
            double porcentaje2 = nota2 * 0.35;
            double porcentaje3 = nota3 * 0.35;

            Console.WriteLine("Notas ingresadas");
            Console.WriteLine(nota1);
            Console.WriteLine(nota2);
            Console.WriteLine(nota3);

            Console.WriteLine("Porcentaje logrado");
            Console.WriteLine(porcentaje1);
            Console.WriteLine(porcentaje2);
            Console.WriteLine(porcentaje3);

            Console.WriteLine("Nota final");
            Console.WriteLine((nota1 + nota2 + nota3)/3);
            Console.ReadKey();
        }
    }
}

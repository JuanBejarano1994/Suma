using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0, n2 = 0, suma = 0;
            Console.WriteLine("PROGRAMA SUMA ");
            Console.Write("Ingrese Numero 1: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese Numero 2: ");
            n2 = double.Parse(Console.ReadLine());
            suma = n1 + n2;
            Console.WriteLine("La Suma Es: "+suma);
            Console.ReadKey();
        }
    }
}

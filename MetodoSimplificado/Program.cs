using System;

namespace MetodoSimplificado
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso de metodo simplificado
            Console.WriteLine("Primer número: ");
            int num1 = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Segundo número: ");
            int num2 = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("La suma es: "+ suma(num1, num2));
        }
        // Metodo de suma de dos numeros simplificado.
        static int suma(int a, int b) => a + b;
    }
}
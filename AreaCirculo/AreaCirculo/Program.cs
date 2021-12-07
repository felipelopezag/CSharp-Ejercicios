using System;

namespace AreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1416;
            Console.WriteLine("Introduce la medida del radio: ");
            double radio = double.Parse((Console.ReadLine()));
            //double area = radio * radio * pi;
            double area = Math.Pow(radio, 2)*pi;
            Console.WriteLine($"El área del circulo es: {area}");

        }
    }
}
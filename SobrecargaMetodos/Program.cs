using System;

namespace SobrecargaMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa que suma dos numeros a través de sobrecarga de métodos
            System.Console.WriteLine(Suma(2,3,5));
            System.Console.WriteLine(Suma(2,3));
            System.Console.WriteLine(Suma(2.5,3.5));

        }

        // Sobrecarga de métodos
        public static int Suma(int a, int b)
        {
            return a + b;
        }

        public static double Suma(double a, double b)
        {
            return a + b;
        }

        public static int Suma(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
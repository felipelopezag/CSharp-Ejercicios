using System;

namespace CondicionIF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Condicional que permite saber si una persona es mayor de edad o no.
            Console.WriteLine("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad.");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad.");
            }

            // Condicional que permite saber si una persona puede votar o no.
            Console.WriteLine("Ingrese su edad: ");
            int edad2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese su sexo: ");
            string sexo = Console.ReadLine();
            if (edad2 >= 18 && sexo == "f")
            {
                Console.WriteLine("Usted puede votar.");
            }
            else
            {
                Console.WriteLine("Usted no puede votar.");
            }

        }
    }
}
using System;

namespace CondicionIF
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declaración de variable booleana.
            Al colocar un signo de admiracion hacia abajo invierte el valor original.
            bool hacefrio=false;
            Console.WriteLine(!hacefrio);
            */

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

        }
    }
}
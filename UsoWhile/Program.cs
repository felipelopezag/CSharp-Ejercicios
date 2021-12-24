using System;

namespace UsoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uso del bucle while
            System.Console.WriteLine("¿Quieres entrar en el bucle while?");
            string bucle=System.Console.ReadLine();
            while(bucle!="no")
            {
                System.Console.WriteLine("Haz entrado en el bucle while");
                System.Console.WriteLine("Teclea tu nombre: ");
                string nombre=System.Console.ReadLine();
                System.Console.WriteLine($"Hola {nombre} para salir presiona 'no'");
                bucle=System.Console.ReadLine();
            }
            System.Console.WriteLine("Hasta luego");
        }
    }
}

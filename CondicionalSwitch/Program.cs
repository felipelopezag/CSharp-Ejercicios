using System;

namespace CondicionalSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uso de switch para convertir numeros del 1 al 10 a letras
            System.Console.WriteLine("Ingrese un numero del 1 al 10");
            int a = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            switch (a)
            {
                case 1:
                    System.Console.WriteLine("Uno");
                    break;
                case 2:
                    System.Console.WriteLine("Dos");
                    break;
                case 3:
                    System.Console.WriteLine("Tres");
                    break;
                case 4:
                    System.Console.WriteLine("Cuatro");
                    break;
                case 5:
                    System.Console.WriteLine("Cinco");
                    break;
                case 6:
                    System.Console.WriteLine("Seis");
                    break;
                case 7:
                    System.Console.WriteLine("Siete");
                    break;
                case 8:
                    System.Console.WriteLine("Ocho");
                    break;
                case 9:
                    System.Console.WriteLine("Nueve");
                    break;
                case 10:
                    System.Console.WriteLine("Diez");
                    break;
                default:
                    System.Console.WriteLine("Numero fuera de rango");
                    break;
            }
        }
    }
}
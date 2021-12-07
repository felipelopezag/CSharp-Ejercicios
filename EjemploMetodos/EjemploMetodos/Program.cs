using System;
using System.Globalization;

namespace EjemploMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se desarrolla la funcióm
            int sumaNumeros(int num1, int num2)
            {
                int resultado = num1 + num2;
                return resultado;
            }
            
            //Se desarrolla el programa y despues se manda llamar la función
            Console.WriteLine("Introduce el primer número: ");
            int var1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número: ");
            int var2=Int32.Parse(Console.ReadLine());
            int result = sumaNumeros(var1, var2);
            Console.WriteLine(result);
        }
    }
}
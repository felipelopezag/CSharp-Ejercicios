using System;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Suma(1, 2));
        }
        static int Suma(int v1, int v2){
            int v = v1 + v2;
            return v;
        }
    }
}
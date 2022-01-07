using System;

namespace ConversorDivisas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que convierte pesos mexicanos a otras divisas mediante objetos
            Conversor PesoA;
            PesoA=new Conversor();
            Console.WriteLine("Teclea la cantidad en pesos mexicanos: $");
            double pesos=double.Parse(Console.ReadLine());
            double dolares=PesoA.Dolar(pesos);
            double euros=PesoA.Euro(pesos);
            double yenes=PesoA.Yen(pesos);
            double libras=PesoA.LibraUK(pesos);
            System.Console.WriteLine("Equivale a "+dolares+" dolares");
            System.Console.WriteLine("Equivale a "+euros+" euros");
            System.Console.WriteLine("Equivale a "+yenes+" yenes");
            System.Console.WriteLine("Equivale a "+libras+" libras");
        }

        public class Conversor
        {
            public double Dolar(double cantidad)
            {
                double resultado=cantidad*0.049;
                return resultado;
            }

            public double Euro(double cantidad)
            {
                double resultado=cantidad*0.043;
                return resultado;
            }

            public double Yen(double cantidad)
            {
                double resultado=cantidad*5.67;
                return resultado;
            }

            public double LibraUK(double cantidad)
            {
                double resultado=cantidad*0.036;
                return resultado;
            }
        }
    }
}

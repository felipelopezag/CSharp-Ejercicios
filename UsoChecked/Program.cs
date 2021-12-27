using System;

namespace UsoChecked
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeromaximo=int.MaxValue;
            System.Console.WriteLine(numeromaximo);

            /* Esta función verifica el desbordamiento aritmetico (sobrecarga), 
            puede activarse en VS en propiedades del proyecto */
            checked{ 
            int sobrecarga=numeromaximo+20;
            System.Console.WriteLine(sobrecarga);
            }
        }
    }
}

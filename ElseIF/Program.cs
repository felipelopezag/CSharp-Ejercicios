using System;

namespace ElseIF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Traductor de dias de la semana de ingles a español");
            Console.WriteLine("Ingrese el dia de la semana en ingles");
            string dia = Console.ReadLine();
            if (dia == "Monday")
            {
                Console.WriteLine("Lunes");
            }
            else if (dia == "Tuesday")
            {
                Console.WriteLine("Martes");
            }
            else if (dia == "Wednesday")
            {
                Console.WriteLine("Miercoles");
            }
            else if (dia == "Thursday")
            {
                Console.WriteLine("Jueves");
            }
            else if (dia == "Friday")
            {
                Console.WriteLine("Viernes");
            }
            else if (dia == "Saturday")
            {
                Console.WriteLine("Sabado");
            }
            else if (dia == "Sunday")
            {
                Console.WriteLine("Domingo");
            }
            else
            {
                Console.WriteLine("Dia invalido");
            }
        }
    }
}

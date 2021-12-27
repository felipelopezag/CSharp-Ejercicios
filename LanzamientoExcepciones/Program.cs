using System;

namespace LanzamientoExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teclea un número entre el 1 y el 12");
            int mes=int.Parse(Console.ReadLine());
            try{
            System.Console.WriteLine("El Mes correspondiente es: "+ NombreDelMes(mes));
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Mensaje de Error: "+ e.Message);
            }
        }

        public static string NombreDelMes(int mes)
        {
            switch(mes)
            {
                case 1:
                {
                    return "Enero";
                }
                case 2:
                {
                    return "Febrero";
                }
                case 3:
                {
                   return "Marzo";
                }
                case 4:
                {
                   return "Abril";
                }
                case 5:
                {
                   return "Mayo";
                }
                case 6:
                {
                   return "Junio";
                }
                case 7:
                {
                   return "Julio";
                }
                case 8:
                {
                   return "Agosto";
                }
                case 9:
                {
                   return "Septiembre";
                }
                case 10:
                {
                   return "Octubre";
                }
                case 11:
                {
                   return "Noviembre";;
                }
                case 12:
                {
                   return "Diciembre";
                }
                default:
                {
                    //return "Número Inválido";

                    //Esta expresión sirve para lanzar intencionalmente un error de sobrecarga
                    //Ayudaria a los programadores a controlar mejor las excepciones.

                    //throw -> Lanzar
                    //New -> Nueva
                    throw new ArgumentOutOfRangeException();
                }
                
            }
        }
    }
}

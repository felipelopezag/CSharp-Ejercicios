using System;

namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; //Creación de objeto de tipo circulo
            miCirculo=new Circulo(); //Iniciación de variable/objeto de tipo circulo. Instanciar una clase.
            //Tambien se le llama instanciación / EJemplarización / Creación de ejemplar de clase.

            System.Console.WriteLine(miCirculo.CalculoArea(5));

            //Segundo objeto:
            Circulo miCirculo2;
            miCirculo2= new Circulo();
            System.Console.WriteLine(miCirculo2.CalculoArea(9));
        }
    }

    class Circulo
    {
        const double pi=3.141592; // Propiedad de la clase circulo. Campo de clase.
        public double CalculoArea(double radio) //Método de clase ¿Que pueden hacer los objetos de tipo "circulo"
        {
            double area=pi*Math.Pow(radio,2);
            return area;
        }
    }
}

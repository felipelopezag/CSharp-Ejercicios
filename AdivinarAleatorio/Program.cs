using System;

namespace AdivinarAleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa que genera un número aleatorio entre 0 y 100 y debes adivinar cuál generó. (Usando While)
            Random numero= new Random(); //Se crea un objeto que generará un número aleatorio
            int aleatorio = numero.Next(1,100); // Se crea una variable con un número aleatorio
            int minumero=101; //Se inicializa la variable en un número fuera del rango de 0 y 100
            int intentos=0; // Se inicializa la variable intentos en cero
            System.Console.WriteLine("Introduce un número entre el 0 y 100: ");
            while(aleatorio!=minumero)
            {
                intentos++; // Se incrementa un intento en uno
                try{
                minumero=int.Parse(Console.ReadLine()); // Se almacena y sobre-escribe el número dado por el usuario.
                }
                catch(FormatException e){
                    System.Console.WriteLine("No uses letras, usa solo número entre 0 y 100 ");
                }
                catch(OverflowException e){
                    System.Console.WriteLine("Número demasiado grande, usa solo números entre 0 y 100");
                }

                // Captura todas las excepciones excepto las previamente definidas como lo hicimos con FormatException
                catch(Exception e) when (e.GetType!=typeof(FormatException))
                {
                    System.Console.WriteLine("Formato invalido");
                }
                
                //Se valída el número proporcionado con el usuario con el generado aleatoriamente.
                if(minumero>aleatorio) System.Console.WriteLine("El número es más bajo");
                if(minumero<aleatorio) System.Console.WriteLine("El número es más alto");
            }
            System.Console.WriteLine($"Correcto!, haz necesitado {intentos} intentos para lograrlo");
        }
    }
}
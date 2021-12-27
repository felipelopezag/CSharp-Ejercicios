using System;

namespace LeerUnArchivo
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.StreamReader archivo=null;

            try
            {
            int contador=0;
            string ruta=@"/home/felipe/Escritorio/sum.txt";
            string linea;

            archivo = new System.IO.StreamReader(ruta);

            while((linea=archivo.ReadLine())!=null)
            {
                System.Console.WriteLine(linea);
                contador++;
            }

            }
            catch(Exception e)
            {
                System.Console.WriteLine("Error con la lectura del archivo");
            }
            finally
            {
                if(archivo!=null){
                    archivo.Close();
                }
                System.Console.WriteLine("Conexión con el fichero cerrada");
            }


        }
    }
}

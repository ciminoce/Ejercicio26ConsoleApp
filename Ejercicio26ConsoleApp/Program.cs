using System;

namespace Ejercicio26ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var vocales = "aAeEiIoOuU";
                          
            Console.WriteLine("Vocales");
            Console.Write("Ingrese una letra:");
            char letra = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (vocales.IndexOf(letra)>=0)
            {
                System.Console.WriteLine($"{letra} es una vocal y está en la posición {vocales.IndexOf(letra)}");
            }
            else
            {
                System.Console.WriteLine($"{letra} no es una vocal");
            }

            Console.ReadLine();
            //if (letra=='a' || letra=='e' || letra=='i' || letra=='o' || letra=='u' )
            //{
            //    Console.WriteLine($"{letra} es una vocal");

            //}
            //else
            //{
            //    Console.WriteLine($"{letra} no es una vocal");
            //}
        }
    }
}

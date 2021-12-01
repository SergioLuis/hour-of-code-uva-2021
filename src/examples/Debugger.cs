using System;

namespace HourOfCode.Examples
{
    public class Debugger
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // 1.- Deja que la aplicación se ejecute hasta la última llave de la función
            // 2.- Después en la 'Debug Console' cambia el valor de la variable 'text'
            // 3.- Retrocede el cursor de ejecución hasta el último Console.WriteLine
            // 4.- Deja que se ejecute de nuevo - ¿qué ha pasado?

            string text = "What a wonderful C# course!";
            Console.WriteLine(text);
        }
    }
}

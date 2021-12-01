using System;

namespace HourOfCode.Examples
{
    public class ErrorHandling
    {
        public static void Main(string[] args)
        {
            FirstExample(args);
            SecondExample(args);
        }

        static void FirstExample(string[] args)
        {
            try
            {
                Console.WriteLine(args[999]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Captured IndexOutOfRangeException!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Captured Exception!");
            }
        }

        static void SecondExample(string[] args)
        {
            try
            {
                Console.WriteLine(args[999]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Captured Exception!");
            }
            // Descomenta este bloque y veamos qué sucede cuando intentas compilar
            // catch (IndexOutOfRangeException ex)
            // {
            //     Console.WriteLine("Captured IndexOutOfRangeException!");
            // }
        }
    }
}

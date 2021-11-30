using System;

namespace HourOfCode.Examples
{
    public class ConsoleInputOutput
    {
        // This example requires running on a terminal
        // Visual Studio Code seems to hang when trying Console.ReadLine
        public static void Main(string[] args)
        {
            Console.Write("Type your name: ");
            string name = Console.ReadLine();

            Console.Write("Type your surname: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Ok thx bye {0} {1}", name, surname);
        }

    }
}

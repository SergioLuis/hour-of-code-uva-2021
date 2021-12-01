using System;

namespace HourOfCode.Examples
{
    public class ProgramArguments
    {
        public static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.Error.WriteLine("Nobody to say hello to :(");
                Environment.Exit(1);
            }

            Console.WriteLine("Hello, {0}!", args[0]);
        }
    }
}

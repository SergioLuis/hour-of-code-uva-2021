using System;

namespace HourOfCode.Examples
{
    public class ParsingPrimitiveTypes
    {
        public static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            string input = Console.ReadLine();

            int parsedInteger;
            if (!int.TryParse(input, out parsedInteger))
            {
                Console.WriteLine("You can0t fool me!");
            }
            else
            {
                Console.WriteLine("Nicely done. Your number is: {0}", parsedInteger);
            }
        }

        static void PrintVariable(string variableName, object variableValue)
            => Console.WriteLine($"{variableName} => {variableValue}");
    }
}

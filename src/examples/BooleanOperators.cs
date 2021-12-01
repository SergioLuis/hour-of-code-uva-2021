using System;

namespace HourOfCode.Examples
{
    public class BooleanOperators
    {
        public static void Main(string[] args)
        {
            if (true && IsTheBigCalculationCorrect())
            {
                Console.WriteLine("Foo");
            }

            if (true || IsTheBigCalculationCorrect())
            {
                Console.WriteLine("Bar");
            }

            if (true & IsTheBigCalculationCorrect())
            {
                Console.WriteLine("Fizz");
            }

            if (true | IsTheBigCalculationCorrect())
            {
                Console.WriteLine("Buzz");
            }

            if (!false && true)
            {
                Console.WriteLine("!true && false => true");
            }

            if (true ^ true)
            {
                Console.WriteLine(
                    "If this prints to console the rules of reality were bent. RUN.");
            }
        }

        static bool IsTheBigCalculationCorrect()
        {
            Console.WriteLine("The function was called!");
            return true;
        }

        static void PrintVariable(string variableName, object variableValue)
            => Console.WriteLine($"{variableName} => {variableValue}");
    }
}

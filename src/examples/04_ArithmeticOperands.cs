using System;

namespace HourOfCode.Examples
{
    public class ArithmeticOperands
    {
        public static void Main(string[] args)
        {
            // Unary operators
            int a = 10;
            PrintVariable(nameof(a), a);

            // increment (++)
            a++; // Now a is 6
            PrintVariable(nameof(a), a);

            // decrement (--)
            a--; // Now a is 5
            PrintVariable(nameof(a), a);

            // minus (-)
            a = -a; // Now a is -5
            PrintVariable(nameof(a), a);

            // plus (+)
            a = +a; // ...quite useless...
            PrintVariable(nameof(a), a);

            a = -a; // Now we reverse it!

            // binary operators
            int b = 2;

            // multiplication
            PrintVariable("a * b", a * b);

            // division
            PrintVariable("a / b", a / b);

            // remainder
            PrintVariable("a % b", a % b);

            // addition
            PrintVariable("a + b", a + b);

            // substraction
            PrintVariable("a - b", a - b);
        }

        static void PrintVariable(string variableName, object variableValue)
            => Console.WriteLine($"{variableName} => {variableValue}");
    }
}

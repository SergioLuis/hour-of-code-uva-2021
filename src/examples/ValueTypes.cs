using System;

namespace HourOfCode.Examples
{
    public class ValueTypes
    {
        public static void Main(string[] args)
        {
            RunBasicExample();
            // RunAdvancedExample();
        }

        static void RunBasicExample()
        {
            int a = 5;
            PrintVariable(nameof(a), a);

            SumOneAndPrint_ArgumentByValue(a);

            PrintVariable(nameof(a), a);
        }

        static void RunAdvancedExample()
        {
            int a = 5;
            PrintVariable(nameof(a), a);

            SumOneAndPrint_ArgumentByReference(ref a);

            PrintVariable(nameof(a), a);
        }

        public static void SumOneAndPrint_ArgumentByValue(int a)
        {
            a = a + 1;
            Console.WriteLine("New value of {0}: {1}", nameof(a), a);
        }

        public static void SumOneAndPrint_ArgumentByReference(ref int a)
        {
            a = a + 1;
            Console.WriteLine("New value of {0}: {1}", nameof(a), a);
        }

        static void PrintVariable(string variableName, object variableValue)
            => Console.WriteLine($"{variableName} => {variableValue}");
    }
}

using System;

namespace HourOfCode.Examples
{
    public class BuiltInTypes
    {
        public static void Main(string[] args)
        {
            // Bool - Can be either 'true' or 'false'
            bool myBoolVariable = true;
            PrintVariable(nameof(myBoolVariable), myBoolVariable);

            // Char - One character
            char myCharVariable = 'a';
            PrintVariable(nameof(myCharVariable), myCharVariable);

            // String - One character after another!
            string myStringVariable = "Sergio Luis Para";
            PrintVariable(nameof(myStringVariable), myStringVariable);

            // Byte
            byte myByteVariable = 0x52;
            PrintVariable(nameof(myByteVariable), myByteVariable);

            // Short
            short myShortVariable = 232;
            PrintVariable(nameof(myShortVariable), myShortVariable);

            // Integer
            int myIntegerVariable = 499461;
            PrintVariable(nameof(myIntegerVariable), myIntegerVariable);

            // Long
            long myLongVariable = 6357678;
            PrintVariable(nameof(myLongVariable), myLongVariable);

            // Float
            float myFloatVariable = 128363897.349735F;
            PrintVariable(nameof(myFloatVariable), myFloatVariable);

            // Double
            double myDoubleVariable = 18362846.193664D;
            PrintVariable(nameof(myDoubleVariable), myDoubleVariable);

            Console.WriteLine($"{Environment.NewLine}== Representation ranges ==");

            Console.WriteLine(
                "Byte range: [{0}-{1}]",
                byte.MinValue, byte.MaxValue);

            Console.WriteLine(
                "Integer range: [{0}-{1}]",
                int.MinValue, int.MaxValue);

            Console.WriteLine(
                "Short range: [{0}-{1}]",
                short.MinValue, short.MaxValue);

            Console.WriteLine(
                "Long range: [{0}-{1}]",
                long.MinValue, long.MaxValue);

            Console.WriteLine(
                "Float range: [{0}-{1}]",
                float.MinValue, float.MaxValue);

            Console.WriteLine(
                "Double range: [{0}-{1}]",
                double.MinValue, double.MaxValue);
        }

        static void PrintVariable(string variableName, object variableValue)
            => Console.WriteLine($"{variableName} => {variableValue}");
    }
}

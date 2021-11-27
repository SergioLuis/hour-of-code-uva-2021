using System;
using System.Reflection;

using HourOfCode.Examples;

namespace HourOfCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Comment and uncomment the examples to run as needed

            // 01_HelloWorld
            // Run<HelloWorld>(args);

            // 02_DebuggerExample
            // Run<DebuggerExample>(args);

            // 03_BuiltInTypes
            Run<BuiltInTypes>(args);

            // 04_Operands
            // Run<Operands>(args);
        }

        static void Run<T>(string[] args)
        {
            Type exampleType = typeof(T);
            MethodInfo? mainMethod = typeof(T).GetMethod("Main");

            if (mainMethod == null)
            {
                throw new InvalidOperationException(
                    "You didn't define a 'Main' method!");
            }

            ParameterInfo[] parameters = mainMethod.GetParameters();
            if (parameters.Length != 1)
            {
                throw new InvalidOperationException(
                    "Your 'Main' method needs exactly one argument!");
            }

            Type stringArrayType = typeof(string[]);
            if (parameters[0].ParameterType != stringArrayType)
            {
                throw new InvalidOperationException(
                    "Your 'Main' method does not have a 'string[]' param!");
            }

            mainMethod.Invoke(null, new object[] { args });
        }
    }
}

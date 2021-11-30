using System;
using System.Reflection;

using HourOfCode.Examples;

namespace HourOfCode
{
    public class Program
    {
        public static int Main(string[] args)
        {
            // Comment and uncomment the examples to run as needed

            // HelloWorld
            // return Run<HelloWorld>(args);

            // DebuggerExample
            // return Run<DebuggerExample>(args);

            // BuiltInTypes
            // return Run<BuiltInTypes>(args);

            // ValueTypes
            // return Run<ValueTypes>(args);

            // BooleanOperands
            // return Run<BooleanOperands>(args);

            // FlowControl
            // return Run<FlowControl>(args);

            // ConsoleInputOutput
            // return Run<ConsoleInputOutput>(args);

            // ParsingPrimitiveTypes
            // return Run<ParsingPrimitiveTypes>(args);

            // Classes
            // return Run<Classes>(args);

            // Exercise A
            // return Run<Factorial>(args);

            // Exercise B
            // return Run<Factorial2>(args);

            return 0;
        }

        static int Run<T>(string[] args)
        {
            // Esto de aquí es el mecanismo de reflexión de C#
            // Estamos buscando un método directamente por su nombre, y luego
            //  lo ejecutamos a las bravas
            // Este mecanismo permite cosas tan potentes como el desarrollo de
            //  plugins - al fin y al cabo estamos ejecutando un método sin saber
            //  de él más que _debería_ estar definido.
            // Este material es avanzado, pero puedes probar a jugar con
            //  estas líneas, a ver qué pasa. Al fin y al cabo... para eso están :)
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

            return (mainMethod.Invoke(null, new object[] { args }) is int exitCode ? exitCode : 0);
        }
    }
}

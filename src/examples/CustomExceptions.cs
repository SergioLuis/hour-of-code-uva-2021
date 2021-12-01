using System;

namespace HourOfCode.Examples
{
    public class CustomExceptions
    {
        public class MyCustomException : Exception
        {
            public MyCustomException(string msg) : base(msg) { }
        }

        public static void Main(string[] args)
        {
            try
            {
                DangerousCode();
                Console.WriteLine("This code never runs");
            }
            catch (MyCustomException ex)
            {
                Console.Error.WriteLine(ex.Message);
                Console.Error.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("This code always runs");
            }
        }

        static void DangerousCode()
        {
            throw new MyCustomException("You were told... this code was dangerous!");
        }
    }
}

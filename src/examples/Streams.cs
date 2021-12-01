using System;
using System.IO;

namespace HourOfCode.Examples
{
    public class Streams
    {
        public static int Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.Error.WriteLine("Usage: write <text> <path>");
                Console.Error.WriteLine("Usage: read <path>");
                return 1;
            }

            switch (args[0])
            {
                case "write":
                    Write(args[1], args[2]);
                    break;

                case "read":
                    Read(args[1]);
                    break;

                default:
                    Console.WriteLine("Unknown argument {0}", args[0]);
                    return 1;
            }

            return 0;
        }

        static void Write(string text, string path)
        {
            using (FileStream fs = File.Open(path, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(text);
            }
        }

        static void Read(string path)
        {
            using (FileStream fs = File.Open(path, FileMode.Open))
            using (StreamReader sr = new StreamReader(fs))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}

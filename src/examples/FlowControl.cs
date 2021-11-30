using System;
using System.Collections.Generic;

namespace HourOfCode.Examples
{
    public class FlowControl
    {
        public static void Main(string[] args)
        {
            IterateOverList();
            IterateOverArray();
            IterateOverDictionary();
        }

        static void IterateOverList()
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            // List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            for (int i = 0; i < numbers.Count; i++)
                Console.WriteLine(numbers[i]);

            foreach (int n in numbers)
                Console.WriteLine(n);
        }

        static void IterateOverArray()
        {
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            // int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);

            foreach (int n in numbers)
                Console.WriteLine(n);
        }

        static void IterateOverDictionary()
        {
            Dictionary<string, string> indexedPeople = new Dictionary<string, string>();
            indexedPeople.Add("7539743J", "Pedro Luis Jiménez");
            indexedPeople.Add("0125754Q", "Marcos Cayetano Ordóñez");
            indexedPeople.Add("1647423L", "Covadonga de Todos Los Santos");

            foreach (KeyValuePair<string, string> kvp in indexedPeople)
                Console.WriteLine($"DNI: {kvp.Key}, Name: {kvp.Value}");
        }
    }
}

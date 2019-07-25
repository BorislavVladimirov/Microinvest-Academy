using System;
using System.Linq;
using System.Text;

namespace Task03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            string[] input = Console.ReadLine()
                .Split(',')
                .ToArray();

            string firstString = input[0].Trim();
            string secondString = input[1].Trim();

            Console.OutputEncoding = Encoding.Unicode;

            if (AreStringLengthsEqual(firstString, secondString))
            {
                Console.WriteLine(GetDifferenceByIndexes(firstString, secondString));
            }

        }

        private static StringBuilder GetDifferenceByIndexes(string firstString, string secondString)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < firstString.Length; i++)
            {
                if (firstString[i] != secondString[i])
                {
                    stringBuilder.AppendLine($"{i + 1} {firstString[i]}-{secondString[i]}");
                }
            }

            return stringBuilder;
        }

        private static bool AreStringLengthsEqual(string firstString, string secondString)
        {
            if (firstString.Length == secondString.Length)
            {
                Console.WriteLine("Двата низа са с равна дължина.");
                return true;
            }

            Console.WriteLine("Двата низа не са с равна дължина.");
            return false;
        }
    }
}

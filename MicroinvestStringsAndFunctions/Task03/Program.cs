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
            Console.WriteLine(AreStringLengthsEqual(firstString, secondString));
            Console.WriteLine(GetDifferenceByIndexes(firstString, secondString));

        }

        private static StringBuilder GetDifferenceByIndexes(string firstString, string secondString)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Разлика по позиции:");
            stringBuilder.AppendLine();

            int shorterStringLength = Math.Min(firstString.Length, secondString.Length);

            for (int i = 0; i < shorterStringLength; i++)
            {
                if (firstString[i] != secondString[i])
                {
                    stringBuilder.AppendLine($"{i + 1} {firstString[i]}-{secondString[i]}");
                }
            }

            return stringBuilder;
        }

        private static string AreStringLengthsEqual(string firstString, string secondString)
        {
            if (firstString.Length == secondString.Length)
            {
                return "Двата низа са с равна дължина.";
            }

            return "Двата низа не са с равна дължина.";
        }
    }
}

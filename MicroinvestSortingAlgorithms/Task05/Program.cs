using System;
using System.Text;

namespace Task05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = 0;

            if (int.TryParse(Console.ReadLine(), out number))
            {
                StringBuilder resultInBinary = new StringBuilder();
                Console.WriteLine(GetBinaryNumber(number, resultInBinary));
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        private static string GetBinaryNumber(int number, StringBuilder resultInBinary)
        {
            if (number <= 0)
            {
                ReverseResult(resultInBinary);

                return resultInBinary.ToString().Trim();
            }
            else
            {
                resultInBinary.Append(number % 2 + " ");

                return GetBinaryNumber(number / 2, resultInBinary);
            }
        }

        private static void ReverseResult(StringBuilder resultInBinary)
        {
            for (int i = 0; i < resultInBinary.Length / 2; i++)
            {
                char tempElement = resultInBinary[i];

                resultInBinary[i] = resultInBinary[resultInBinary.Length - 1 - i];
                resultInBinary[resultInBinary.Length - 1 - i] = tempElement;
            }
        }
    }
}

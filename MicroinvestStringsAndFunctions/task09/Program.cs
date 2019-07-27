using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task09
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char[] inputString = Console.ReadLine().ToCharArray();

            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine(GetNumbers(inputString));
        }

        private static StringBuilder GetNumbers(char[] inputString)
        {
            StringBuilder resultNumbers = new StringBuilder();
            int sum = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                StringBuilder currentNumber = new StringBuilder();
                char currentChar = inputString[i];

                if (char.IsDigit(currentChar))
                {
                    CheckForLeadingMinus(i, inputString, currentNumber);
                    currentNumber.Append(currentChar);

                    GetCurrentNumber(ref i, inputString, currentNumber, resultNumbers, ref sum);
                }
            }

            resultNumbers.Append($"Сума = {sum}");

            return resultNumbers;
        }

        private static void GetCurrentNumber(ref int i,
            char[] inputString, 
            StringBuilder currentNumber, 
            StringBuilder resultNumbers, 
            ref int sum)
        {
            for (int j = i + 1; j < inputString.Length; j++)
            {
                if (!char.IsDigit(inputString[j]))
                {
                    break;
                }

                i = j;
                currentNumber.Append(inputString[j]);
            }

            sum += int.Parse(currentNumber.ToString());
            resultNumbers.AppendLine(currentNumber.ToString());
        }

        private static void CheckForLeadingMinus(int i, char[] inputString, StringBuilder currentNumber)
        {
            if (i > 0)
            {
                if (inputString[i - 1] == '-')
                {
                    currentNumber.Append('-');
                }
            }
        }
    }
}

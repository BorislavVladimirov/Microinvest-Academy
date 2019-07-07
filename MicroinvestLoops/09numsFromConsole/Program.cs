using System;
using System.Collections.Generic;

namespace _09numsFromConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            List<string> numbers = new List<string>();

            double sum = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                double currentNumber = i * i;
                
                if (currentNumber % 3 == 0)
                {
                    numbers.Add($"skip {i.ToString()}");
                }
                else
                {
                    sum += currentNumber;
                    numbers.Add(currentNumber.ToString());
                }

                if (sum > 200)
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(",", numbers));
        }
    }
}

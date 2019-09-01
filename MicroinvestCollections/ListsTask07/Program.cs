using System;
using System.Collections.Generic;
using System.Text;

namespace ListsTask05
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            List<int> numbers = new List<int>();

            List<int> oddNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();

            GenerateList(numbers);

            FilterElements(numbers, oddNumbers, evenNumbers);            

            Console.WriteLine("Нечетни числа:");
            PrintNumbers(oddNumbers);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Четни числа:");
            PrintNumbers(evenNumbers);
        }

        private static void PrintNumbers(List<int> numbers)
        {
            Console.WriteLine(string.Join(", ", numbers));
        }

        private static void FilterElements(List<int> numbers, List<int> oddNumbers, List<int> evenNumbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                    continue;
                }

                oddNumbers.Add(numbers[i]);
            }
        }

        private static void GenerateList(List<int> numbers)
        {
            string command = Console.ReadLine();

            while (command != "End")
            {
                int number;

                if (int.TryParse(command, out number))
                {
                    numbers.Add(number);

                    Console.WriteLine("За да спрете да въвеждате числа въведете \"End\"");
                }
                else
                {
                    Console.WriteLine("Ivalid number!");
                }

                command = Console.ReadLine();
            }
        }
    }
}



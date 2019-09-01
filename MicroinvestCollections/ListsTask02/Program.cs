using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListsTask02
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            GenerateList(numbers);

            ReverseList(numbers);

            PrintList(numbers);
        }

        private static void PrintList(List<int> numbers)
        {
            Console.WriteLine(string.Join(", ", numbers));
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

                    Console.OutputEncoding = Encoding.Unicode;
                    Console.WriteLine("За да спрете да въвеждате числа въведете \"End\"");
                }
                else
                {
                    Console.WriteLine("Ivalid number!");
                }

                command = Console.ReadLine();
            }
        }

        private static void ReverseList(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int tempElement = numbers[i];

                numbers[i] = numbers[numbers.Count - 1 - i];
                numbers[numbers.Count - 1 - i] = tempElement;
            }
        }
    }
}

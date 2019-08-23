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

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
                else
                {
                    oddNumbers.Add(numbers[i]);
                }
            }

            Console.WriteLine("Нечетни числа:");
            Console.WriteLine(string.Join(", ", oddNumbers));

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Четни числа:");
            Console.WriteLine(string.Join(", ", evenNumbers));
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



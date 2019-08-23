using System;
using System.Collections.Generic;
using System.Text;

namespace ListsTask03
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            GenerateList(numbers);

            int sum = 0;

            GetSum(ref sum, numbers);

            Console.WriteLine($"Total sum of number after given element : {sum}");
        }

        private static void GetSum(ref int sum, List<int> numbers)
        {
            int element;

            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Въведете търсен елемент");

            if (int.TryParse(Console.ReadLine(), out element))
            {
                if (!numbers.Contains(element))
                {
                    Console.OutputEncoding = Encoding.Unicode;
                    Console.WriteLine("Въведеният елемент не съществува в колекцията!");
                }
                else
                {
                    int startIndex = numbers.IndexOf(element) + 1;

                    for (int i = startIndex; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }
                }
            }
            else
            {
                Console.WriteLine("Ivalid number!");
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
    }
}

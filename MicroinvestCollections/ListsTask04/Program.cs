using System;
using System.Collections.Generic;
using System.Text;

namespace ListsTask04
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            List<int> numbers = new List<int>();

            GenerateList(numbers);

            int sum = 0;

            GetSumBetweenTwoElements(ref sum, numbers);

            PrintSum(ref sum);
        }

        private static void PrintSum(ref int sum)
        {
            Console.WriteLine($"Total sum of number after given element : {sum}");
        }

        private static void GetSumBetweenTwoElements(ref int sum, List<int> numbers)
        {
            int firstElement;
            int secondElement;

            Console.WriteLine("Въведете търсените елементи");

            if (int.TryParse(Console.ReadLine(), out firstElement) && int.TryParse(Console.ReadLine(), out secondElement))
            {
                if (!numbers.Contains(firstElement) || !numbers.Contains(secondElement))
                {
                    Console.WriteLine("Въведеният елемент не съществува в колекцията!");
                }
                else
                {
                    int startIndex = numbers.IndexOf(firstElement) + 1;
                    int endIndex = numbers.IndexOf(secondElement);

                    for (int i = startIndex; i < endIndex; i++)
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


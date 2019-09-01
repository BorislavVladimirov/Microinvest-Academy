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

            GenerateList(numbers);

            Console.WriteLine("Въведете индекс и елемент");

            RemoveElementAtIndex(numbers);

            PrintNumbers(numbers);
        }

        private static void PrintNumbers(List<int> numbers)
        {
            Console.WriteLine(string.Join(", ", numbers));
        }

        private static void RemoveElementAtIndex(List<int> numbers)
        {
            int element;
            int index;

            if (int.TryParse(Console.ReadLine(), out index) && int.TryParse(Console.ReadLine(), out element))
            {
                if (index < 0 || index > numbers.Count - 1)
                {
                    Console.WriteLine("Invalid index!");
                    return;
                }

                if (numbers[index] != element)
                {
                    Console.WriteLine("Число на дадения индекс на е равно на подаденото число");
                    return;
                }

                numbers.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Ivalid number");
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



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

            numbers.Sort();

            if (numbers.Count < 3)
            {
                Console.WriteLine("Колекцията трябва има поне 3 елемента");
            }
            else
            {
                Console.Write("Третият най-малък елемент: ");
                Console.WriteLine(numbers[2]);
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



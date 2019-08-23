using System;
using System.Collections.Generic;
using System.Linq;
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

            Console.WriteLine("Въведете търсеното число и заместващ елемент");

            int newNumber;
            int elementToCompare;

            if (int.TryParse(Console.ReadLine(), out elementToCompare) && int.TryParse(Console.ReadLine(), out newNumber))
            {
                //numbers = numbers.Select(n => n == elementToCompare ? newNumber : n).ToList();

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == elementToCompare)
                    {
                        numbers[i] = newNumber;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }

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



using System;
using System.Collections.Generic;
using System.Text;

namespace ListsTask02
{
    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<int> numbers = new List<int>();

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

            ReverseList(numbers);

            Console.WriteLine(string.Join(", ", numbers));
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

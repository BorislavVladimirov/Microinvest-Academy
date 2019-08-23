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

            for (int i = 0; i < numbers.Count; i++)
            {
                int countOfOccurance = 0;

                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        countOfOccurance++;
                    }
                }

                if (countOfOccurance == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
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



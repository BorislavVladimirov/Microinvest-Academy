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

            List<int> firstNumbers = new List<int>();
            List<int> secondNumbers = new List<int>();

            GenerateList(firstNumbers);

            Console.WriteLine("Въведете следващите числа");

            GenerateList(secondNumbers);

            firstNumbers.AddRange(secondNumbers);
            
            OrderList(firstNumbers);

            PrintList(firstNumbers);
        }

        private static void PrintList(List<int> firstNumbers)
        {
            Console.WriteLine(string.Join(", ", firstNumbers));
        }

        private static void OrderList(List<int> firstNumbers)
        {
            bool isSwaped = true;

            while (isSwaped == true)
            {
                isSwaped = false;

                for (int i = 0; i < firstNumbers.Count - 1; i++)
                {
                    if (firstNumbers[i] > firstNumbers[i + 1])
                    {
                        int tempElement = firstNumbers[i];

                        firstNumbers[i] = firstNumbers[i + 1];
                        firstNumbers[i + 1] = tempElement;

                        isSwaped = true;
                    }
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



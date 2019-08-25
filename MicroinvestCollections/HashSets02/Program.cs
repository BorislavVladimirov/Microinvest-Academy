using System;
using System.Collections.Generic;
using System.Text;

namespace HashSets02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            HashSet<int> hashNumbers = new HashSet<int>();

            GenerateHashSet(hashNumbers);

            Console.WriteLine("Въведете число за сравнение");

            FindGreaterValues(hashNumbers);
        }

        private static void FindGreaterValues(HashSet<int> hashNumbers)
        {
            int elementToCompare;

            if (int.TryParse(Console.ReadLine(), out elementToCompare))
            {
                foreach (var number in hashNumbers)
                {
                    if (number > elementToCompare)
                    {
                        Console.Write(number + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }

        private static void GenerateHashSet(HashSet<int> hashNumbers)
        {
            string command = Console.ReadLine();

            while (command != "End")
            {
                int number;

                if (int.TryParse(command, out number))
                {
                    hashNumbers.Add(number);

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashSets03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            HashSet<int> hashNumbers = new HashSet<int>();

            GenerateHashSet(hashNumbers);

            Console.WriteLine(string.Join(", ", hashNumbers.OrderByDescending(n => n)));
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
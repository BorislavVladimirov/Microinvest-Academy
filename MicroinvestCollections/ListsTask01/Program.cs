using System;
using System.Collections.Generic;
using System.Text;

namespace ListsTask01
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

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}

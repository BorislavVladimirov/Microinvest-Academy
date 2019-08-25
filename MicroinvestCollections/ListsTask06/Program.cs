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

            List<int> resultNumbers = new List<int>();

            GenerateList(firstNumbers);

            Console.WriteLine("Въведете следващите числа");

            GenerateList(secondNumbers);

            resultNumbers.AddRange(firstNumbers);
            resultNumbers.AddRange(secondNumbers);
            
            OrderList(resultNumbers);           

            Console.WriteLine(string.Join(", ", resultNumbers));
        }

        private static void OrderList(List<int> resultNumbers)
        {
            bool isSwaped = true;

            while (isSwaped == true)
            {
                isSwaped = false;

                for (int i = 0; i < resultNumbers.Count - 1; i++)
                {
                    if (resultNumbers[i] > resultNumbers[i + 1])
                    {
                        int tempElement = resultNumbers[i];

                        resultNumbers[i] = resultNumbers[i + 1];
                        resultNumbers[i + 1] = tempElement;

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



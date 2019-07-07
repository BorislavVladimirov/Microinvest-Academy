using System;
using System.Collections.Generic;

namespace _07nNumsFrom3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 3; i <= int.MaxValue; i+= 3)
            {
                if (number == 0)
                {
                    break;
                }

                numbers.Add(i);

                number--;
            }

            Console.Write(string.Join(",", numbers));
        }
    }
}

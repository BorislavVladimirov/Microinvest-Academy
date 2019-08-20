using System;

namespace TestProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            //IncrementNumber(number);

            //Console.WriteLine(number);

            Console.WriteLine(IncrementNumber(number));

            //Console.WriteLine(number);
        }

        private static int IncrementNumber(int number)
        {
            //Console.WriteLine(++number);

            if (number == 10)
            {
                return number;
            }

            return IncrementNumber(++number);
        }
    }
}

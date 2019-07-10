using System;
using System.Linq;

namespace _01SumOfNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            Console.WriteLine(sum);
        }
    }
}

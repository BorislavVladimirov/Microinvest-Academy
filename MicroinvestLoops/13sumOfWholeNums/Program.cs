using System;

namespace _13sumOfWholeNums
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int sumToCheck = int.Parse(Console.ReadLine());

            char[] nums = new char[3];

            for (int i = 101; i < 999; i++)
            {
                nums = i.ToString().ToCharArray();

                int first = int.Parse(nums[0].ToString());
                int second = int.Parse(nums[1].ToString());
                int third = int.Parse(nums[2].ToString());

                int sum = first + second + third;

                if (sum == sumToCheck)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

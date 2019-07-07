using System;

namespace _12wholeNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char[] nums = new char[3];

            for (int i = 101; i < 999; i++)
            {
                nums = i.ToString().ToCharArray();

                if (nums[0] != nums[1] && nums[0] != nums[2] && nums[1] != nums[2])
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

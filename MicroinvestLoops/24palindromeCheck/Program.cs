using System;

namespace _24palindromeCheck
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());           

            if (IsInRange(number))
            {
                char[] tempArr = number.ToString().ToCharArray();

                bool IsPalingrom = true;
                int count = 0;

                do
                {
                    if (tempArr[count] != tempArr[tempArr.Length - 1 - count])
                    {
                        IsPalingrom = false;
                        break;
                    }

                    count++;

                } while (count < tempArr.Length / 2);

                if (IsPalingrom)
                {
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    Console.WriteLine("числото е палиндром");
                }
                else
                {
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    Console.WriteLine("числото не е палиндром");
                }
            }
        }

        private static bool IsInRange(int number)
        {
            if (number >= 10 && number <= 30000)
            {
                return true;
            }

            return false;
        }
    }
}

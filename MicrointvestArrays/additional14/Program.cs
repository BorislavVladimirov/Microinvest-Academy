using System;
using System.Linq;

namespace additional14
{
   public class Program
    {
        public static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] secondArr = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(Compare(firstArr, secondArr));
        }

        private static bool Compare(int[] firstArr, int[] secondArr)
        {
            if (firstArr.Length == secondArr.Length)
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (firstArr[i]  != secondArr[i])
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}

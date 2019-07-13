using System;
using System.Linq;

namespace additional15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] secondArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(Compare(firstArr, secondArr));
        }

        private static bool Compare(int[] firstArr, int[] secondArr)
        {
            if (firstArr.Length != secondArr.Length)
            {
                return false;
            }

            foreach (var num in firstArr)
            {
                if (!secondArr.Contains(num))
                {
                    return false;
                }
            }

            return true;
        }
    }
}

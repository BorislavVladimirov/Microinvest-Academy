using System;

namespace Task03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string stringToCheck = Console.ReadLine();

            int startingIndex = 0;
            Console.WriteLine(CheckIsPalindrome(stringToCheck, startingIndex));
        }

        private static bool CheckIsPalindrome(string stringToCheck, int currentFrontIndex)
        {
            int currentBackIndex = stringToCheck.Length - 1 - currentFrontIndex;

            if (stringToCheck[currentFrontIndex] != stringToCheck[currentBackIndex])
            {
                return false;
            }

            if (currentFrontIndex == stringToCheck.Length / 2)
            {
                return true;
            }

            return CheckIsPalindrome(stringToCheck, currentFrontIndex + 1);
        }
    }
}

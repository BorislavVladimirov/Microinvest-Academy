using System;

namespace _05passwordValidation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char[] password = Console.ReadLine().ToCharArray();

            Console.WriteLine(IsPasswordValid(password));
        }

        private static bool IsPasswordValid(char[] password)
        {
            bool IsContainingDigit = false;
            bool IsContainingLowerLetter = false;
            bool IsContainingUpperLetter = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    IsContainingDigit = true;
                }
                else if (char.IsUpper(password[i]))
                {
                    IsContainingUpperLetter = true;
                }
                else if (char.IsLower(password[i]))
                {
                    IsContainingLowerLetter = true;
                }
            }

            if (password.Length >= 6 
                && IsContainingDigit
                && IsContainingUpperLetter 
                && IsContainingLowerLetter)
            {
                return true;
            }

            return false;
        }
    }
}

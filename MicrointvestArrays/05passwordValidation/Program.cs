using System;
using System.Collections.Generic;

namespace _05passwordValidation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char[] password = Console.ReadLine().ToCharArray();

            HashSet<string> unfulfilledCriteries = new HashSet<string>(); 

            IsPasswordValid(password, unfulfilledCriteries);

            if (unfulfilledCriteries.Count == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.WriteLine($"False, Паролата не изпълнява следните условия: " +
                    $"{string.Join(", ", unfulfilledCriteries)}");
            }
        }

        private static void IsPasswordValid(char[] password, HashSet<string> unfulfilledCriteries)
        {
            if (password.Length < 6)
            {
                unfulfilledCriteries.Add("минимална дължина от 6 символа");
            }

            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsDigit(password[i]))
                {
                    unfulfilledCriteries.Add("поне една цифра");
                }
                if (!char.IsUpper(password[i]))
                {
                    unfulfilledCriteries.Add("поне една голяма буква");
                }
                if (!char.IsLower(password[i]))
                {
                    unfulfilledCriteries.Add("поне една малка буква");
                }
                if (char.IsLetterOrDigit(password[i]))
                {
                    unfulfilledCriteries.Add("поне един символ различен от цифра и буква");
                }
            }
        }
    }
}

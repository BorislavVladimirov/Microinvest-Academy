using System;
using System.Collections.Generic;

namespace _05passwordValidation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char[] password = Console.ReadLine().ToCharArray();

            List<string> unfulfilledCriteries = new List<string> {
                "минимална дължина от 6 символа"
                , "поне една цифра"
                , "поне една голяма буква"
                ,"поне една малка буква"
                ,"поне един символ различен от цифра и буква"};

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

        private static void IsPasswordValid(char[] password, List<string> unfulfilledCriteries)
        {
            if (password.Length >= 6)
            {
                unfulfilledCriteries.Remove("минимална дължина от 6 символа");
            }

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    unfulfilledCriteries.Remove("поне една цифра");
                }
                if (char.IsUpper(password[i]))
                {
                    unfulfilledCriteries.Remove("поне една голяма буква");
                }
                if (char.IsLower(password[i]))
                {
                    unfulfilledCriteries.Remove("поне една малка буква");
                }
                if (!char.IsLetterOrDigit(password[i]))
                {
                    unfulfilledCriteries.Remove("поне един символ различен от цифра и буква");
                }
            }
        }
    }
}

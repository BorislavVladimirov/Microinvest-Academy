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
                  "поне една цифра"
                , "поне една малка буква"
                , "поне една голяма буква"
                , "минимална дължина от 6 символа"
                , "поне един символ различен от цифра и буква" };

            IsPasswordValid(password, unfulfilledCriteries);

            if (unfulfilledCriteries.Count == 0)
            {
                Console.WriteLine(IsPasswordValid(password, unfulfilledCriteries));
            }
            else
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.WriteLine($"{IsPasswordValid(password, unfulfilledCriteries)}, Паролата не изпълнява следните условия: " +
                    $"{string.Join(", ",unfulfilledCriteries)}");
            }
        }

        private static bool IsPasswordValid(char[] password, List<string> unfulfilledCriteries)
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
                else if (char.IsUpper(password[i]))
                {
                    unfulfilledCriteries.Remove("поне една голяма буква");
                }
                else if (char.IsLower(password[i]))
                {
                    unfulfilledCriteries.Remove("поне една малка буква");
                }
                else if (!char.IsLetterOrDigit(password[i]))
                {
                    unfulfilledCriteries.Remove("поне един символ различен от цифра и буква");
                }
            }

            if (unfulfilledCriteries.Count == 0)
            {
                return true;
            }

            return false;
        }
    }
}

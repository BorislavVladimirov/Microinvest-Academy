using System;
using System.Text;

namespace Task05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string a;

            a = "adsasd";
            Console.InputEncoding = Encoding.Unicode;
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine(CompareStrings(firstString, secondString));
        }

        private static StringBuilder CompareStrings(string firstString, string secondString)
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool IsMatchFound = false;

            char charToCompare = ' ';
            int index = -1;

            char[] firstStrAsArray = firstString.ToCharArray();
            char[] secondStrAsArray = secondString.ToCharArray();

            charToCompare = secondStrAsArray[0];
            for (int i = 0; i < firstStrAsArray.Length; i++)
            {
                if (firstStrAsArray[i] == charToCompare && IsMatchFound == false)
                {
                    index = i;

                    for (int j = 0; j < firstStrAsArray.Length; j++)
                    {
                        if (j == index)
                        {
                            stringBuilder.AppendLine(secondString);
                            IsMatchFound = true;
                        }
                        else
                        {
                            stringBuilder.AppendLine(firstStrAsArray[j].ToString());
                        }

                        stringBuilder.AppendLine();
                    }
                }
            }

            charToCompare = firstStrAsArray[0];
            for (int i = 0; i < secondStrAsArray.Length; i++)
            {
                if (secondStrAsArray[i] == charToCompare && IsMatchFound == false)
                {
                    index = i;

                    for (int j = 0; j < secondStrAsArray.Length; j++)
                    {
                        if (j == index)
                        {
                            stringBuilder.AppendLine(firstString);
                            IsMatchFound = true;
                        }
                        else
                        {
                            stringBuilder.AppendLine(secondStrAsArray[j].ToString());
                        }

                        stringBuilder.AppendLine();
                    }
                }
            }

            if (stringBuilder.Length == 0)
            {
                stringBuilder.Append("Не може да бъде изведен резултат!");
            }

            return stringBuilder;
        }
    }
}

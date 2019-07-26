using System;
using System.Linq;
using System.Text;

namespace Task06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            string[] inputString = Console.ReadLine()
                .Split()
                .ToArray();

            for (int i = 0; i < inputString.Length; i++)
            {
                char[] currenWord = inputString[i].ToCharArray();
                currenWord[0] = char.Parse(currenWord[0].ToString().ToUpper());

                for (int j = 1; j < currenWord.Length; j++)
                {
                    currenWord[j] = char.Parse(currenWord[j].ToString().ToLower());
                }

                inputString[i] = string.Join("", currenWord);
            }

            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine(string.Join(" ",inputString));
        }
    }
}

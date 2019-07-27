using System;

namespace task10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            char[] inputAsArray = inputString.ToCharArray();

            for (int i = 0; i < inputAsArray.Length; i++)
            {
                int currentChar = inputAsArray[i];

                inputAsArray[i] = (char)(currentChar + 5);
            }

            Console.WriteLine(string.Join("",inputAsArray));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace task09
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char[] inputString = Console.ReadLine().ToCharArray();
            List<int> numbers = new List<int>();

            for (int i = 0; i < inputString.Length; i++)
            {
                char currentChar = inputString[i];
                string numberAsString = string.Empty;

                if (char.IsDigit(currentChar))
                {

                }
            }
        }
    }
}

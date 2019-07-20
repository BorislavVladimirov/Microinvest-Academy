using System;
using System.Linq;

namespace additional10
{
    public class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = Console.ReadLine().ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                int index = -1;
                int minValue = int.MaxValue;

                for (int j = i; j < charArray.Length; j++)
                {
                    int currentChar = (int)charArray[j];

                    if (currentChar < minValue)
                    {
                        minValue = currentChar;
                        index = j;
                    }
                }

                charArray[index] = charArray[i];
                charArray[i] = (char)minValue;
            }

            //Console.WriteLine(string.Join("", charArray.OrderBy(x => (int)x)));
            Console.WriteLine(string.Join("", charArray));
        }
    }
}

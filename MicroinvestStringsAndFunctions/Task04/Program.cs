using System;
using System.Linq;

namespace Task04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(',')
                .ToArray();

            int biggestASCIISum = int.MinValue;
            int indexOfName = -1;

            for (int i = 0; i < names.Length; i++)
            {
                int currentCharsSum = 0;
                char[] currentName = names[i].Trim().ToCharArray();

                for (int j = 0; j < currentName.Length; j++)
                {
                    currentCharsSum += currentName[j];
                }

                if (currentCharsSum > biggestASCIISum)
                {
                    biggestASCIISum = currentCharsSum;
                    indexOfName = i;
                }
            }

            Console.WriteLine(names[indexOfName]);
        }
    }
}

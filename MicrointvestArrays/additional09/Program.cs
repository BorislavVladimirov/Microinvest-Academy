using System;

namespace additional09
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string stringToReverse = Console.ReadLine();
            char[] array = stringToReverse.ToCharArray();

            for (int i = 0; i < array.Length / 2; i++)
            {
                char tempChar = array[i];

                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = tempChar;
            }

            Console.WriteLine(string.Join("",array));
        }
    }
}

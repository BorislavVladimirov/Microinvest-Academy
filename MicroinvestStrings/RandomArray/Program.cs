using System;

namespace RandomArray
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            int length = 0;

            if (int.TryParse(Console.ReadLine(), out length))
            {
                decimal[] array = new decimal[length];

                GenerateArray(array);
            }
            else
            {
                Console.WriteLine("Ivalid input!");
            }
        }

        private static void GenerateArray(decimal[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Random random = new Random();
                decimal currentNumber = (decimal)Math.Sqrt(random.Next(10000, 285156));

                array[i] = currentNumber;
            }
        }
    }
}

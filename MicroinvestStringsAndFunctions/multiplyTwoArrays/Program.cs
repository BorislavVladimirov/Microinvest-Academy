using System;

namespace multiplyTwoArrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal[] firstArray = new decimal[10];
            decimal[] secondArray = new decimal[10];

            GenerateArrays(firstArray, secondArray);

            Console.WriteLine(multiplyTwoArrays(firstArray, secondArray));
        }

        private static void GenerateArrays(decimal[] firstArray, decimal[] secondArray)
        {
            for (int i = 0; i < 10; i++)
            {
                firstArray[i] = i;
                secondArray[i] = i;
            }
        }

        private static decimal multiplyTwoArrays(decimal[] firstArray, decimal[] secondArray)
        {
            decimal result = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                result += firstArray[i] * secondArray[i];
            }

            return result;
        }
    }
}

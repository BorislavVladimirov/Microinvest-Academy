using System;

namespace _17square
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tempArr = input.Split();

            int lenght = int.Parse(tempArr[0]);
            string symbol = tempArr[1];

            if (IsInRange(lenght))
            {
                for (int i = 0; i < lenght; i++)
                {
                    if (i == 0)
                    {
                        for (int j = 0; j < lenght; j++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }

                    else if (i != 0 && i < lenght - 1)
                    {
                        Console.Write("*");

                        for (int k = 0; k < lenght - 2; k++)
                        {
                            Console.Write(symbol);
                        }

                        Console.Write("*");

                        Console.WriteLine();
                    }

                    else if (i == lenght - 1)
                    {
                        for (int j = 0; j < lenght; j++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                }
            }
        }

        private static bool IsInRange(int lenght)
        {
            if (lenght >= 3 && lenght <= 20)
            {
                return true;
            }

            return false;
        }
    }
}

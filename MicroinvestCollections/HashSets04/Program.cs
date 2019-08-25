using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace HashSets04
{
    

    namespace HashSets03
    {
        public class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.Unicode;

                HashSet<int> firstHashNumbers = new HashSet<int>();
                HashSet<int> secondHashNumbers = new HashSet<int>();

                GenerateHashSet(firstHashNumbers);

                Console.WriteLine("Моля въведете втората поредица числа");

                GenerateHashSet(secondHashNumbers);

                if (IsEqual(firstHashNumbers, secondHashNumbers))
                {
                    Console.WriteLine("The two hashSets contain equal elements");
                }
                else
                {
                    Console.WriteLine("The two hashSets don't contain equal elements");
                }
            }

            private static bool IsEqual(HashSet<int> firstHashNumbers, HashSet<int> secondHashNumbers)
            {
                if (firstHashNumbers.SetEquals(secondHashNumbers))
                {
                    return true;
                }

                return false;
            }

            private static void GenerateHashSet(HashSet<int> hashNumbers)
            {
                string command = Console.ReadLine();

                while (command != "End")
                {
                    int number;

                    if (int.TryParse(command, out number))
                    {
                        hashNumbers.Add(number);

                        Console.WriteLine("За да спрете да въвеждате числа въведете \"End\"");
                    }
                    else
                    {
                        Console.WriteLine("Ivalid number!");
                    }

                    command = Console.ReadLine();
                }
            }
        }
    }

}

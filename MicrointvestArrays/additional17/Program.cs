using System;
using System.Collections.Generic;
using System.Linq;

namespace additional17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstStrinng = Console.ReadLine();
            string secondString = Console.ReadLine();

            //the "easy" way
            //CompareTwoStrings(firstStrinng, secondString);
            
            Queue<string> queue = new Queue<string>();
            CompareStrings(firstStrinng, secondString, queue);
        }

        private static void CompareTwoStrings(string firstStrinng, string secondString)
        {
            int result = string.Compare(firstStrinng, secondString);

            if (result == -1)
            {
                Console.WriteLine(firstStrinng);
                Console.WriteLine(secondString);
            }
            else if (result == 0)
            {
                Console.WriteLine("Strings are equal.");
            }
            else if (result == 1)
            {
                Console.WriteLine(secondString);
                Console.WriteLine(firstStrinng);
            }
        }

        private static void CompareStrings(string firstStrinng, string secondString, Queue<string> queue)
        {
            // escaping "IndexOutOfRangeException" if the two lengths are different 
            for (int i = 0; i < Math.Min(firstStrinng.Length, secondString.Length); i++)
            {
                if (firstStrinng[i] > secondString[i])
                {
                    queue.Enqueue(secondString);
                    queue.Enqueue(firstStrinng);
                    break;
                }
                else if (firstStrinng[i] < secondString[i])
                {
                    queue.Enqueue(firstStrinng);
                    queue.Enqueue(secondString);
                    break;
                }
            }

            //in case we have 2 different lengths but the longer string contains the same characters as in the shorter one
            //example:
            //abcd
            //abc
            if (!queue.Any())
            {
                if (firstStrinng.Length > secondString.Length)
                {
                    queue.Enqueue(secondString);
                    queue.Enqueue(firstStrinng);
                }
                else
                {
                    queue.Enqueue(firstStrinng);
                    queue.Enqueue(secondString);
                }
            }

            while (queue.Any())
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}

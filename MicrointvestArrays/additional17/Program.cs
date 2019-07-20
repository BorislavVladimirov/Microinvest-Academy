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
            
            //CompareTwoStrings(firstStrinng, secondString);
            
            Queue<string> queueOfStrings = new Queue<string>();
            CompareStrings(firstStrinng, secondString, queueOfStrings);

            while (queueOfStrings.Any())
            {
                Console.WriteLine(queueOfStrings.Dequeue());
            }
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

        private static void CompareStrings(string firstStrinng, string secondString, Queue<string> queueOfStrings)
        {
            // escaping "IndexOutOfRangeException" if the two lengths are different 
            for (int i = 0; i < Math.Min(firstStrinng.Length, secondString.Length); i++)
            {
                if (firstStrinng[i] >= secondString[i])
                {
                    queueOfStrings.Enqueue(secondString);
                    queueOfStrings.Enqueue(firstStrinng);
                    break;
                }
                else if (firstStrinng[i] < secondString[i])
                {
                    queueOfStrings.Enqueue(firstStrinng);
                    queueOfStrings.Enqueue(secondString);
                    break;
                }
            }
        }
    }
}

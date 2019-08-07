using System;
using System.Collections.Generic;
using System.Linq;

namespace RadixSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            //test numbers 322 1 10 9680 577 9420 7 5622 4793 2030 3138 82 2599 743 4127

            Queue<int>[] queues = new Queue<int>[10];

            for (int i = 0; i < queues.Length; i++)
            {
                queues[i] = new Queue<int>();
            }

            SortNumbers(numbers, queues);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void SortNumbers(int[] numbers, Queue<int>[] queues)
        {
            int longestNumberLength = numbers.OrderByDescending(n => n).FirstOrDefault().ToString().Length;

            for (int i = 0; i < longestNumberLength; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    string currentNumber = numbers[j].ToString();
                    int currentIndex = currentNumber.Length - 1 - i;

                    if (currentIndex < 0)
                    {
                        currentIndex = 0;
                        queues[0].Enqueue(int.Parse(currentNumber));
                        continue;
                    }

                    switch (currentNumber[currentIndex])
                    {
                        case '0':
                            queues[0].Enqueue(int.Parse(currentNumber));
                            break;
                        case '1':
                            queues[1].Enqueue(int.Parse(currentNumber));
                            break;
                        case '2':
                            queues[2].Enqueue(int.Parse(currentNumber));
                            break;
                        case '3':
                            queues[3].Enqueue(int.Parse(currentNumber));
                            break;
                        case '4':
                            queues[4].Enqueue(int.Parse(currentNumber));
                            break;
                        case '5':
                            queues[5].Enqueue(int.Parse(currentNumber));
                            break;
                        case '6':
                            queues[6].Enqueue(int.Parse(currentNumber));
                            break;
                        case '7':
                            queues[7].Enqueue(int.Parse(currentNumber));
                            break;
                        case '8':
                            queues[8].Enqueue(int.Parse(currentNumber));
                            break;
                        case '9':
                            queues[9].Enqueue(int.Parse(currentNumber));
                            break;
                    }
                }

                RearangeArrayOfNumbers(queues, numbers);
            }
        }

        private static void RearangeArrayOfNumbers(Queue<int>[] queues, int[] numbers)
        {
            int counterOfXImdexOfNumbersArray = 0;

            for (int j = 0; j < queues.Length; j++)
            {
                Queue<int> currentQueueByIndex = queues[j];

                while (currentQueueByIndex.Any())
                {
                    numbers[counterOfXImdexOfNumbersArray++] = currentQueueByIndex.Dequeue();
                }
            }
        }
    }
}

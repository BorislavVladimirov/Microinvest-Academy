using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackAndQueueTask01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Queue<int> queueNumbers = new Queue<int>();

            GenerateQueue(queueNumbers);

            RemoveMiddleQueueElement(queueNumbers);



            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Въведете следващата поредица от числа");

            Stack<int> stackNumbers = new Stack<int>();

            GenerateStack(stackNumbers);

            RemoveMiddleElementInStack(stackNumbers);
        }

        private static void RemoveMiddleElementInStack(Stack<int> stackNumbers)
        {
            Stack<int> resultStack = new Stack<int>();

            int middleIndex = stackNumbers.Count / 2;
            int initialCount = stackNumbers.Count();

            for (int i = 0; i < initialCount; i++)
            {
                if (i == middleIndex)
                {
                    stackNumbers.Pop();
                    continue;
                }

                resultStack.Push(stackNumbers.Pop());
            }

            foreach (var number in resultStack)
            {
                Console.Write(number + " ");
            }
        }

        private static void RemoveMiddleQueueElement(Queue<int> queueNumbers)
        {
            Queue<int> resultQueue = new Queue<int>();

            int middleIndex = queueNumbers.Count / 2;
            int initialCount = queueNumbers.Count();

            for (int i = 0; i < initialCount; i++)
            {
                if (i == middleIndex)
                {
                    queueNumbers.Dequeue();
                    continue;
                }

                resultQueue.Enqueue(queueNumbers.Dequeue());
            }

            foreach (var number in resultQueue)
            {
                Console.Write(number + " ");
            }
        }

        private static void GenerateStack(Stack<int> stackNumbers)
        {
            string command = Console.ReadLine();

            while (command != "End")
            {
                int number;

                if (int.TryParse(command, out number))
                {
                    stackNumbers.Push(number);

                    Console.WriteLine("За да спрете да въвеждате числа въведете \"End\"");
                }
                else
                {
                    Console.WriteLine("Ivalid number!");
                }

                command = Console.ReadLine();
            }
        }

        private static void GenerateQueue(Queue<int> queueNumbers)
        {
            string command = Console.ReadLine();

            while (command != "End")
            {
                int number;

                if (int.TryParse(command, out number))
                {
                    queueNumbers.Enqueue(number);

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

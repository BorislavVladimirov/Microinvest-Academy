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

            RemoveQeueuElementsAfterIndex(queueNumbers);




            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Въведете следващата поредица от числа");

            Stack<int> stackNumbers = new Stack<int>();

            GenerateStack(stackNumbers);

            RemoveStackElementsAfterIndex(stackNumbers);
        }

        private static void RemoveStackElementsAfterIndex(Stack<int> stackNumbers)
        {
            Stack<int> resultStack = new Stack<int>();

            int initialCount = stackNumbers.Count();

            Console.WriteLine("Въведете индекс");

            int index;

            if (int.TryParse(Console.ReadLine(), out index))
            {
                if (index < 0 || index > initialCount - 1)
                {
                    Console.WriteLine("Invalid index!");
                    return;
                }

                for (int i = 0; i < initialCount; i++)
                {
                    if (i == index)
                    {
                        resultStack.Push(stackNumbers.Pop());
                        break;
                    }

                    resultStack.Push(stackNumbers.Pop());
                }
            }
            else
            {
                Console.WriteLine("Ivalid number");
            }

            PrintStackNumbers(resultStack);
        }

        private static void PrintStackNumbers(Stack<int> resultStack)
        {
            foreach (var number in resultStack)
            {
                Console.Write(number + " ");
            }
        }

        private static void RemoveQeueuElementsAfterIndex(Queue<int> queueNumbers)
        {
            Queue<int> resultQueue = new Queue<int>();

            int initialCount = queueNumbers.Count();

            Console.WriteLine("Въведете индекс");

            int index;

            if (int.TryParse(Console.ReadLine(), out index))
            {
                if (index < 0 || index > initialCount - 1)
                {
                    Console.WriteLine("Invalid index!");
                    return;
                }

                for (int i = 0; i < initialCount; i++)
                {
                    if (i == index)
                    {
                        resultQueue.Enqueue(queueNumbers.Dequeue());
                        break;
                    }

                    resultQueue.Enqueue(queueNumbers.Dequeue());
                }
            }
            else
            {
                Console.WriteLine("Ivalid number");
            }

            PrintQueueNumbers(resultQueue);
        }

        private static void PrintQueueNumbers(Queue<int> resultQueue)
        {
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

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

            Stack<int> stackNumbers = new Stack<int>();

            GenerateStack(stackNumbers);

            PrintStackInReversedOrder(stackNumbers);            

            Console.WriteLine(Environment.NewLine);



            Queue<int> queueNumbers = new Queue<int>();

            GenerateQueue(queueNumbers);

            PrintQueueInReverseOrder(queueNumbers);            
        }

        private static void PrintQueueInReverseOrder(Queue<int> queueNumbers)
        {
            Queue<int> resultQueue = new Queue<int>();

            int initialCount = queueNumbers.Count;

            while (queueNumbers.Any())
            {
                for (int i = 0; i < initialCount; i++)
                {
                    if (i == initialCount - 1)
                    {
                        Console.Write(queueNumbers.Dequeue() + " ");
                    }
                    else
                    {
                        resultQueue.Enqueue(queueNumbers.Dequeue());
                    }

                }

                queueNumbers = resultQueue;
                initialCount--;
            }
        }

        private static void PrintStackInReversedOrder(Stack<int> stackNumbers)
        {
            Stack<int> resultStack = new Stack<int>();

            for (int i = 0; i < stackNumbers.Count; i++)
            {
                resultStack.Push(stackNumbers.Pop());

                i--;
            }

            while (resultStack.Any())
            {
                Console.Write(resultStack.Pop() + " ");
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

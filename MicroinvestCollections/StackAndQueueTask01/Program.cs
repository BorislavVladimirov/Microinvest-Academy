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
            Stack<int> stackNumbers = new Stack<int>();

            GenerateQueue(queueNumbers);

            Console.WriteLine("Въведете числата за Stack-a");

            GenerateStack(stackNumbers);

            PrintQueue(queueNumbers);

            PrintStack(stackNumbers);
        }

        private static void PrintStack(Stack<int> stackNumbers)
        {
            Console.WriteLine("Stack numbers:");

            while (stackNumbers.Any())
            {
                Console.Write(stackNumbers.Pop() + " ");
            }
        }

        private static void PrintQueue(Queue<int> queueNumbers)
        {
            Console.WriteLine("Queue numbers:");

            int initialCount = queueNumbers.Count;

            Queue<int> tempQueue = new Queue<int>();

            while (queueNumbers.Any())
            {
                for (int i = 0; i < initialCount; i++)
                {
                    if (i == initialCount - 1)
                    {
                        Console.Write(queueNumbers.Dequeue() + " ");
                        break;
                    }

                    tempQueue.Enqueue(queueNumbers.Dequeue());
                }

                initialCount--;
                queueNumbers = tempQueue;
            }

            Console.WriteLine(Environment.NewLine);
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

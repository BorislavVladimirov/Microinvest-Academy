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

            Queue<int> resultQueue = new Queue<int>();

            int middleIndex = queueNumbers.Count / 2;
            int initialCount = queueNumbers.Count();

            Console.WriteLine("Въведете индекс");

            int index;

            if (int.TryParse(Console.ReadLine(), out index))
            {
            }
            else
            {
                Console.WriteLine("Ivalid number");
            }

            if (index < 0 || index > initialCount - 1)
            {
                Console.WriteLine("Invalid index!");
            }
            else
            {
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

            foreach (var number in resultQueue)
            {
                Console.Write(number + " ");
            }




            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Въведете следващата поредица от числа");

            Stack<int> stackNumbers = new Stack<int>();

            GenerateStack(stackNumbers);

            Stack<int> resultStack = new Stack<int>();

            middleIndex = stackNumbers.Count / 2;
            initialCount = stackNumbers.Count();


            Console.WriteLine("Въведете индекс");
            
            if (int.TryParse(Console.ReadLine(), out index))
            {
            }
            else
            {
                Console.WriteLine("Ivalid number");
            }

            if (index < 0 || index > initialCount - 1)
            {
                Console.WriteLine("Invalid index!");
            }
            else
            {
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

            foreach (var number in resultStack)
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

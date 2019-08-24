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

            Console.WriteLine("Въведете начален и краен индекс");

            int startIndex;
            int endIndex;
            
            if (int.TryParse(Console.ReadLine(), out startIndex) && int.TryParse(Console.ReadLine(), out endIndex))
            {
                if (ValidateIndexes(startIndex, endIndex, queueNumbers))
                {
                    int index = 0;

                    foreach (var number in queueNumbers)
                    {
                        if (index < startIndex || index > endIndex)
                        {
                            resultQueue.Enqueue(number);
                        }

                        index++;
                    }
                }
            }
            else
            {
                Console.WriteLine("Ivalid number");
            }

            PrintQueue(resultQueue);



            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Въведете следващата поредица от числа");

            Stack<int> stackNumbers = new Stack<int>();

            GenerateStack(stackNumbers);

            Stack<int> resultStack = new Stack<int>();

            Console.WriteLine("Въведете начален и краен индекс");

            if (int.TryParse(Console.ReadLine(), out startIndex) && int.TryParse(Console.ReadLine(), out endIndex))
            {
                if (ValidateIndexes(startIndex, endIndex, stackNumbers))
                {
                    int index = 0;

                    foreach (var number in stackNumbers)
                    {
                        if (index < startIndex || index > endIndex)
                        {
                            resultStack.Push(number);
                        }

                        index++;
                    }
                }
            }
            else
            {
                Console.WriteLine("Ivalid number");
            }

            PrintStack(resultStack);
        }

        private static void PrintStack(Stack<int> resultStack)
        {
            while (resultStack.Any())
            {
                Console.WriteLine(resultStack.Pop() + " ");
            }
        }

        private static bool ValidateIndexes(int startIndex, int endIndex, Stack<int> stackNumbers)
        {
            if (startIndex < 0 || startIndex > stackNumbers.Count - 1 || endIndex < startIndex || endIndex > stackNumbers.Count - 1)
            {
                Console.WriteLine("Invalid index!");

                return false;
            }

            return true;
        }

        private static void PrintQueue(Queue<int> resultQueue)
        {
            while (resultQueue.Any())
            {
                Console.WriteLine(resultQueue.Dequeue() + " ");
            }
        }

        private static bool ValidateIndexes(int startIndex, int endIndex, Queue<int> queueNumbers)
        {
            if (startIndex < 0 || startIndex > queueNumbers.Count - 1 || endIndex < startIndex || endIndex > queueNumbers.Count - 1)
            {
                Console.WriteLine("Invalid index!");

                return false;
            }

            return true;
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

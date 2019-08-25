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

            Console.WriteLine("Недублиращи се числа:");

            PrintUniqueQueueValues(queueNumbers);          



            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Въведете следващата поредица от числа");

            Stack<int> stackNumbers = new Stack<int>();

            GenerateStack(stackNumbers);

            Console.WriteLine("Недублиращи се числа:");

            PrintUnqueStackValues(stackNumbers);       
        }

        private static void PrintUnqueStackValues(Stack<int> stackNumbers)
        {
            Stack<int> removedNumbers = new Stack<int>();

            while (stackNumbers.Any())
            {
                int currentNumber = stackNumbers.Pop();

                if (!stackNumbers.Contains(currentNumber) && !removedNumbers.Contains(currentNumber))
                {
                    Console.Write(currentNumber + " ");
                }

                removedNumbers.Push(currentNumber);
            }
        }

        private static void PrintUniqueQueueValues(Queue<int> queueNumbers)
        {
            for (int i = 0; i < queueNumbers.Count; i++)
            {
                int currentNumber = queueNumbers.Dequeue();

                if (!queueNumbers.Contains(currentNumber))
                {
                    Console.Write(currentNumber + " ");
                }

                queueNumbers.Enqueue(currentNumber);
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

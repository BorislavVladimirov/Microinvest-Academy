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

            Console.WriteLine("Четни числа:");

            PrintEvenNumbersInQueue(queueNumbers);            



            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Въведете следващата поредица от числа");

            Stack<int> stackNumbers = new Stack<int>();

            GenerateStack(stackNumbers);

            Console.WriteLine("Четни числа:");

            PrintEvenNumbersInStack(stackNumbers);            
        }

        private static void PrintEvenNumbersInStack(Stack<int> stackNumbers)
        {
            Stack<int> resultStack = new Stack<int>();

            foreach (var number in stackNumbers)
            {
                resultStack.Push(number);
            }

            foreach (var number in resultStack)
            {
                if (number % 2 == 0)
                {
                    Console.Write(number + " ");
                }
            }
        }

        private static void PrintEvenNumbersInQueue(Queue<int> queueNumbers)
        {
            foreach (var number in queueNumbers)
            {
                if (number % 2 == 0)
                {
                    Console.Write(number + " ");
                }
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

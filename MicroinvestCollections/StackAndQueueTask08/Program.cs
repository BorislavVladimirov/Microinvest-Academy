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

            Console.WriteLine("Нечетни числа:");

            PrintQueueNumbers(queueNumbers);



            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Въведете следващата поредица от числа");

            Stack<int> stackNumbers = new Stack<int>();

            GenerateStack(stackNumbers);

            Console.WriteLine("Нечетни числа:");

            PrintStackNumbers(stackNumbers);          
        }

        private static void PrintStackNumbers(Stack<int> stackNumbers)
        {
            foreach (var number in stackNumbers)
            {
                if (number % 2 != 0)
                {
                    Console.Write(number + " ");
                }
            }
        }

        private static void PrintQueueNumbers(Queue<int> queueNumbers)
        {
            Stack<int> resultQueue = new Stack<int>();

            foreach (var number in queueNumbers)
            {
                if (number % 2 != 0)
                {
                    resultQueue.Push(number);
                }
            }

            Console.WriteLine(string.Join(" ", resultQueue));
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
    
using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionaries01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Dictionary<string, int> phoneBook = new Dictionary<string, int>();

            GeneratePhoneBook(phoneBook);                    

            PrintPhoneBook(phoneBook);
        }

        private static void PrintPhoneBook(Dictionary<string, int> phoneBook)
        {
            foreach (var kvp in phoneBook)
            {
                Console.WriteLine($"Име: {kvp.Key}, телефонен номер: {kvp.Value}");
            }
        }

        private static void GeneratePhoneBook(Dictionary<string, int> phoneBook)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                Console.WriteLine("За да спрете да въвеждате команди въведете \"End\"");

                string[] tokens = input.Split();

                string name = tokens[0];
                int phoneNumber = int.Parse(tokens[1]);

                phoneBook.Add(name, phoneNumber);

                input = Console.ReadLine();
            }
        }
    }
}

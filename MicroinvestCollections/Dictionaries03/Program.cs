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

            Dictionary<string, List<int>> phoneBook = new Dictionary<string, List<int>>();

            GeneratePhoneBook(phoneBook);           

            foreach (var kvp in phoneBook)
            {
                Console.WriteLine($"Име: {kvp.Key}, телефонни номера: {string.Join(", ", kvp.Value)}");
            }
        }

        private static void GeneratePhoneBook(Dictionary<string, List<int>> phoneBook)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                Console.WriteLine("За да спрете да въвеждате команди въведете \"End\"");

                string[] tokens = input.Split();

                string name = tokens[0];
                int phoneNumber = int.Parse(tokens[1]);

                if (!phoneBook.ContainsKey(name))
                {
                    phoneBook.Add(name, new List<int>());
                }

                phoneBook[name].Add(phoneNumber);

                input = Console.ReadLine();
            }
        }
    }
}

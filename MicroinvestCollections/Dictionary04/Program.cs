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

            Console.WriteLine("Въведете номер, който желаете да изтриете");

            RemovePhoneNumber(phoneBook);

            foreach (var kvp in phoneBook)
            {
                Console.WriteLine($"Име: {kvp.Key}, телефонни номера: {string.Join(", ", kvp.Value)}");
            }            
        }

        private static void RemovePhoneNumber(Dictionary<string, List<int>> phoneBook)
        {
            int phoneToBeRemoved;

            if (int.TryParse(Console.ReadLine(), out phoneToBeRemoved))
            {
                string name = string.Empty;
                int phoneNumber = 0;

                foreach (var kvp in phoneBook)
                {
                    foreach (var number in kvp.Value)
                    {
                        if (number == phoneToBeRemoved)
                        {
                            name = kvp.Key;
                            phoneNumber = number;
                        }
                    }
                }
                if (!string.IsNullOrEmpty(name))
                {
                    phoneBook[name].Remove(phoneNumber);
                }
                else
                {
                    Console.WriteLine($"Phone book does not contain user with number {phoneToBeRemoved}");
                    Console.WriteLine(Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Invalid phone number!");
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

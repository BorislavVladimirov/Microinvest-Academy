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

            RemovePeopleWithoutPhoneNumber(phoneBook);            

            PrintPhoneBook(phoneBook);            
        }

        private static void RemovePeopleWithoutPhoneNumber(Dictionary<string, List<int>> phoneBook)
        {
            List<string> peopleToRemove = new List<string>();

            foreach (var kvp in phoneBook)
            {
                if (kvp.Value == null)
                {
                    peopleToRemove.Add(kvp.Key);
                }
            }

            for (int i = 0; i < peopleToRemove.Count; i++)
            {
                phoneBook.Remove(peopleToRemove[i]);
            }
        }

        private static void PrintPhoneBook(Dictionary<string, List<int>> phoneBook)
        {
            foreach (var kvp in phoneBook)
            {
                Console.WriteLine($"Име: {kvp.Key}, телефонен номер: {string.Join(", ", kvp.Value)}");
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

                switch (tokens.Length)
                {
                    case 1:
                        phoneBook.Add(name, null);
                        break;
                    case 2:
                        int phoneNumber = int.Parse(tokens[1]);

                        if (!phoneBook.ContainsKey(name))
                        {
                            phoneBook.Add(name, new List<int>());
                        }

                        phoneBook[name].Add(phoneNumber);
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}

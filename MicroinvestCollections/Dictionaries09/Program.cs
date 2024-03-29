﻿using System;
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

            FindPersonByNumber(phoneBook);
        }

        private static void FindPersonByNumber(Dictionary<string, int> phoneBook)
        {
            int phoneNumberToCompare;

            Console.WriteLine("Въведете желания номер");

            if (int.TryParse(Console.ReadLine(), out phoneNumberToCompare))
            {
                if (!phoneBook.ContainsValue(phoneNumberToCompare))
                {
                    Console.WriteLine($"Phone number \"{phoneNumberToCompare}\" does not exist in the phone book");
                    return;
                }

                foreach (var person in phoneBook)
                {
                    if (person.Value == phoneNumberToCompare)
                    {
                        Console.WriteLine($"Име: {person.Key}, телефонен номер: {string.Join(", ", person.Value)}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
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

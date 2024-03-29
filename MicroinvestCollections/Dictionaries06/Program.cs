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

            Console.WriteLine("Въведете желаното число");

            int number;

            if (int.TryParse(Console.ReadLine(), out number))
            {
                foreach (var kvp in phoneBook)
                {
                    if (kvp.Value.ToString().EndsWith(number.ToString()))
                    {
                        Console.WriteLine($"Име: {kvp.Key}, телефонен номер: {kvp.Value}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Ivalid number");
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> people = new Dictionary<string, int>();

            string[] names = new string[] { "pesho", "gosho", "gosho", "gosho", "strahil" };
            int[] ages = new int[] { 20, 19, 31, 50, 35 };

            for (int i = 0; i < names.Length; i++)
            {
                if (!people.ContainsKey(names[i]))
                {
                    people.Add(names[i], ages[i]);
                }
                else
                {
                    string key = people.Keys
                        .Where(x => x.Contains(names[i]))
                        .OrderByDescending(x => x)
                        .First();


                    if (char.IsDigit(key.ElementAt(key.Length - 1)))
                    {
                        key = key + $"{(int.Parse(key.ElementAt(key.Length - 1).ToString() + 1))}";
                        people.Add(key, ages[i]);
                        continue;
                    }


                    people.Add(key + "1", ages[i]);
                }
            }

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Key} - {person.Value}");
            }

            string[] othernames = new string[] { "grisho", "gosho" };
        }
    }
}

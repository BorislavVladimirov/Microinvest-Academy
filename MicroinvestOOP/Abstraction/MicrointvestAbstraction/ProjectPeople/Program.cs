using ProjectPeople.Models;
using System;
using System.Collections.Generic;

namespace ProjectPeople
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            try
            {
                Person Pesho = new Person("Pesho", 19, true);
                Person Pamela = new Person("Pamela", 89, false);

                Student Dre = new Student("Dr.Dre", 40, true, 5.23);
                Student Tupac = new Student("Tupac", 25, true, 5.23);

                Employee Employee = new Employee("Eminem", 42, true, 2355.3m);
                Employee EmployeeOfTheYear = new Employee("Elizabeth", 27, false, 1m);

                people.Add(Pesho);
                people.Add(Pamela);
                people.Add(Dre);
                people.Add(Tupac);
                people.Add(Employee);
                people.Add(EmployeeOfTheYear);

                foreach (var person in people)
                {
                    Console.WriteLine(person.ShowPersonInfo());
                    Console.WriteLine();
                }

                foreach (var person in people)
                {
                    if (person is Employee)
                    {
                        Console.WriteLine(string.Format("Overtime salary: {0}",
                            (person as Employee).CalculateOvertime(2)));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

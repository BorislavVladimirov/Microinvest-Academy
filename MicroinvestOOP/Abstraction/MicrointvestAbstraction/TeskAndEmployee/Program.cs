using System;
using System.Collections.Generic;
using System.Linq;
using TeskAndEmployee.Models;

namespace TeskAndEmployee
{
    public class Program
    {
        static void Main(string[] args)
        {
            AllWork allWork = new AllWork();
            int daysElapsed = 0;
            List<Employee> employees = new List<Employee>();

            try
            {
                allWork.AddTask(new Task("Oil change", 1));
                allWork.AddTask(new Task("Tyre change", 2));
                allWork.AddTask(new Task("Brakes check", 4));
                allWork.AddTask(new Task("Belt change", 3));
                allWork.AddTask(new Task("Window repair", 10));
                allWork.AddTask(new Task("Brake disk change", 3));
                allWork.AddTask(new Task("Filters change", 1));
                allWork.AddTask(new Task("Engine inspect", 5));
                allWork.AddTask(new Task("Driveshaft change", 7));
                allWork.AddTask(new Task("Paint polish", 12));

                employees.Add(new Employee("Harry Potter"));
                employees.Add(new Employee("Hermione Granger"));
                employees.Add(new Employee("Ron Weasley"));

                while (true)
                {
                    daysElapsed++;

                    foreach (var employee in employees)
                    {
                        Console.WriteLine(employee.StartWorkingDay());
                        Console.WriteLine(employee.SetAllWork(allWork));
                        Console.WriteLine(employee.Work());
                    }

                    if (employees.All(x => x.HoursLeft == 0) || allWork.Tasks.Count == 0)
                    {
                        break;
                    }
                }

                Console.WriteLine($"Days elapsed: {daysElapsed}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

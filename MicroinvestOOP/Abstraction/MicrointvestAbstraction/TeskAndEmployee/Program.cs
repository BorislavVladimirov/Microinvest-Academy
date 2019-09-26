using System;
using System.Collections.Generic;
using System.Linq;
using TeskAndEmployee.Common;
using TeskAndEmployee.Models;

namespace TeskAndEmployee
{
    public class Program
    {
        static void Main(string[] args)
        {
            int daysElapsed = 0;

            AllWork allWork = new AllWork();
            List<Employee> employees = new List<Employee>();

            try
            {
                allWork.AddTask(new Task("Oil change", 1));
                allWork.AddTask(new Task("Tyre change", 2));
                allWork.AddTask(new Task("Brakes check", 4));
                allWork.AddTask(new Task("Belt replace", 3));
                allWork.AddTask(new Task("Window repair", 10));
                allWork.AddTask(new Task("Brake disk replace", 3));
                allWork.AddTask(new Task("Filters change", 1));
                allWork.AddTask(new Task("Engine inspect", 5));
                allWork.AddTask(new Task("Driveshaft replace", 7));
                allWork.AddTask(new Task("Paint polish", 12));

                employees.Add(new Employee("Harry Potter"));
                employees.Add(new Employee("Hermione Granger"));
                employees.Add(new Employee("Ron Weasley"));

                while (true)
                {
                    daysElapsed++;

                    foreach (var employee in employees)
                    {
                        if (employee.CurrentTask == null && allWork.Tasks.Count > 0)
                        {
                            Console.WriteLine(PrintRemainingTasksCount(allWork));
                            Console.WriteLine(employee.StartWorkingDay());
                            Console.WriteLine(employee.SetAllWork(allWork));
                            Console.WriteLine(employee.SetCurrentTask(allWork.GetNextTask()));
                            Console.WriteLine(employee.Work());
                        }
                        // if employee has unfinished task from previous day
                        else if (employee.CurrentTask != null)
                        {
                            Console.WriteLine(PrintRemainingTasksCount(allWork));
                            Console.WriteLine(employee.StartWorkingDay());
                            Console.WriteLine(GlobalConstants.WorkingOnPreviousTask);
                            Console.WriteLine(employee.SetAllWork(allWork));
                            Console.WriteLine(employee.Work());
                            continue;
                        }

                        if (CheckIfWorkIsDone(allWork, employees))
                        {
                            break;
                        }
                    }

                    if (CheckIfWorkIsDone(allWork, employees))
                    {
                        break;
                    }
                }

                Console.WriteLine(GlobalConstants.AllTasksDone);
                Console.WriteLine(string.Format("{0} {1}", GlobalConstants.DaysElapsed, daysElapsed));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static string PrintRemainingTasksCount(AllWork allWork)
        {
            return string.Format("{0} {1}", GlobalConstants.RemainingTasks, allWork.Tasks.Count);
        }

        private static bool CheckIfWorkIsDone(AllWork allWork, List<Employee> employees)
        {
            if (allWork.Tasks.Count == 0 && employees.All(e => e.CurrentTask == null))
            {
                return true;
            }

            return false;
        }
    }
}

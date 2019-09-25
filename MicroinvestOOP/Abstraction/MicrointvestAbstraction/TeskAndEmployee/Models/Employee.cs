using System;
using System.Collections.Generic;
using System.Text;
using TeskAndEmployee.Common;

namespace TeskAndEmployee.Models
{
    public class Employee
    {
        #region Declarations

        private string name;
        #endregion

        #region Initializations
        public Employee(string name)
        {
            this.Name = name;
        }
        #endregion

        #region Properties
        public string Name
        {
            get => name;

            private set
            {
                if (value == name)
                {
                    return;
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidName);
                }

                name = value;
            }
        }

        public Task CurrentTask { get; private set; }

        public int HoursLeft { get; private set; }

        public AllWork AllWork { get; private set; }

        #endregion

        #region Methods
        public string Work()
        {
            if (this.CurrentTask != null)
            {
                while (this.HoursLeft != 0)
                {
                    if (this.HoursLeft < CurrentTask.WorkingHours)
                    {
                        this.CurrentTask.WorkingHours -= this.HoursLeft;
                        this.HoursLeft = 0;

                        return ShowReport();
                    }

                    this.HoursLeft -= this.CurrentTask.WorkingHours;
                    this.CurrentTask.WorkingHours = 0;

                    SetCurrentTask(AllWork.GetNextTask());
                }

                return ShowReport();
            }

            return GlobalConstants.TaskNotAvailable;
        }

        private string ShowReport()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(GetName());
            sb.AppendLine($"TaskName: {this.CurrentTask.Name}");
            sb.AppendLine($"Remaining employee working hours: {GetHoursLeft()}");
            sb.AppendLine($"Ramaining task hours: {this.CurrentTask.WorkingHours}");

            return sb.ToString();
        }

        public string StartWorkingDay()
        {
            this.HoursLeft = GlobalConstants.InitialWorkingHours;

            return GlobalConstants.NewWorkDayHasStarted;
        }

        public string GetName()
        {
            return string.Format("{0} {1}", GlobalConstants.GetName, this.Name);
        }

        public Task GetCurrentTask()
        {
            if (this.CurrentTask == null)
            {
                throw new ArgumentException(GlobalConstants.TaskNotAvailable);
            }

            return this.CurrentTask;
        }

        public string SetCurrentTask(Task task)
        {
            this.CurrentTask = task;
            return GlobalConstants.CurrentTaskSetSuccessfuly;
        }

        public string GetHoursLeft()
        {
            return string.Format("{0} {1}", GlobalConstants.HourseLeft, this.HoursLeft);
        }

        public string SetHoursLeft(int hoursLeft)
        {
            if (hoursLeft < 0 || hoursLeft > 8)
            {
                throw new ArgumentException(GlobalConstants.InvalidWorkingHours);
            }

            this.HoursLeft = hoursLeft;
            return string.Format("{0} {1}", GlobalConstants.SetHourseLeft, this.HoursLeft);

        }

        public AllWork GetAllWork()
        {
            return this.AllWork;
        }

        public string SetAllWork(AllWork allWork)
        {
            this.AllWork = allWork;

            return GlobalConstants.AllWorkSetSuccessfully;
        }
        #endregion
    }
}

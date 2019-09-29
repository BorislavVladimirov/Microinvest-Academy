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
            StringBuilder sb = new StringBuilder();

            while (this.HoursLeft > 0)
            {
                if (this.HoursLeft < CurrentTask.WorkingHours)
                {
                    this.CurrentTask.WorkingHours -= this.HoursLeft;
                    this.HoursLeft = 0;

                    sb.AppendLine(ShowReport());

                    return sb.ToString();
                }

                this.HoursLeft -= this.CurrentTask.WorkingHours;
                this.CurrentTask.WorkingHours = 0;

                sb.AppendLine(ShowReport());

                if (AllWork.Tasks.Count > 0)
                {
                    this.CurrentTask = AllWork.GetNextTask();
                    continue;
                }

                if (CurrentTask.WorkingHours == 0 && AllWork.Tasks.Count == 0)
                {
                    this.CurrentTask = null;
                    return sb.ToString();
                }
            }

            return sb.ToString();
        }

        private string ShowReport()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(GetName());
            sb.AppendLine(string.Format("{0} {1}", GlobalConstants.TaskName, this.CurrentTask.Name));
            sb.AppendLine(string.Format("{0} {1}", GlobalConstants.HoursLeft, GetHoursLeft()));
            sb.AppendLine(string.Format("{0} {1}", GlobalConstants.RemainingTaskHours, this.CurrentTask.WorkingHours));

            return sb.ToString();
        }

        public string StartWorkingDay()
        {
            this.HoursLeft = GlobalConstants.InitialWorkingHours;

            return string.Format("{0} {1}", GlobalConstants.NewWorkDayHasStarted, this.Name);
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
            return string.Format("{0} {1}", GlobalConstants.HoursLeft, this.HoursLeft);
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

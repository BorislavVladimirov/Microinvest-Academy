using System;
using System.Collections.Generic;
using System.Text;
using TeskAndEmployee.Common;

namespace TeskAndEmployee.Models
{
    public class Task
    {
        #region Declarations

        private string name;
        private int workingHours;

        #endregion

        #region Initializations
        public Task(string name, int workingHours)
        {
            Name = name;
            WorkingHours = workingHours;
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

        public int WorkingHours
        {
            get => workingHours;

            set
            {
                if (value == workingHours)
                {
                    return;
                }

                if (value < 0)
                {
                    throw new ArgumentException(GlobalConstants.InvalidWorkingHours);
                }

                workingHours = value;
            }
        }
        #endregion
    }
}

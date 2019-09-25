using ProjectPeople.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPeople.Models
{
    public class Employee : Person
    {

        #region Declarations
        private decimal daySalary;
        #endregion

        #region Initializations
        public Employee(string name, int age, bool isMale, decimal daySalary)
            : base(name, age, isMale)
        {
            DaySalary = daySalary;
        }
        #endregion

        #region Properties
        public decimal DaySalary
        {
            get => daySalary;

            private set
            {
                if (daySalary == value)
                {
                    return;
                }

                if (value < 0 || value > 286666M)
                {
                    throw new ArgumentException(GlobalConstants.InvalidDaySalary);
                }

                daySalary = value;
            }
        }
        #endregion

        #region Methods
        public string CalculateOvertime(double hours)
        {
            if (this.Age < 18)
            {
                return "0";
            }

            return string.Format("{0:0.00}", (daySalary * 1.5m));
        }

        public override string ShowPersonInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ShowPersonInfo());
            sb.AppendLine($"DaySalary: {this.DaySalary:f2}");

            return sb.ToString().TrimEnd();
        }
        #endregion
    }
}

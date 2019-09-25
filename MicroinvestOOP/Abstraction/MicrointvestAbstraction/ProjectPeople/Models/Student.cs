using ProjectPeople.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPeople.Models
{
    public class Student : Person
    {
        #region Declarations
        private double score;
        #endregion

        #region Initializations
        public Student(string name, int age, bool isMale, double score)
            : base(name, age, isMale)
        {
            Score = score;
        }
        #endregion

        #region Properties
        public double Score
        {
            get => this.score;

            private set
            {
                if (score == value)
                {
                    return;
                }

                if (value < 2 || value > 6)
                {
                    throw new ArgumentException(GlobalConstants.InvalidGrade);
                }

                score = value;
            }
        }
        #endregion

        #region Methods
        public override string ShowPersonInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ShowPersonInfo());
            sb.AppendLine($"Grade: {this.Score:f2}");

            return sb.ToString().TrimEnd();
        }
        #endregion
    }
}

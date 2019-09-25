using ProjectPeople.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPeople.Models
{
    public class Person
    {
        #region Declarations
        private string name;
        private int age;
        #endregion

        #region initializations
        public Person(string name, int age, bool isMale)
        {
            Name = name;
            Age = age;
            IsMale = isMale;
        }
        #endregion

        #region Properties
        public string Name
        {
            get => this.name;

            protected set
            {
                if (name == value)
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

        public int Age
        {
            get => this.age;

            protected set
            {
                if (age == value)
                {
                    return;
                }

                if (value < 0 || value > 120)
                {
                    throw new ArgumentException(GlobalConstants.InvalidAge);
                }

                age = value;
            }              
        }

        public bool IsMale { get; set; }
        #endregion

        #region Methods
        public virtual string ShowPersonInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {this.Name}");
            sb.AppendLine($"Age: {this.Age}");
            sb.AppendLine($"IsMale: {this.IsMale}");

            return sb.ToString().TrimEnd();
        }
        #endregion
    }
}

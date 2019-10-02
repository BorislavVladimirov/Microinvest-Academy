using CourtTask.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourtTask.Models.Citizens
{
    public abstract class Citizen
    {
        private string name;
        private string adress;
        private int age;

        public Citizen(string name, string adress, int age)
        {
            FullName = name;
            Adress = adress;
            Age = age;
        }

        public string FullName
        {
            get => this.name;

            protected set
            {
                if (value == this.name)
                {
                    return;
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidName);
                }

                this.name = value;
            }
        }

        public string Adress
        {
            get => this.adress;

            protected set
            {
                if (value == this.adress)
                {
                    return;
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidAdress);
                }

                this.adress = value;
            }
        }

        public int Age
        {
            get => this.age;

            protected set
            {
                if (value == this.age)
                {
                    return;
                }

                if (value < 18)
                {
                    throw new ArgumentException(GlobalConstants.InvalidAge);
                }

                this.age = value;
            }
        }
    }
}

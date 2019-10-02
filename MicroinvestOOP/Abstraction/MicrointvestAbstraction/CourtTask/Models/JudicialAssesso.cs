using CourtTask.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourtTask.Models
{
    public class JudicialAssessor
    {
        private string name;

        public JudicialAssessor(string name)
        {
            Name = name;
        }

        public string Name
        {
            get => this.name;

            private set
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

        public int GetDicision()
        {
            Random random = new Random();

            return random.Next(0, 2);
        }
    }
}

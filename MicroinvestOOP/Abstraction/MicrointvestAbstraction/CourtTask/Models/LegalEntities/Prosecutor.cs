using CourtTask.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourtTask.Models
{
    public class Prosecutor : LegalEntity
    {
        private int yearsOfEx;

        public Prosecutor(string id, string name, string position, int yearsOfEx)
            : base(id, name, position)
        {
            this.YearsOfExperience = yearsOfEx;
        }

        public override int YearsOfExperience
        {
            get => this.yearsOfEx;

            protected set
            {
                if (value == this.yearsOfEx)
                {
                    return;
                }

                if (value < GlobalConstants.MinimumProsecutorYearOfEx)
                {
                    throw new ArgumentException(GlobalConstants.InvalidMinOfLawsyuits);
                }

                this.yearsOfEx = value;
            }
        }
    }
}

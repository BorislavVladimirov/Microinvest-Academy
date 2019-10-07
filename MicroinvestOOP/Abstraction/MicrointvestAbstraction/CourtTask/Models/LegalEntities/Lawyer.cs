using CourtTask.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourtTask.Models
{
    public class Lawyer : LegalEntity
    {
        private int lawsuitsCount;

        public Lawyer(string id, string name, string position, int lawsuitsCount)
            : base(id, name, position)
        {
            this.LawsuitsCount = lawsuitsCount;
        }

        public override int LawsuitsCount
        {
            get => this.lawsuitsCount;

            set
            {
                if (value == this.lawsuitsCount)
                {
                    return;
                }

                if (value < GlobalConstants.MinimumLawyerLawsuitsCount)
                {
                    throw new ArgumentException(GlobalConstants.InvalidMinOfLawsyuits);
                }

                this.lawsuitsCount = value;
            }
        }
    }
}

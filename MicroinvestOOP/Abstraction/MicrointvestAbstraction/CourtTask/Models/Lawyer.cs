using CourtTask.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourtTask.Models
{
    public class Lawyer : LegalEntity
    {
        public Lawyer(string name, string position)
            : base(name, position)
        {
            this.LawsuitsCount = GlobalConstants.InitialLawyerLawsuitsCount;
        }
    }
}

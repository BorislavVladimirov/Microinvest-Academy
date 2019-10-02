using CourtTask.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourtTask.Models
{
    public class Prosecutor : LegalEntity
    {
        public Prosecutor(string name, string position) 
            : base(name, position)
        {
            this.YearsOfExperience = GlobalConstants.InitialProsecutorYearOfEx;
        }
    }
}

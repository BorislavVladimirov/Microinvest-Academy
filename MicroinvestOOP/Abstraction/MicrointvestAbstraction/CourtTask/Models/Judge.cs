using CourtTask.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourtTask.Models
{
    public class Judge : LegalEntity
    {
        public Judge(string name, string position) 
            : base(name, position)
        {
            this.YearsOfExperience = GlobalConstants.InitialJudgeYearOfEx;
        }
    }
}

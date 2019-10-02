using System;
using System.Collections.Generic;
using System.Text;
using CourtTask.Models.Citizens;

namespace CourtTask.Models.Lawsuits
{
    public class CriminalCase : Lawsuit
    {
        public CriminalCase(Claimant claimant, HashSet<JudicialAssessor> judicialAssessors, HashSet<Citizen> witnesses, Prosecutor prosecutor)
            : base(claimant, judicialAssessors, witnesses, prosecutor)
        {
            //todo
        }
    }
}

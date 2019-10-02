using System;
using System.Collections.Generic;
using System.Text;
using CourtTask.Models.Citizens;

namespace CourtTask.Models.Lawsuits
{
    public class CivilCase : Lawsuit
    {
        public CivilCase(Claimant claimant, HashSet<JudicialAssessor> judicialAssessors, HashSet<Citizen> witnesses, Prosecutor prosecutor) 
            : base(claimant, judicialAssessors, witnesses, prosecutor)
        {
            //TODO
        }
    }
}

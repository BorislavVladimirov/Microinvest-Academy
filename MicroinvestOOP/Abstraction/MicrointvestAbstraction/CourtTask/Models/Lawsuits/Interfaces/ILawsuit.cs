using CourtTask.Models;
using CourtTask.Models.Citizens;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourtTask.Models.Lawsuits
{
    public interface ILawsuit
    {
        string Type { get; }

        Judge Judge { get; }

        List<JudicialAssessor> JudicialAssessors { get; }

        Defendant Defendant { get; }

        List<Witness> Witnesses { get; }

        void StartCase(StringBuilder sb = null);
    }
}

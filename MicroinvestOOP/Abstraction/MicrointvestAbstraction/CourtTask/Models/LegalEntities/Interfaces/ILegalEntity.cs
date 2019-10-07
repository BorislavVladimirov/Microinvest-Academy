using CourtTask.Interfaces;
using CourtTask.Models.Citizens;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourtTask.Models
{
    public interface ILegalEntity : IPerson
    {
        string Position { get; }

        int YearsOfExperience { get;  }

        int LawsuitsCount { get; set; }

        void AskQuestion(Citizen citizen, string question);

        void AddNotes(string note);
    }
}

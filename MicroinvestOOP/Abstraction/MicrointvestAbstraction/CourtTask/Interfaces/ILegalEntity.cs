using CourtTask.Models.Citizens;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourtTask.Interfaces
{
    public interface ILegalEntity
    {
        void AskQuestion(Citizen citizen);

        void AddNotes(string note);
    }
}

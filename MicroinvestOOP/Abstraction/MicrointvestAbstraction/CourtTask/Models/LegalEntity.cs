using CourtTask.Common;
using CourtTask.Interfaces;
using CourtTask.Models.Citizens;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourtTask.Models
{
    public abstract class LegalEntity : ILegalEntity
    {
        private string name;
        private string position;

        public LegalEntity(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public string Name
        {
            get => this.name;

            protected set
            {
                if (value == this.name)
                {
                    return;
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new AggregateException(GlobalConstants.InvalidName);
                }

                this.name = value;
            }
        }

        public string Position
        {
            get => this.position;

            protected set
            {
                if (value == this.position)
                {
                    return;
                }

                if (value.ToLower() != "judge" && value.ToLower() != "judicial assessor" 
                    && value.ToLower() != "lawyer" && value.ToLower() != "prosecutor")
                {
                    throw new AggregateException(GlobalConstants.InvalidPosition);
                }

                this.position = value;
            }
        }

        public int YearsOfExperience { get;  protected set; }

        public int LawsuitsCount { get; set; }

        public void AddNotes(string note)
        {
            throw new NotImplementedException();
        }

        public void AskQuestion(Citizen citizen)
        {

        }
    }
}

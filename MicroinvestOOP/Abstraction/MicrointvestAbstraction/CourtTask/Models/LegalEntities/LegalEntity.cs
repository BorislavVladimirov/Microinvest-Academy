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
        private string id;

        public LegalEntity(string id, string name, string position)
        {
            ID = id;
            Name = name;
            Position = position;
        }

        public string ID
        {
            get => this.id;

            protected set
            {
                if (value == this.id)
                {
                    return;
                }

                if (value.Length != 10)
                {
                    throw new ArgumentException(GlobalConstants.InvalidPersonalID);
                }

                // 1900 - 31.12.1999
                if (value[2] == '0' || value[2] == '1')
                {
                    if (value[4] != '0'
                        && value[4] != '1'
                        && value[4] != '2'
                        && value[4] != '3')
                    {
                        throw new ArgumentException(GlobalConstants.InvalidPersonalID);
                    }
                }
                else
                {
                    if (value[2] != '4' && value[2] != '5')
                    {
                        throw new ArgumentException(GlobalConstants.InvalidPersonalID);
                    }

                    if (value[4] != '0'
                        && value[4] != '1'
                        && value[4] != '2'
                        && value[4] != '3')
                    {
                        throw new ArgumentException(GlobalConstants.InvalidPersonalID);
                    }
                }


                this.id = value;
            }
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
                    throw new ArgumentException(GlobalConstants.InvalidName);
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
                    throw new ArgumentException(GlobalConstants.InvalidPosition);
                }

                this.position = value;
            }
        }

        public virtual int YearsOfExperience { get; protected set; }

        public virtual int LawsuitsCount { get; set; }

        public void AddNotes(string note)
        {

        }

        public void AskQuestion(Citizen citizen, string question)
        {

        }

        public override string ToString()
        {
            return string.Format(" {0} {1} {2}", GlobalConstants.ParticipantInfo, this.Name, this.Position);
        }
    }
}

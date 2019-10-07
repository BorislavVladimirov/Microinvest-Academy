using CourtTask.Common;
using CourtTask.Interfaces;
using CourtTask.Models.Citizens;
using CourtTask.Models.Lawsuits;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CourtTask.Models
{
    public abstract class Lawsuit : ILawsuit
    {
        protected int result = 0;
        protected string question;

        public Lawsuit(Defendant defendant, Judge judge, List<Witness> witnesses)
        {
            this.Defendant = defendant;
            this.Witnesses = witnesses;
            this.Judge = judge;
        }

        public string Type { get; }

        public Judge Judge { get; }

        public abstract List<JudicialAssessor> JudicialAssessors { get; protected set; }

        public Defendant Defendant { get; }

        public List<Witness> Witnesses { get; } = new List<Witness>();

        public virtual void StartCase(StringBuilder sb = null)
        {
            this.JudicialAssessors.ForEach(j => j.LawsuitsCount++);
            this.Defendant.Lawyers.ForEach(l => l.LawsuitsCount++);
            this.Judge.LawsuitsCount++;

            foreach (var lawyer in this.Defendant.Lawyers)
            {
                foreach (var witness in this.Witnesses)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        question = Question.GetRandomQuestion();

                        sb.AppendLine(string.Format("{0} {1} {2} {3}", GlobalConstants.Lawyer, lawyer.Name, GlobalConstants.IsAsking, witness.Name));
                        sb.AppendLine(string.Format(" {0} {1}", GlobalConstants.Question, question));
                        lawyer.AskQuestion(witness, question);
                    }
                }

            }

            this.JudicialAssessors.ForEach(j => result += j.GetDicision());

            if (result * 1.0 / this.JudicialAssessors.Count > 0.5)
            {
                Random random = new Random();

                int prisonTime = random.Next(3, 41);

                sb.AppendLine(GlobalConstants.FoundGuilty);
                sb.AppendLine(string.Format("{0} {1} {2}", GlobalConstants.PrisonTime, prisonTime, GlobalConstants.Years));

            }
            else
            {
                sb.AppendLine(GlobalConstants.NotGuilty);
            }

            string fileName = @"D:\CourtReport.txt";

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(sb);
            }
        }
    }
}

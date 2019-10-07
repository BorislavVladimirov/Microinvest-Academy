using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CourtTask.Common;
using CourtTask.Models.Citizens;

namespace CourtTask.Models.Lawsuits
{
    public class CivilCase : Lawsuit
    {
        private List<JudicialAssessor> judicialAssessors;
        protected string question;

        public CivilCase(Defendant defendant, Judge judge, List<Witness> witnesses, List<JudicialAssessor> judicialAssessors, Claimant claimant)
            : base(defendant, judge, witnesses)
        {
            this.Claimant = claimant;
            this.JudicialAssessors = judicialAssessors;
        }

        public Claimant Claimant { get; }

        public override List<JudicialAssessor> JudicialAssessors
        {
            get => this.judicialAssessors;

            protected set
            {
                if (value.Count != 3)
                {
                    throw new ArgumentException(GlobalConstants.InvalidJudicialAssessorsCount);
                }

                this.judicialAssessors = value;
            }
        }

        public override void StartCase(StringBuilder sb = null)
        {
            this.Claimant.Lawyers.ForEach(l => l.LawsuitsCount++);

            sb = new StringBuilder();

            sb.AppendLine(GlobalConstants.LawsuitParticipants);
            sb.AppendLine(GlobalConstants.LegalEntitiesInfo);

            sb.AppendLine(GlobalConstants.JudgeInfo);
            sb.AppendLine(this.Judge.ToString());

            sb.AppendLine(GlobalConstants.ClaimantsInfo);
            sb.AppendLine(this.Claimant.ToString());

            sb.AppendLine(GlobalConstants.DefendantInfo);
            sb.AppendLine(this.Defendant.ToString());

            foreach (var lawyer in this.Claimant.Lawyers)
            {
                sb.AppendLine(GlobalConstants.ClaimantLawyersInfo);
                sb.AppendLine(lawyer.ToString());
            }

            foreach (var lawyer in this.Defendant.Lawyers)
            {
                sb.AppendLine(GlobalConstants.DefendantLawyersInfo);
                sb.AppendLine(lawyer.ToString());
            }

            foreach (var witness in this.Witnesses)
            {
                sb.AppendLine(GlobalConstants.WintessesInfo);
                sb.AppendLine(witness.ToString());
            }

            foreach (var judicialAssessor in this.JudicialAssessors)
            {
                sb.AppendLine(GlobalConstants.JudicialAssessorsInfo);
                sb.AppendLine(judicialAssessor.ToString());
            }

            foreach (var lawyer in this.Claimant.Lawyers)
            {
                for (int i = 0; i < 3; i++)
                {
                    question = Question.GetRandomQuestion();

                    sb.AppendLine(string.Format("{0} {1} {2} {3}", GlobalConstants.Lawyer, lawyer.Name, GlobalConstants.IsAsking, this.Defendant.Name));
                    sb.AppendLine(string.Format(" {0} {1}", GlobalConstants.Question, question));
                    lawyer.AskQuestion(this.Defendant, question);
                }

                foreach (var witness in this.Witnesses)
                {
                    question = Question.GetRandomQuestion();

                    sb.AppendLine(string.Format("{0} {1} {2} {3}", GlobalConstants.Lawyer, lawyer.Name, GlobalConstants.IsAsking, witness.Name));
                    sb.AppendLine(string.Format(" {0} {1}", GlobalConstants.Question, question));
                    lawyer.AskQuestion(witness, question);

                    question = Question.GetRandomQuestion();

                    sb.AppendLine(string.Format(" {0} {1}", GlobalConstants.Question, question));
                    lawyer.AskQuestion(witness,question);
                }
            }

            base.StartCase(sb);
        }
    }
}

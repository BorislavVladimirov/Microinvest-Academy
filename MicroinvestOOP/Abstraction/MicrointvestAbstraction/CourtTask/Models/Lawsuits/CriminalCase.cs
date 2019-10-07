using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CourtTask.Common;
using CourtTask.Models.Citizens;

namespace CourtTask.Models.Lawsuits
{
    public class CriminalCase : Lawsuit
    {
        private List<JudicialAssessor> judicialAssessors;
        protected string question;

        public CriminalCase(Defendant defendant, Judge judge, List<Witness> witnesses, List<JudicialAssessor> judicialAssessors, Prosecutor prosecutor)
          : base(defendant, judge, witnesses)
        {
            this.JudicialAssessors = judicialAssessors;
            this.Prosecutor = prosecutor;
        }

        public Prosecutor Prosecutor { get; }

        public override List<JudicialAssessor> JudicialAssessors
        {
            get => this.judicialAssessors;

            protected set
            {
                if (value.Count != 13)
                {
                    throw new ArgumentException(GlobalConstants.InvalidJudicialAssessorsCount);
                }

                this.judicialAssessors = value;
            }
        }

        public override void StartCase(StringBuilder sb = null)
        {
            this.Prosecutor.LawsuitsCount++;

            sb = new StringBuilder();

            sb.AppendLine(GlobalConstants.LawsuitParticipants);
            sb.AppendLine(GlobalConstants.LegalEntitiesInfo);

            sb.AppendLine(GlobalConstants.JudgeInfo);
            sb.AppendLine(this.Judge.ToString());

            sb.AppendLine(GlobalConstants.ProsecutorInfo);
            sb.AppendLine(this.Prosecutor.ToString());

            sb.AppendLine(GlobalConstants.DefendantInfo);
            sb.AppendLine(this.Defendant.ToString());

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

            for (int i = 0; i < 5; i++)
            {
                question = Question.GetRandomQuestion();

                sb.AppendLine(string.Format("{0} {1} {2} {3}", GlobalConstants.Prosecutor, this.Prosecutor.Name, GlobalConstants.IsAsking, this.Defendant.Name));
                sb.AppendLine(string.Format(" {0} {1}", GlobalConstants.Question, question));
                this.Prosecutor.AskQuestion(this.Defendant, question);
            }


            for (int i = 0; i < 5; i++)
            {
                foreach (var witness in this.Witnesses)
                {
                    question = Question.GetRandomQuestion();

                    sb.AppendLine(string.Format("{0} {1} {2} {3}", GlobalConstants.Prosecutor, this.Prosecutor.Name, GlobalConstants.IsAsking, witness.Name));
                    sb.AppendLine(string.Format(" {0} {1}", GlobalConstants.Question, question));
                    this.Prosecutor.AskQuestion(witness, question);
                }
            }

            base.StartCase(sb);
        }
    }
}

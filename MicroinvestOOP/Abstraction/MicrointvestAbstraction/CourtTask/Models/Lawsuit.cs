using CourtTask.Models.Citizens;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CourtTask.Models
{
    public abstract class Lawsuit
    {
        private int result = 0;

        public Lawsuit(Claimant claimant, HashSet<JudicialAssessor> judicialAssessors, HashSet<Citizen> witnesses, Prosecutor prosecutor)
        {
            this.Claimant = claimant;
            this.JudicialAssessors = judicialAssessors;
            this.Witnesses = witnesses;
            this.Prosecutor = prosecutor;
        }

        public Prosecutor Prosecutor { get; set; }

        public string Type { get; set; }

        public Judge Judge { get; set; }

        public HashSet<JudicialAssessor> JudicialAssessors { get; } = new HashSet<JudicialAssessor>();

        public Defendant Defendant { get; set; }

        public Claimant Claimant { get; set; }

        public HashSet<Citizen> Witnesses { get; } = new HashSet<Citizen>();

        public void StartCase()
        {
            string fileName = @"D:\Temp\CSharpAuthors.txt";

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                this.Claimant.Lawyers.FirstOrDefault().LawsuitsCount++;
                this.Defendant.Lawyers.FirstOrDefault().LawsuitsCount++;

                if (this.Type == "CivilCase")
                {
                    foreach (var lawyer in this.Claimant.Lawyers)
                    {
                        writer.Write($"Lawyer name: {lawyer.Name} is asking question");
                        lawyer.AskQuestion(this.Defendant);
                        writer.Write($"Lawyer name: {lawyer.Name} is asking question");
                        lawyer.AskQuestion(this.Defendant);
                        writer.Write($"Lawyer name: {lawyer.Name} is asking question");
                        lawyer.AskQuestion(this.Defendant);

                        foreach (var witness in this.Witnesses)
                        {
                            writer.Write($"Witness name: {witness.FullName} is being interrogatet");
                            lawyer.AskQuestion(witness);
                            writer.Write($"Witness name: {witness.FullName} is being interrogatet");
                            lawyer.AskQuestion(witness);
                        }
                    }
                }
                else if (this.Type == "CriminalCase")
                {
                    this.Prosecutor.AskQuestion(this.Defendant);
                    writer.Write($"Prosecutor {this.Prosecutor.Name} is interrogating {this.Defendant.FullName} ");
                    this.Prosecutor.AskQuestion(this.Defendant);
                    writer.Write($"Prosecutor {this.Prosecutor.Name} is interrogating {this.Defendant.FullName} ");
                    this.Prosecutor.AskQuestion(this.Defendant);
                    writer.Write($"Prosecutor {this.Prosecutor.Name} is interrogating {this.Defendant.FullName} ");
                    this.Prosecutor.AskQuestion(this.Defendant);
                    writer.Write($"Prosecutor {this.Prosecutor.Name} is interrogating {this.Defendant.FullName} ");
                    this.Prosecutor.AskQuestion(this.Defendant);
                    writer.Write($"Prosecutor {this.Prosecutor.Name} is interrogating {this.Defendant.FullName} ");

                    foreach (var witness in this.Witnesses)
                    {
                        this.Prosecutor.AskQuestion(witness);
                        writer.Write($"Prosecutor {this.Prosecutor.Name} is interrogating witness: {witness.FullName} ");
                    }
                }

                foreach (var lawyer in this.Defendant.Lawyers)
                {
                    foreach (var witness in this.Witnesses)
                    {
                        writer.Write($"Lawyer {lawyer.Name} is interrogating  witness: {witness.FullName}");
                        lawyer.AskQuestion(witness);
                    }
                }

                foreach (var judicalAssessor in this.JudicialAssessors)
                {
                    int currentDicision = judicalAssessor.GetDicision();

                    writer.Write($"Current judicalAssessor dicision : {currentDicision}");

                    this.result += currentDicision;
                }

                if (this.result / this.JudicialAssessors.Count > 0.5)
                {
                    Random random = new Random();

                    int prisonTime = random.Next(3, 41);

                    writer.Write("Find guilty!");
                    writer.Write($"Prison time: {prisonTime}");
                }
                else
                {
                    writer.Write("Not guilty!");
                }
            }
            
        }
    }
}

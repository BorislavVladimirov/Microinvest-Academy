using CourtTask.Models;
using CourtTask.Models.Citizens;
using CourtTask.Models.Lawsuits;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CourtTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashSet<JudicialAssessor> judicialAssessors = new HashSet<JudicialAssessor>();
            HashSet<Citizen> witnesses = new HashSet<Citizen>();

            witnesses.Add(new Witness("Ivo", "Sofia, Boqna", 55));
            witnesses.Add(new Witness("Kukata", "Sofia, Boqna", 25));
            witnesses.Add(new Witness("Kosuma", "Sofia, Boqna", 30));

            judicialAssessors.Add(new JudicialAssessor("Ivanka"));
            judicialAssessors.Add(new JudicialAssessor("Gergana"));
            judicialAssessors.Add(new JudicialAssessor("Petranka"));
            judicialAssessors.Add(new JudicialAssessor("Kalina"));
            judicialAssessors.Add(new JudicialAssessor("Maria"));

            Prosecutor prosecutor = new Prosecutor("prokuror Ivanov", "prosecutor");

            LegalEntity lawyer = new Lawyer("Ivan", "lawyer");
            LegalEntity lawyer2 = new Lawyer("Pesho", "lawyer");

            Claimant claimant = new Claimant("Harry", "Sofia Mladost", 32);
            claimant.Lawyers.Add(lawyer);
            
            Defendant defendant = new Defendant("Dumbuldore", "Lulin", 55);
            defendant.Lawyers.Add(lawyer2);

            Judge judge = new Judge("Bilqna", "judge");

            defendant.Lawyers.FirstOrDefault().LawsuitsCount++;

            Lawsuit lawsuit = new CivilCase(claimant, judicialAssessors, witnesses, prosecutor);

            Court court = new Court("Raionen sud Veliko Tarnovo", "Veliko Tarnovo, Vasil Levski St 16");
        }
    }
}

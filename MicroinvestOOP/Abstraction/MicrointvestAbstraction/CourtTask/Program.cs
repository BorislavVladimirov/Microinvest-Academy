using CourtTask.Common;
using CourtTask.Interfaces;
using CourtTask.Models;
using CourtTask.Models.Citizens;
using CourtTask.Models.Citizens.Interfaces;
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
            try
            {
                List<JudicialAssessor> judicialAssessors = new List<JudicialAssessor>();
                List<Witness> witnesses = new List<Witness>();
                List<Prosecutor> prosecutors = new List<Prosecutor>();
                List<Lawyer> lawyers = new List<Lawyer>();
                List<Judge> judges = new List<Judge>();
                List<Claimant> claimants = new List<Claimant>();
                List<Defendant> defendants = new List<Defendant>();
                List<CivilCase> civilCases = new List<CivilCase>();
                List<CriminalCase> criminalCases = new List<CriminalCase>();

                List<JudicialAssessor> civilCaseJudicialAssessors = new List<JudicialAssessor>();
                List<JudicialAssessor> criminalCaseJudicialAssessors = new List<JudicialAssessor>();

                Court districtCourtVelikoTarnovo = new Court(GlobalConstants.CourtName, GlobalConstants.CourtAdress);

                GenerateGudges(judges);

                GenerateJudicialAsessors(judicialAssessors);

                GenerateLawyers(lawyers);

                GenerateProsecutors(prosecutors);

                GenerateWitnesses(witnesses);

                GenerateClaimants(claimants, lawyers);

                GenerateDefendants(defendants, lawyers);               

                GenerateCivilCaseJudicialAssessors(civilCaseJudicialAssessors, judicialAssessors);

                GenerateCriminalCaseJudicialAssessors(criminalCaseJudicialAssessors, judicialAssessors);

                GenerateCivilCases(civilCases, defendants, civilCaseJudicialAssessors, judges, witnesses, claimants);

                GenerateCriminalCase(criminalCases, defendants, judges, witnesses, criminalCaseJudicialAssessors, prosecutors);

                districtCourtVelikoTarnovo.Lawsuits.AddRange(civilCases);
                districtCourtVelikoTarnovo.Lawsuits.AddRange(criminalCases);

                districtCourtVelikoTarnovo.LegalEntities.AddRange(prosecutors);
                districtCourtVelikoTarnovo.LegalEntities.AddRange(lawyers);
                districtCourtVelikoTarnovo.LegalEntities.AddRange(judges);
                districtCourtVelikoTarnovo.LegalEntities.AddRange(judicialAssessors);

                foreach (var lawsuit in districtCourtVelikoTarnovo.Lawsuits)
                {
                    lawsuit.StartCase();
                }

                districtCourtVelikoTarnovo.GetLegalEntitiesReport();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void GenerateCriminalCaseJudicialAssessors(List<JudicialAssessor> criminalCaseJudicialAssessors,
            List<JudicialAssessor> judicialAssessors)
        {
            Random random = new Random();

            List<JudicialAssessor> temp = new List<JudicialAssessor>(judicialAssessors);

            for (int i = 0; i < 13; i++)
            {
                int index = random.Next(0, temp.Count);

                criminalCaseJudicialAssessors.Add(temp[index]);

                temp.RemoveAt(index);
            }
        }

        private static void GenerateCivilCaseJudicialAssessors(List<JudicialAssessor> civilCaseJudicialAssessors,
            List<JudicialAssessor> judicialAssessors)
        {
            Random random = new Random();

            List<JudicialAssessor> temp = new List<JudicialAssessor>(judicialAssessors);

            for (int i = 0; i < 3; i++)
            {
                int index = random.Next(0, temp.Count);

                civilCaseJudicialAssessors.Add(temp[index]);

                temp.RemoveAt(index);
            }
        }

        private static void GenerateCriminalCase(List<CriminalCase> criminalCases, List<Defendant> defendants,
            List<Judge> judges, List<Witness> witnesses, List<JudicialAssessor> criminalCaseJudicialAssessors, List<Prosecutor> prosecutors)
        {
            Random random = new Random();


            CriminalCase criminalCaseOne = new CriminalCase(
                defendants[random.Next(0, defendants.Count)],
                judges[random.Next(0, judges.Count)],
                witnesses,
                criminalCaseJudicialAssessors,
                prosecutors[random.Next(0, prosecutors.Count)]);

            CriminalCase criminalCaseTwo = new CriminalCase(
              defendants[random.Next(0, defendants.Count)],
              judges[random.Next(0, judges.Count)],
              witnesses,
              criminalCaseJudicialAssessors,
              prosecutors[random.Next(0, prosecutors.Count)]);

            CriminalCase criminalCaseThree = new CriminalCase(
              defendants[random.Next(0, defendants.Count)],
              judges[random.Next(0, judges.Count)],
              witnesses,
              criminalCaseJudicialAssessors,
              prosecutors[random.Next(0, prosecutors.Count)]);

            criminalCases.Add(criminalCaseOne);
            criminalCases.Add(criminalCaseTwo);
            criminalCases.Add(criminalCaseThree);
        }

        private static void GenerateCivilCases(List<CivilCase> civilCases, List<Defendant> defendants, 
            List<JudicialAssessor> civilCaseJudicialAssessors, List<Judge> judges, List<Witness> witnesses, List<Claimant> claimants)
        {
            Random random = new Random();


            CivilCase civilCaseOne = new CivilCase(
                defendants[random.Next(0, defendants.Count)],
                judges[random.Next(0, judges.Count)],
                witnesses,
                civilCaseJudicialAssessors,
                claimants[random.Next(0, claimants.Count)]);

            CivilCase civilCaseTwo = new CivilCase(
              defendants[random.Next(0, defendants.Count)],
              judges[random.Next(0, judges.Count)],
              witnesses,
              civilCaseJudicialAssessors,
              claimants[random.Next(0, claimants.Count)]);

            CivilCase civilCaseThree = new CivilCase(
              defendants[random.Next(0, defendants.Count)],
              judges[random.Next(0, judges.Count)],
              witnesses,
              civilCaseJudicialAssessors,
              claimants[random.Next(0, claimants.Count)]);

            civilCases.Add(civilCaseOne);
            civilCases.Add(civilCaseTwo);
            civilCases.Add(civilCaseThree);
        }

        private static void GenerateDefendants(List<Defendant> defendants, List<Lawyer> lawyers)
        {
            Defendant claimantPopov = new Defendant("4511098050", "Strahil Popov", "Sofia, German", 45);
            Defendant claimantPashov = new Defendant("6602089950", "Georgi Pashov", "Sofia, Mladost", 22);
            Defendant claimantSlavchev = new Defendant("9912174015", "Simeon Slavchev", "Sofia, bul. Malinov 44", 66);
            Defendant claimantDimitrov = new Defendant("8809085030", "Nikola Dimitrov", "Sofia, Lulin", 22);
            Defendant claimantDespodov = new Defendant("6409014550", "Kiril Despodov", "Sofia, Lulin", 41);

            AddDefendants(defendants, claimantPopov);
            AddDefendants(defendants, claimantPashov);
            AddDefendants(defendants, claimantSlavchev);
            AddDefendants(defendants, claimantDimitrov);
            AddDefendants(defendants, claimantDespodov);

            AddLawyersToDefendants(defendants, lawyers);
        }

        private static void AddLawyersToDefendants(List<Defendant> defendants, List<Lawyer> lawyers)
        {
            Random random = new Random();

            foreach (var defendant in defendants)
            {
                defendant.Lawyers.Add(lawyers[random.Next(0, lawyers.Count)]);
            }
        }

        private static void AddDefendants(List<Defendant> defendants, Defendant newDefendant)
        {
            if (defendants.Any(l => l.ID == newDefendant.ID))
            {
                throw new ArgumentException(GlobalConstants.InvalidAdding);
            }

            defendants.Add(newDefendant);
        }

        private static void GenerateClaimants(List<Claimant> claimants, List<Lawyer> lawyers)
        {
            Claimant claimantSokolova = new Claimant("6608189050", "Iva Sokolova", "Sofia, German", 45);
            Claimant claimantDraganov = new Claimant("8805068055", "Nikola Draganov", "Sofia, Mladost", 22);
            Claimant claimantStanilova = new Claimant("7712165040", "Katerina Stanilova", "Sofia, bul. Malinov 44", 66);
            Claimant claimantPetrova = new Claimant("8209085030", "Violeta Petrova", "Sofia, Lulin", 22);
            Claimant claimantDragiev = new Claimant("6614195080", "Vencislav Dragiev", "Sofia, Lulin", 41);

            AddClaimants(claimants, claimantSokolova);
            AddClaimants(claimants, claimantDraganov);
            AddClaimants(claimants, claimantStanilova);
            AddClaimants(claimants, claimantPetrova);
            AddClaimants(claimants, claimantDragiev);

            AddLawyersToClaimants(claimants, lawyers);
        }

        private static void AddLawyersToClaimants(List<Claimant> claimants, List<Lawyer> lawyers)
        {
            Random random = new Random();

            foreach (var claimant in claimants)
            {
                claimant.Lawyers.Add(lawyers[random.Next(0, lawyers.Count)]);
            }
        }

        private static void AddClaimants(List<Claimant> claimants, Claimant newClaimant)
        {
            if (claimants.Any(l => l.ID == newClaimant.ID))
            {
                throw new ArgumentException(GlobalConstants.InvalidAdding);
            }

            claimants.Add(newClaimant);
        }

        private static void GenerateWitnesses(List<Witness> witnesses)
        {
            Witness witness = new Witness("6608189050", "Iva Dineva", "Sofia, German", 45);
            Witness witness1 = new Witness("1612134680", "Nikola Popov", "Sofia, Mladost", 22);
            Witness witness2 = new Witness("1812187537", "Volen Chinkov", "Sofia, Lulin", 66);
            Witness witness3 = new Witness("6207210990", "Georgi Ivanov", "Sofia, Lozen", 30);
            Witness witness4 = new Witness("7502092331", "Radoslav Gindzev", "Sofia, Druzba", 28);
            Witness witness5 = new Witness("2009219328", "Stefan Apostolov", "Sofia, Bistrica", 48);
            Witness witness6 = new Witness("4006249277", "Georgi Nikolov", "Sofia, Motopista", 63);
            Witness witness7 = new Witness("4410014739", "Nedelcho Mitev", "Sofia, Bul. Bulgaria", 24);
            Witness witness8 = new Witness("9108221332", "Stanimir Trenchev", "Sofia, Sveti Kiprian 29", 32);
            Witness witness9 = new Witness("9309109108", "Ivailo Stoianov", "Sofia, Lomsko shose 25", 57);

            AddWitness(witnesses, witness);
            AddWitness(witnesses, witness1);
            AddWitness(witnesses, witness2);
            AddWitness(witnesses, witness3);
            AddWitness(witnesses, witness4);
            AddWitness(witnesses, witness5);
            AddWitness(witnesses, witness6);
            AddWitness(witnesses, witness7);
            AddWitness(witnesses, witness8);
            AddWitness(witnesses, witness9);
        }

        private static void AddWitness(List<Witness> witnesses, Witness newWitness)
        {
            if (witnesses.Any(l => l.ID == newWitness.ID))
            {
                throw new ArgumentException(GlobalConstants.InvalidAdding);
            }

            witnesses.Add(newWitness);
        }

        private static void GenerateProsecutors(List<Prosecutor> prosecutors)
        {
            Prosecutor prosecutorPelov = new Prosecutor("4412165063", "Ivelin Pelov", "prosecutor", 15);
            Prosecutor prosecutorDaskalov = new Prosecutor("5212187890", "Galin Daskalov", "prosecutor", 15);

            AddProsecutor(prosecutors, prosecutorPelov);
            AddProsecutor(prosecutors, prosecutorDaskalov);
        }

        private static void AddProsecutor(List<Prosecutor> prosecutors, Prosecutor newProsecutor)
        {
            if (prosecutors.Any(l => l.ID == newProsecutor.ID))
            {
                throw new ArgumentException(GlobalConstants.InvalidAdding);
            }

            prosecutors.Add(newProsecutor);
        }

        private static void GenerateLawyers(List<Lawyer> lawyers)
        {
            Lawyer lawyerDineva = new Lawyer("6608189050", "Iva Dineva", "lawyer", 45);
            Lawyer lawyerStanoev = new Lawyer("5512167859", "Ivan Stanoev", "lawyer", 23);
            Lawyer lawyerPetkov = new Lawyer("9005124566", "Dragan Petkov", "lawyer", 51);
            Lawyer lawyerMarinova = new Lawyer("7802091214", "Denislava Marinova", "lawyer", 18);
            Lawyer lawyerDinkov = new Lawyer("6305098744", "Qnislav Dinkov", "lawyer", 23);


            AddLawyer(lawyers, lawyerDineva);
            AddLawyer(lawyers, lawyerStanoev);
            AddLawyer(lawyers, lawyerPetkov);
            AddLawyer(lawyers, lawyerMarinova);
            AddLawyer(lawyers, lawyerDinkov);
        }

        private static void AddLawyer(List<Lawyer> lawyers, Lawyer newLawyer)
        {
            if (lawyers.Any(l => l.ID == newLawyer.ID))
            {
                throw new ArgumentException(GlobalConstants.InvalidAdding);
            }

            lawyers.Add(newLawyer);
        }

        private static void GenerateJudicialAsessors(List<JudicialAssessor> judicialAssessors)
        {
            JudicialAssessor judicialAsessor = new JudicialAssessor("6608189050", "Maia", "judicial assessor");
            JudicialAssessor judicialAsessor1 = new JudicialAssessor("5112188049", "Katerina", "judicial assessor");
            JudicialAssessor judicialAsessor2 = new JudicialAssessor("7803025090", "Martina", "judicial assessor");
            JudicialAssessor judicialAsessor3 = new JudicialAssessor("9001017428", "Bogimil", "judicial assessor");
            JudicialAssessor judicialAsessor4 = new JudicialAssessor("8810297893", "Kristian", "judicial assessor");
            JudicialAssessor judicialAsessor5 = new JudicialAssessor("6211148520", "Vencislav", "judicial assessor");
            JudicialAssessor judicialAsessor6 = new JudicialAssessor("9908268892", "Melinda", "judicial assessor");
            JudicialAssessor judicialAsessor7 = new JudicialAssessor("7311295033", "Desislava", "judicial assessor");
            JudicialAssessor judicialAsessor8 = new JudicialAssessor("4901025544", "Viktor", "judicial assessor");
            JudicialAssessor judicialAsessor9 = new JudicialAssessor("8209145012", "Ivelin", "judicial assessor");
            JudicialAssessor judicialAsessor10 = new JudicialAssessor("8612093412", "Paskal", "judicial assessor");
            JudicialAssessor judicialAsessor11 = new JudicialAssessor("7401261109", "Albert", "judicial assessor");
            JudicialAssessor judicialAsessor12 = new JudicialAssessor("2406252137", "Svetlin", "judicial assessor");

            AddJudicialAssessor(judicialAssessors, judicialAsessor);
            AddJudicialAssessor(judicialAssessors, judicialAsessor1);
            AddJudicialAssessor(judicialAssessors, judicialAsessor2);
            AddJudicialAssessor(judicialAssessors, judicialAsessor3);
            AddJudicialAssessor(judicialAssessors, judicialAsessor4);
            AddJudicialAssessor(judicialAssessors, judicialAsessor5);
            AddJudicialAssessor(judicialAssessors, judicialAsessor6);
            AddJudicialAssessor(judicialAssessors, judicialAsessor7);
            AddJudicialAssessor(judicialAssessors, judicialAsessor8);
            AddJudicialAssessor(judicialAssessors, judicialAsessor9);
            AddJudicialAssessor(judicialAssessors, judicialAsessor10);
            AddJudicialAssessor(judicialAssessors, judicialAsessor11);
            AddJudicialAssessor(judicialAssessors, judicialAsessor12);
        }

        private static void AddJudicialAssessor(List<JudicialAssessor> judicialAssessors, JudicialAssessor newJudicialAsessor)
        {
            if (judicialAssessors.Any(l => l.ID == newJudicialAsessor.ID))
            {
                throw new ArgumentException(GlobalConstants.InvalidAdding);
            }

            judicialAssessors.Add(newJudicialAsessor);
        }

        private static void GenerateGudges(List<Judge> judges)
        {
            Judge judgeKeranov = new Judge("5509127220", "Ivan Keranov", "judge", 7);
            Judge judgePetrov = new Judge("7209127220", "Georgi Petrov", "judge", 22);
            Judge judgeIvanov = new Judge("0140127220", "Emil Ivanov", "judge", 38);

            AddJudge(judges, judgeKeranov);
            AddJudge(judges, judgePetrov);
            AddJudge(judges, judgeIvanov);
        }

        private static void AddJudge(List<Judge> judges, Judge newJudge)
        {
            if (judges.Any(l => l.ID == newJudge.ID))
            {
                throw new ArgumentException(GlobalConstants.InvalidAdding);
            }

            judges.Add(newJudge);
        }
    }
}

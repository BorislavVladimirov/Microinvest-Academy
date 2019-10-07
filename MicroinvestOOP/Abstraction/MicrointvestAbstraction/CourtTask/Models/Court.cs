using CourtTask.Common;
using CourtTask.Interfaces;
using CourtTask.Models.Lawsuits;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CourtTask.Models
{
    public class Court : ICourt, IAdress
    {
        private string name;
        private string adress;

        public Court(string name, string adress)
        {
            Name = name;
            Adress = adress;
        }

        public string Name
        {
            get => this.name;

            private set
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

        public string Adress
        {
            get => this.adress;

            private set
            {
                if (value == this.adress)
                {
                    return;
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidName);
                }

                this.adress = value;
            }
        }

        public List<LegalEntity> LegalEntities { get; set; } = new List<LegalEntity>();

        public List<Lawsuit> Lawsuits { get; set; } = new List<Lawsuit>();

        public void GetLegalEntitiesReport()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var legalEntity in this.LegalEntities.OrderBy(l => l.Name))
            {
                sb.AppendLine(string.Format("{0} {1} {2}" ,GlobalConstants.LegalEntityInfo, legalEntity.ToString(), legalEntity.LawsuitsCount));
            }

            string fileName = @"D:\LegalEntitiesInfo.txt";

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(sb.ToString());
            }
        }
    }
}

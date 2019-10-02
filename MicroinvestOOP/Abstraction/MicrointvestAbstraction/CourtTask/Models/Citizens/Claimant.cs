using System;
using System.Collections.Generic;
using System.Text;

namespace CourtTask.Models.Citizens
{
    public class Claimant : Citizen
    {
        public Claimant(string name, string adress, int age) 
            : base(name, adress, age)
        {
        }

        public HashSet<LegalEntity> Lawyers { get; set; } = new HashSet<LegalEntity>();
    }
}

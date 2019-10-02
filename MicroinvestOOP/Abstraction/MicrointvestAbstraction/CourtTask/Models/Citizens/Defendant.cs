using System;
using System.Collections.Generic;
using System.Text;

namespace CourtTask.Models.Citizens
{
    public class Defendant : Citizen
    {
        public Defendant(string name, string adress, int age) 
            : base(name, adress, age)
        {
        }

        public HashSet<LegalEntity> Lawyers { get; set; } = new HashSet<LegalEntity>();
    }
}

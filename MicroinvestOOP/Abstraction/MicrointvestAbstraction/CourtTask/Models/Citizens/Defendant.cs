using System;
using System.Collections.Generic;
using System.Text;

namespace CourtTask.Models.Citizens
{
    public class Defendant : Citizen
    {
        public Defendant(string id, string name, string adress, int age)
            : base(id, name, adress, age)
        {
        }

        public List<LegalEntity> Lawyers { get; set; } = new List<LegalEntity>();
    }
}

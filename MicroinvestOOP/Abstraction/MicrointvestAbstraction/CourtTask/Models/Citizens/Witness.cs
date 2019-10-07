using System;
using System.Collections.Generic;
using System.Text;

namespace CourtTask.Models.Citizens
{
    public class Witness : Citizen
    {
        public Witness(string id, string name, string adress, int age)
            : base(id, name, adress, age)
        {
        }
    }
}

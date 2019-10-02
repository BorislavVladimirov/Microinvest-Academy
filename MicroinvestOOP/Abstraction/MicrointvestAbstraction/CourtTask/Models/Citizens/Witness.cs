using System;
using System.Collections.Generic;
using System.Text;

namespace CourtTask.Models.Citizens
{
    public class Witness : Citizen
    {
        public Witness(string name, string adress, int age) 
            : base(name, adress, age)
        {
        }
    }
}

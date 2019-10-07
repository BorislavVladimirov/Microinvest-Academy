using CourtTask.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourtTask.Models
{
    public class JudicialAssessor : LegalEntity
    {
        public JudicialAssessor(string id,string name, string position) 
            : base(id, name, position)
        {
        }

        public int GetDicision()
        {
            Random random = new Random();

            return random.Next(0, 2);
        }
    }
}

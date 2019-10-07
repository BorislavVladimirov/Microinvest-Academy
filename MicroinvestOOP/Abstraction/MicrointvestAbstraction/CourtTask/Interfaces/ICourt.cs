using CourtTask.Models.Lawsuits;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourtTask.Models
{
    public interface ICourt
    {
        string Name { get; }

        List<LegalEntity> LegalEntities { get; set; }

        List<Lawsuit> Lawsuits { get; set; }

    }
}

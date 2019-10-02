using CourtTask.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourtTask.Models
{
    public class Court
    {
        #region Declarations

        private string name;
        private string adress;

        #endregion


        #region Initializations

        public Court(string name, string adress)
        {
            Name = name;
            Adress = adress;
        }

        #endregion

        #region Properties

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

        public HashSet<LegalEntity> LegalEntities { get; } = new HashSet<LegalEntity>();

        public HashSet<Lawsuit> Lawsuits { get; } = new HashSet<Lawsuit>();

        #endregion

        #region Methods

        #endregion
    }
}

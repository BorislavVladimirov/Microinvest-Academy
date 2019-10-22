using MicroinvestFilesAndStreams.Common;
using MicroinvestFilesAndStreams.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroinvestFilesAndStreams.Models
{
    public class Driver : IDriver
    {
        #region Declarations

        private string name;
        private int age;

        #endregion

        #region Initializations
        public Driver(string name, int age)
        {
            Name = name;
            Age = age;
        }
        #endregion

        #region Properties

        public string Name
        {
            get => name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidDriverName);
                }

                name = value;
            }
        }

        public int Age
        {
            get => age;

            private set
            {
                if (value < 12 || value > 120)
                {
                    throw new ArgumentException(GlobalConstants.InvalidDriverAge);
                }

                age = value;
            }
        }

        #endregion

        #region Methods

        #endregion
    }
}

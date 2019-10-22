using MicroinvestFilesAndStreams.Common;
using MicroinvestFilesAndStreams.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroinvestFilesAndStreams.Models
{
    public class BMW : ICar
    {
        #region Declarations

        private int yearOfProduction;
        private string model;
        private int horsePower;
        private IDriver driver;
        private ITrack track;

        #endregion

        #region Initializations

        public BMW(int yearOfProduction, string model, int horsePower, IDriver driver, ITrack track)
        {
            YearOfProduction = yearOfProduction;
            Model = model;
            HorsePower = horsePower;
            Driver = driver;
            Track = track;
        }

        #endregion

        #region Properties

        public int YearOfProduction
        {
            get => yearOfProduction;

            private set
            {
                if (value <= 1908 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException(GlobalConstants.InvalidProductionYear);
                }

                yearOfProduction = value;
            }
        }

        public string Model
        {
            get => model;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidModel);
                }

                model = value;
            }
        }

        public int HorsePower
        {
            get => horsePower;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(GlobalConstants.InvalidHorsePower);
                }

                horsePower = value;
            }
        }

        public IDriver Driver
        {
            get => driver;

            private set
            {
                driver = value ?? throw new ArgumentException(GlobalConstants.InvalidDriver);
            }
        }
        public ITrack Track
        {
            get => track;

            private set
            {
                track = value ?? throw new ArgumentException(GlobalConstants.InvalidRaceTrack);
            }
        }

        #endregion

        #region Methods

        public void ChangeDrivers(IDriver driver)
        {
            Driver = driver;
        }

        #endregion
    }
}

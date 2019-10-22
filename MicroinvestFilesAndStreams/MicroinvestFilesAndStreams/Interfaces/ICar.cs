using System;
using System.Collections.Generic;
using System.Text;

namespace MicroinvestFilesAndStreams.Interfaces
{
    public interface ICar
    {
        int YearOfProduction { get; }

        string Model { get; }

        int HorsePower { get; }

        IDriver Driver { get; }

        ITrack Track { get; }

        void ChangeDrivers(IDriver driver);
    }
}

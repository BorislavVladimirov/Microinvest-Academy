using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Contracts
{
    public interface ICar
    {
        string Model { get; set; }

        int MaxSpeed { get; set; }

        string YearOfPRoduction { get; set; }

        int HorsePower { get; set; }

        void Accelerte();
    }
}

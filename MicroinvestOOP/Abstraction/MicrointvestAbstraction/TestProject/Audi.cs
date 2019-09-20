using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Contracts;

namespace TestProject
{
    public class Audi : ICar
    {
        public Audi(string model)
        {
            Model = model;
        }

        public string Model { get; set; }

        public int MaxSpeed { get; set; }

        public string YearOfPRoduction { get; set; }

        public int HorsePower { get; set; }

        public void Accelerte()
        {
            Console.WriteLine("Good but not BMW");
        }
    }
}

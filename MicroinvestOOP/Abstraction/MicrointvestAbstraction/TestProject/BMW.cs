using System;
using System.Collections.Generic;
using System.Text;
using CarFactory.Contracts;

namespace CarFactory
{
    public class BMW : ICar
    {
        public BMW(string model)
        {
            Model = model;
        }

        public string Model { get; set; }

        public int MaxSpeed { get; set; }

        public string YearOfPRoduction { get; set; }

        public int HorsePower { get; set; }

        public void Accelerte()
        {
            Console.WriteLine("Fastest car!");
        }
    }
}

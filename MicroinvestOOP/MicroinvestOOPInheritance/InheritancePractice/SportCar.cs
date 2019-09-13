using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePractice
{
    public class SportCar : Car
    {
        private int gearsCount;
        private int tyresPressure;
        private int weight;

        public SportCar(string model, int horsePower, int gearsCount, int tyrepressure, int weight) 
            : base(model)
        {
            GearsCount = gearsCount;
            TyresPressure = tyrepressure;
            Weight = weight;
        }

        public int GearsCount { get => gearsCount; set => gearsCount = value; }

        public int TyresPressure { get => tyresPressure; set => tyresPressure = value; }

        public int Weight { get => weight; set => weight = value; }
    }
}

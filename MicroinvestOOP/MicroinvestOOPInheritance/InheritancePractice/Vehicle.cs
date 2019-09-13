using System;

namespace InheritancePractice
{
    public class Vehicle
    {
        private string model;
        private string color;
        private int year;

        public Vehicle(string model)
        {
            Model = model;
        }

        public Vehicle(string model, string color)
            :this(model)
        {
            Color = color;
        }

        public string Model { get => model; set => model = value; }

        public string Color { get => color; set => color = value; }

        public int Year { get => year; set => year = value; }
    }
}

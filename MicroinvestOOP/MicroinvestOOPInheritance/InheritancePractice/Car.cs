using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePractice
{
    public class Car : Vehicle
    {
        private int horsePower;
        private int maxSpeed;

        public Car(string model): base(model)
        {

        }

        public Car(string model,string color)
            : base(model, color)
        {

        }

        public Car(string model, string color, int horsePower, int maxSpeed)
            :this(model, color)
        {
            HorsePower = horsePower;
            MaxSpeed = maxSpeed;
        }

        public int HorsePower { get => horsePower; set => horsePower = value; }

        public int MaxSpeed { get => maxSpeed; set => maxSpeed = value; }

    }
}

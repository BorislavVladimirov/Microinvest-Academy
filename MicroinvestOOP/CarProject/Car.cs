using System;
using System.Collections.Generic;
using System.Text;

namespace CarProject
{
    public class Car
    {
        private string model;
        private int maxSpeed;
        private int currentSpeed;
        private string color;
        private int currentGear;
        private Person owner;
        private List<Person> drivers;

        public Car()
        {
            this.drivers = new List<Person>();
        }

        public Car(string model, int maxSpeed)
            : this()
        {
            Model = model;
            MaxSpeed = maxSpeed;
        }

        public Car(string model, int maxSpeed, int currentSpeed, string color, int currentGear, Person owner)
            : this(model, maxSpeed)
        {
            CurrentSpeed = currentSpeed;
            Color = color;
            CurrentGear = currentGear;
            Owner = owner;
        }

        #region Property
        public string Model
        {
            get => this.model;

            set
            {
                this.model = value;
            }
        }

        public int MaxSpeed
        {
            get => this.maxSpeed;

            set
            {
                this.maxSpeed = value;
            }
        }

        public int CurrentSpeed
        {
            get => this.currentSpeed;

            set
            {
                if (value > this.MaxSpeed)
                {
                    Console.WriteLine("Current speed cant't be greater than the vehicle max speed!");
                    return;
                }

                this.currentSpeed = value;
            }
        }

        public string Color
        {
            get => this.color;

            set
            {
                this.color = value;
            }
        }

        public int CurrentGear
        {
            get => this.currentGear;

            set
            {
                this.currentGear = value;
            }
        }

        public List<Person> Drivers => this.drivers;

        public Person Owner
        {
            get => this.owner;

            set
            {
                this.owner = value;
            }
        }

        #endregion

        #region Method
        public void Drive(Person driver)
        {
            this.drivers.Add(driver);
        }

        public void ChangeCarOwner(Person newOwner)
        {
            this.owner.Cars.Remove(this);

            this.owner = newOwner;

            this.owner.Cars.Add(this);
        }

        public string GetLastThreeOwners()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Last three drivers:");

            for (int i = 0; i < 3; i++)
            {
                if (i <= this.drivers.Count - 1)
                {
                    sb.AppendLine(this.drivers[i].Name);
                    continue;
                }

                break;
            }

            return sb.ToString().TrimEnd();
        }
        #endregion
    }
}

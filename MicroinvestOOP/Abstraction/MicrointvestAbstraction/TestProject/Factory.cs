using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Contracts;

namespace TestProject
{
    public class Factory
    {
        public Factory(string name)
        {
            FactoryName = name;
        }

        public string FactoryName { get; set; }

        public ICar CreateCar(string carType)
        {
            ICar car = null;

            switch (carType)
            {
                case "BMW":
                    car = new BMW("M5");
                    break;
                case "Audi":
                    car = new Audi("Q8");
                    break;
                case "Opel":
                    car = new Opel("Insignia");
                    break;
                default:
                    Console.WriteLine("Invalid car type");
                    break;
            }

            return car;
        }
    }
}

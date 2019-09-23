using System;
using CarFactory.Contracts;

namespace CarFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory("BMW");

            ICar bmw = factory.CreateCar("BMW");

            bmw.Accelerte();

            ICar audi = factory.CreateCar("Audi");

            audi.Accelerte();

            ICar opel = factory.CreateCar("Opel");

            opel.Accelerte();
        }
    }
}

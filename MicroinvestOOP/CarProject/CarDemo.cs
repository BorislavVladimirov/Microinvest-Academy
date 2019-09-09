using System;
using System.Collections.Generic;
using System.Text;

namespace CarProject
{
    public class CarDemo
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Person BMWOwner = new Person("Strahil", 24);
            Person AudiOwner = new Person("Kolio", 26);

            Car BMW = new Car("M5", 300, 220, "Blue", 6, BMWOwner);
            Car Audi = new Car("A8", 300, 200, "Black", 8, AudiOwner);

            Console.WriteLine("Въведете пореден номена на колата, на която искате да промените параметрите");

            ChangeCarsProperties(BMW, Audi);

            Console.WriteLine(PrintBMWInfo(BMW));     
        }

        private static string PrintBMWInfo(Car BMW)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Car model: {BMW.Model}");
            sb.AppendLine($"Car owner: {BMW.Owner.Name}");
            sb.AppendLine($"Owner's age {BMW.Owner.Age.ToString()}");

            return sb.ToString().TrimEnd();
        }

        private static void ChangeCarsProperties(Car BMW, Car Audi)
        {
            int carNumber;

            int.TryParse(Console.ReadLine(), out carNumber);

            while (carNumber == 1 || carNumber == 2)
            {
                int newGear;
                int newCurrentSpeed;

                switch (carNumber)
                {
                    case 1:
                        Console.WriteLine("Въведете нова предавка");

                        int.TryParse(Console.ReadLine(), out newGear);

                        ChangeGear(newGear, BMW);

                        Console.WriteLine("Въведете нова текуща скорост");

                        int.TryParse(Console.ReadLine(), out newCurrentSpeed);

                        ChangeSpeed(newCurrentSpeed, BMW);
                        break;
                    case 2:
                        Console.WriteLine("Въведете нова предавка");

                        int.TryParse(Console.ReadLine(), out newGear);

                        ChangeGear(newGear, Audi);

                        Console.WriteLine("Въведете нова текуща скорост");

                        int.TryParse(Console.ReadLine(), out newCurrentSpeed);

                        ChangeSpeed(newCurrentSpeed, Audi);
                        break;
                }

                Console.WriteLine("Въведете следваща кола");

                int.TryParse(Console.ReadLine(), out carNumber);
            }
        }

        private static void ChangeSpeed(int newCurrentSpeed, Car car)
        {
            car.CurrentSpeed = newCurrentSpeed;
        }

        private static void ChangeGear(int newGear, Car car)
        {
            car.CurrentGear = newGear;
        }
    }
}

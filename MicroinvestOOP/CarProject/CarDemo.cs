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

            Person BMWOwner = new Person("2Pac", 25);
            Person AudiOwner = new Person("Eminem", 26);

            Car BMW = new Car("M5", 300, 220, "Blue", 6, BMWOwner);

            BMWOwner.Cars.Add(BMW);

            Car Audi = new Car("A8", 300, 200, "Black", 8, AudiOwner);

            AudiOwner.Cars.Add(Audi);

            Console.WriteLine(BMWOwner.Drink());
            Console.WriteLine(BMWOwner.Eat());

            BMWOwner.GetOld();
            Console.WriteLine($"Distance walked: {BMWOwner.Walk():f2} meters");

            //Testing if returned values by Walk method are in range 

            //int count = 1;

            //while (count < 1000000)
            //{
            //    Console.WriteLine($"Distance walked: {BMWOwner.Walk():f2} meters");
            //    Console.WriteLine($"Distance walked: {AudiOwner.Walk():f2}");

            //    count++;
            //}

            Console.WriteLine(AudiOwner.Drink());
            Console.WriteLine(AudiOwner.Eat());

            AudiOwner.GetOld();
            Console.WriteLine($"Distance walked: {AudiOwner.Walk():f2}");


            AudiOwner.AddFriend(BMWOwner);
            BMWOwner.AddFriend(AudiOwner);

            BMW.Drive(BMWOwner);
            BMW.Drive(AudiOwner);
            BMW.Drive(BMWOwner);
            BMW.Drive(BMWOwner);

            Audi.Drive(AudiOwner);
            Audi.Drive(AudiOwner);

            BMW.ChangeCarOwner(AudiOwner);
            BMW.ChangeCarOwner(BMWOwner);
            Audi.ChangeCarOwner(BMWOwner);

            Console.WriteLine(BMW.GetLastThreeOwners());
            Console.WriteLine(Audi.GetLastThreeOwners());

            Console.WriteLine("Въведете пореден номена на колата, на която искате да промените параметрите");

            ChangeCarsProperties(BMW, Audi);

            Console.WriteLine(PrintBMWInfo(BMW));
        }

        #region Method
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

        #endregion
    }
}

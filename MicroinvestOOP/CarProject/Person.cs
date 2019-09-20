using GeoCoordinatePortable;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CarProject
{
    public class Person
    {
        private const double RangeModifier = 0.317959;
        private const double latitudeMinValue = -90;
        private const double latitudeMaxValue = 90;
        private const double longitudeMinValue = -180;
        private const double longitudeMaxValue = 180;

        private string name;
        private int age;
        private List<Person> frineds;
        private List<Car> carCollection;
        private double longitude;
        private double latitude;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            frineds = new List<Person>();
            carCollection = new List<Car>();
        }

        #region Property
        public string Name
        {
            get => this.name;

            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;

            set
            {
                this.age = value;
            }
        }

        public IEnumerable<Person> Friends => this.frineds;

        public List<Car> Cars => this.carCollection;

        public List<double> Coordinates { get; private set; }

        #endregion

        #region Method
        public string Eat()
        {
            return "Eating pizza!";
        }

        public string Drink()
        {
            return "Drinking water!";
        }

        public void GetOld()
        {
            this.Age++;
        }

        public void AddFriend(Person friend)
        {
            this.frineds.Add(friend);
        }

        public double Walk()
        {
            Random random = new Random();

            if (this.Coordinates == null)
            {
                this.Coordinates = new List<double>();

                this.latitude = random.NextDouble() * (latitudeMaxValue - latitudeMinValue) + latitudeMinValue;
                this.longitude = random.NextDouble() * (longitudeMaxValue - longitudeMinValue) + longitudeMinValue;

                Coordinates.Add(this.latitude);
                Coordinates.Add(this.longitude);

                return ChangeCoordinates(Coordinates[0], Coordinates[1], random);
            }

            return ChangeCoordinates(Coordinates[0], Coordinates[1], random);
        }

        private double ChangeCoordinates(double latitude, double longitude, Random random)
        {
            GeoCoordinate initialCoodinates = new GeoCoordinate(latitude, longitude);

            double maxLatitude = latitude + RangeModifier;
            double minLatitude = maxLatitude - RangeModifier;

            double newLatitude = random.NextDouble() * (maxLatitude - minLatitude) + minLatitude;

            double maxLongtitude = longitude + RangeModifier;
            double minLongtitude = maxLongtitude - RangeModifier;

            double newLongitude = random.NextDouble() * (maxLongtitude - minLongtitude) + minLongtitude;

            if (ValiteCoordinates(newLatitude, newLongitude))
            {
                Console.WriteLine("Ivalidddddddddddd");
                return ChangeCoordinates(Coordinates[0], Coordinates[1], random);
            }

            GeoCoordinate newCoordinates = new GeoCoordinate(newLatitude, newLongitude);

            // distance is returned in meters
            double distance = initialCoodinates.GetDistanceTo(newCoordinates);

            if (distance <= 5000)
            {
                Coordinates[0] = newLatitude;
                Coordinates[1] = newLongitude;

                return distance;
            }

            return ChangeCoordinates(Coordinates[0], Coordinates[1], random);
        }

        private bool ValiteCoordinates(double newLatitude, double newLongitude)
        {
            return newLatitude < -90.0 || newLatitude > 90.0
                || newLongitude < -180.0 || newLongitude > 180.0;
        }
        #endregion
    }
}

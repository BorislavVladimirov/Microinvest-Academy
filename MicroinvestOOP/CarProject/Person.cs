﻿using GeoCoordinatePortable;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarProject
{
    public class Person
    {
        private const double RangeModifier = 0.317959;

        private string name;
        private int age;
        private List<Person> frineds;
        private List<Car> carCollection;
        private double longitude;
        private double latitude;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.frineds = new List<Person>();
            this.carCollection = new List<Car>();
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

            this.latitude = random.Next(-90, 91);
            this.longitude = random.Next(-180, 181);

            return ChangeCoordinates(longitude, latitude, random);
        }

        private double ChangeCoordinates(double longitude, double latitudes, Random random)
        {
            GeoCoordinate initialCoodinates = new GeoCoordinate(latitudes, longitude);

            double maxLatitude = latitude + RangeModifier;
            double minLatitude = latitude - RangeModifier;

            double newLatitude = random.NextDouble() * (maxLatitude - minLatitude) + minLatitude;

            double maxLongtitude = longitude + RangeModifier;
            double minLongtitude = longitude - RangeModifier;

            double newLongitude = random.NextDouble() * (maxLongtitude - minLongtitude) + minLongtitude;

            if(ValiteCoordinates(newLatitude, newLongitude))
            {
                return ChangeCoordinates(longitude, latitudes, random);
            }

            GeoCoordinate newCoordinates = new GeoCoordinate(newLatitude, newLongitude);

            // distance is returned in meters
            double distance = initialCoodinates.GetDistanceTo(newCoordinates);

            if (distance <= 5000)
            {
                return distance;
            }

            return ChangeCoordinates(longitude, latitudes, random);
        }

        private bool ValiteCoordinates(double newLatitude, double newLongitude)
        {
            return newLatitude < -90.0 || newLatitude > 90.0
                || newLongitude < -180.0 || newLongitude > 180.0;
        }
        #endregion
    }
}

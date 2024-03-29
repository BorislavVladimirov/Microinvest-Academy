﻿using CourtTask.Common;
using CourtTask.Models.Citizens.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourtTask.Models.Citizens
{
    public abstract class Citizen : ICitizen
    {
        private string name;
        private string adress;
        private int age;
        private string id;

        public Citizen(string id, string name, string adress, int age)
        {
            ID = id;
            Name = name;
            Adress = adress;
            Age = age;
        }

        public string ID
        {
            get => this.id;

            protected set
            {
                if (value == this.id)
                {
                    return;
                }

                if (value.Length != 10)
                {
                    throw new ArgumentException(GlobalConstants.InvalidPersonalID);
                }

                // 1900 - 31.12.1999
                if (value[2] == '0' || value[2] == '1')
                {
                    if (value[4] != '0'
                        && value[4] != '1'
                        && value[4] != '2'
                        && value[4] != '3')
                    {
                        throw new ArgumentException(GlobalConstants.InvalidPersonalID);
                    }
                }
                else
                {
                    if (value[2] != '4' && value[2] != '5')
                    {
                        throw new ArgumentException(GlobalConstants.InvalidPersonalID);
                    }

                    if (value[4] != '0'
                        && value[4] != '1'
                        && value[4] != '2'
                        && value[4] != '3')
                    {
                        throw new ArgumentException(GlobalConstants.InvalidPersonalID);
                    }
                }


                this.id = value;
            }
        }

        public string Name
        {
            get => this.name;

            protected set
            {
                if (value == this.name)
                {
                    return;
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidName);
                }

                this.name = value;
            }
        }

        public string Adress
        {
            get => this.adress;

            protected set
            {
                if (value == this.adress)
                {
                    return;
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidAdress);
                }

                this.adress = value;
            }
        }

        public int Age
        {
            get => this.age;

            protected set
            {
                if (value == this.age)
                {
                    return;
                }

                if (value < 18)
                {
                    throw new ArgumentException(GlobalConstants.InvalidAge);
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format(" {0} {1} ", GlobalConstants.CitizenInfo, this.Name);
        }
    }
}

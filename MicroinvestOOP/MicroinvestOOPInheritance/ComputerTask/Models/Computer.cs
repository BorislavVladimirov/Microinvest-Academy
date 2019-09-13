using ComputerTask.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerTask.Models
{
    public class Computer
    {
        private int year;
        private decimal price;
        private double hardDiskMemory;
        private double freeMemory;
        private string operationSystem;

        public Computer(int year, decimal price,
            double hardDiskMemory, double freeMemory,
            string operationSystem)
        {
            Year = year;
            Price = price;
            HardDiskMemory = hardDiskMemory;
            FreeMemory = freeMemory;
            OperationSystem = operationSystem;
        }

        #region Property
        public int Year
        {
            get => this.year;

            set
            {
                if (this.year == value)
                {
                    return;
                }

                if (value < GlobalConstants.YearOfProductionOfFirstComputer || value > DateTime.Now.Year)
                {
                    throw new ArgumentException(GlobalConstants.InvalidYear);
                }

                this.year = value;
            }
        }

        public decimal Price
        {
            get => this.price;

            set
            {
                if (this.price == value)
                {
                    return;
                }

                if (value < 0M)
                {
                    throw new ArgumentException(GlobalConstants.InvalidPrice);
                }

                this.price = value;
            }
        }

        public bool IsNotebook => this.GetType().Name == GlobalConstants.LaptopType;

        public double HardDiskMemory
        {
            get => this.hardDiskMemory;

            set
            {
                if (this.hardDiskMemory == value)
                {
                    return;
                }

                if (value < 0)
                {
                    throw new ArgumentException(GlobalConstants.InvalidDiskMemory);
                }

                this.hardDiskMemory = value;
            }
        }

        public double FreeMemory
        {
            get => this.freeMemory;

            set
            {
                if (this.freeMemory == value)
                {
                    return;
                }

                if (value < 0)
                {
                    throw new ArgumentException(GlobalConstants.InvalidFreeMemory);
                }

                this.freeMemory = value;
            }
        }

        public string OperationSystem
        {
            get => this.operationSystem;

            set
            {
                if (this.operationSystem == value)
                {
                    return;
                }

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidOpertionSystem);
                }

                this.operationSystem = value;
            }
        }

        #endregion

        #region Method

        public void ChangeOperationSystem(string newOperationSystem)
        {
            this.OperationSystem = newOperationSystem;
        }

        public void UseMemory(double memory)
        {
            if (this.FreeMemory - memory < 0)
            {
                throw new ArgumentException(GlobalConstants.NotEnoughMemory);
            }

            this.FreeMemory -= memory;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Production year: {this.Year}");
            sb.AppendLine($"Price: {this.Price}");
            sb.Append("Is notebook: ");
            sb.AppendLine(this.IsNotebook ? "Yes" : "No");
            sb.AppendLine($"Hard disk memory: {this.HardDiskMemory}");
            sb.AppendLine($"Free memory: {this.FreeMemory}");
            sb.AppendLine($"Operation system: {this.OperationSystem}");

            return sb.ToString();
        }
        #endregion      
    }
}

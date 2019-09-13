using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerTask.Models
{
    public class Laptop : Computer
    {
        public Laptop(int year, decimal price, double hardDiskMemory, double freeMemory, string operationSystem) 
            : base(year, price, hardDiskMemory, freeMemory, operationSystem)
        {
        }
    }
}

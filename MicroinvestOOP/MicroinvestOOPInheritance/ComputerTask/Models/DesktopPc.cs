using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerTask.Models
{
    public class DesktopPc : Computer
    {
        public DesktopPc(int year, decimal price, double hardDiskMemory, double freeMemory, string operationSystem) 
            : base(year, price, hardDiskMemory, freeMemory, operationSystem)
        {
        }
    }
}

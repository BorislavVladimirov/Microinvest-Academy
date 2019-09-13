using ComputerTask.Models;
using System;

namespace ComputerTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Laptop laptop = new Laptop(2015, 1555.83M, 1000, 950, "Linux");

                laptop.UseMemory(100);

                DesktopPc desktopPc = new DesktopPc(2019, 3999.99M, 500, 490, "Windows");

                desktopPc.ChangeOperationSystem("Linux");

                Console.WriteLine(laptop.ToString());
                Console.WriteLine(desktopPc.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

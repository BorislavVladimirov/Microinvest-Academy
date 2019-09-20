using PhoneTask.Models;
using System;
using System.Text;

namespace PhoneTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            
            try
            {
                GSM huawei = new GSM("Mate20Pro");

                GSM nokia = new GSM("Nokia3310");

                huawei.InsertSimCard("0888288822");
                nokia.InsertSimCard("0888599977");

                huawei.Call(nokia, 35);
                nokia.Call(huawei, 59);

                Console.WriteLine(nokia.PrintInfoForTheLastIncomingCall());
                Console.WriteLine(nokia.PrintInfoForTheLastOutgoingCall());
                
                Console.WriteLine(nokia.GetSumForCall());
                Console.WriteLine(huawei.GetSumForCall());

                huawei.RemoveSimCard();
                huawei.InsertSimCard("0888888888");

                huawei.Call(nokia, 35.34);

                Console.WriteLine(huawei.PrintInfoForTheLastIncomingCall());
                Console.WriteLine(huawei.PrintInfoForTheLastOutgoingCall());

                huawei.InsertSimCard("0899999999");
                Console.WriteLine(huawei.GetSumForCall());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

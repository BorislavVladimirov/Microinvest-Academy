using PhoneTask.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneTask.Models
{
    public class Call
    {
        private static decimal priceForAMinute = 0.25M;

        public Call(string receiver, double duration)
        {
            Receiver = receiver;
            Duration = duration;
        }

        #region Property
        public string Caller { get; set; }

        public string Receiver { get; set; }

        public double Duration { get; set; }

        public static decimal PriceForAMinute => priceForAMinute;
        #endregion      
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneTask.Common
{
    public static class GlobalConstants
    {
        public const string InvalidModel = "Invalid model!";

        public const string InvalidSimNumber = "Invalid sim number!";

        public const string InvalidCallDuration = "Call duration must be grater or equal to 0 and less than 60 minutes";

        public const string EqualNumbers = "Call receiver phone number must be different from caller phone number!";

        public const string MissingSimCard = "Both caller and receiver must have sim cards!";

        public const string InvalidSimRemove = "There is no sim card to be removed!";
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAndSecuredNotepad.Common
{
    public static class GlobalConstants
    {
        public const string InvalidTitle = "Invalid title!";

        public const string InvalidPageNumber = "Invalid page number!";

        public const string InvalidPassword = "Invalid password!";

        public const string ContainigGivenWord = "Does the page contain given word:";

        public const string ContainigDigit = "Does the page contain digits:";

        public const string PresentWord = "The given word is present in some pages.";

        public const string WordNotPresent = "The given word is not present in any of the pages";

        public const string NoDigitsPresent = "They are no digits in any of the pages";

        public const string ContentForPagesWithDigits = "Content of pages containing digits:";

        public const string DevideNotSwitchedOn = "Device needs to be switched on in order to use it's funtionality!";

        public const string PasswordNotStrongEnough = "Password must be atleast 5 characters long, contain " +
            "an upper case character , a lowercase character and a digit!";
    }
}

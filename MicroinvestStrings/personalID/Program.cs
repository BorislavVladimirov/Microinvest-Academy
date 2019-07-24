using System;

namespace personalID
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string stringToEncrypt = Console.ReadLine();

            for (int i = 0; i < stringToEncrypt.Length; i++)
            {
                if (char.IsDigit(stringToEncrypt[i]))
                {
                    int startingIndex = i;
                    string id = string.Empty;

                    if (startingIndex <= stringToEncrypt.Length - 1 - 9)
                    {
                        id = stringToEncrypt.Substring(startingIndex, 10);
                    }
                    else
                    {
                        break;
                    }

                    if (AreNextNineCharsDigits(id))
                    {
                        EncryptString(id, ref stringToEncrypt);
                    }
                }
            }

            Console.WriteLine(stringToEncrypt);
        }

        private static void EncryptString(string id, ref string stringToEncrypt)
        {
            int thirdDigit = int.Parse(id[2].ToString());
            int fifthDigit = int.Parse(id[4].ToString());

            if (thirdDigit == 0 || thirdDigit == 1) // check for valid month 
            {
                if (fifthDigit < 4 && fifthDigit >= 0) // check for valid date
                {
                    stringToEncrypt = stringToEncrypt.Replace(id, "**********");
                }
            }
        }

        private static bool AreNextNineCharsDigits(string id)
        {
            for (int i = 0; i < 10; i++)
            {
                if (!char.IsDigit(id[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAY_19_UserRegistration
{
    public class UserRegistration
    {
        public static string Regex_FirstName = "^[A-Z][a-z]{2,}$";

        public static bool ValidateFirstName(string FirstName)
        {
           return Regex.IsMatch(FirstName, Regex_FirstName);
        }


        public static void checkFirstName(string FirstName)
        {
            if (Regex.IsMatch(FirstName, Regex_FirstName) == false)
            {
                Console.WriteLine("Enter valid First name. It should Start with capital letters and minimum 3 letters!");
            }
            else
            {
                Console.WriteLine("It is Valid!");
            }
        }

    }
}

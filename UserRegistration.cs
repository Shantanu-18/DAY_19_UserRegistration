using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAY_19_UserRegistration
{
    public class UserRegistration
    {
        public static string Regex_FirstName = "^[A-Z][a-z]{2,}$";
        public static string Regex_LastName = "^[A-Z][a-z]{2,}$";
        public static string Regex_Email = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        public static string Regex_Number = "^[0-9]{2}[ ][6-9][0-9]{9}$";
        public static string Regex_Password = "^((?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%^&*-_.])(?=.{8,}))";


        public bool ValidateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, Regex_FirstName);
        }


        public bool ValidateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, Regex_LastName);
        }
       

        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, Regex_Email);
        }
       

        public bool validatenumber(string number)
        {
            return Regex.IsMatch(number, Regex_Number);
        }
       

        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }
    }
}

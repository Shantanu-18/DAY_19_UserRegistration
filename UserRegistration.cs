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
        public static string Regex_Password = "^((?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*-_.])(?=.{8,}))";


        public bool ValidateFirstName(string FirstName)
        {
            var result = Regex.IsMatch(FirstName, Regex_FirstName);
            try
            {
                if (result==false)
                {
                    if (FirstName == string.Empty || FirstName == " ")
                    {
                        
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE,
                                "Enter first name it should not be blank.");
                    }
                    else if (result == false)
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_INPUT,
                                "Enter valid first name it should start with Capital letter.");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Regex.IsMatch(FirstName, Regex_FirstName);
        }

       
        public bool ValidateLastName(string LastName)
        {
            var result = Regex.IsMatch(LastName, Regex_LastName);
            try
            {
                if (result == false)
                {
                    if (LastName == string.Empty || LastName == " ")
                    {

                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE,
                                "Enter last name it should not be blank.");
                    }
                    else if (result == false)
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_INPUT,
                                "Enter valid last name it should start with Capital letter.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return Regex.IsMatch(LastName, Regex_LastName);
        }

       
        public bool validateEmail(string email)
        {
            var result = Regex.IsMatch(email, Regex_Email);
            try
            {
                if (result == false)
                {
                    if (email == string.Empty || email == " ")
                    {

                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE,
                                "Enter email it should not be blank.");
                    }
                    else if (result == false)
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_INPUT,
                                "Enter valid email address.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Regex.IsMatch(email, Regex_Email);
        }
       
        public bool validatenumber(string number)
        {
            var result = Regex.IsMatch(number, Regex_Number);
            try
            {
                if (result == false)
                {
                    if (number == string.Empty || number == " ")
                    {

                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE,
                                "Enter Phone number it should not be blank.");
                    }
                    else if (result == false)
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_INPUT,
                                "Enter valid Phone number.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Regex.IsMatch(number, Regex_Number);
        }


        public bool validatePassword(string password)
        {
            var result = Regex.IsMatch(password, Regex_Password);
            try
            {
                if (result == false)
                {
                    if (password == string.Empty || password == " ")
                    {

                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE,
                                "Enter password it should not be blank.");
                    }
                    else if (result == false)
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_INPUT,
                                "Enter valid password.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Regex.IsMatch(password, Regex_Password);
        }

      
    }
}

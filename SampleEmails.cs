using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAY_19_UserRegistration
{
    public class SampleEmails
    {
        public static string Regex_SampleEmails = "^[A-Za-z]+([-.+#^*][0-9]+)?[0-9]*[@][A-Za-z0-9]+[.][A-Za-z]{2,}([.][a-zA-Z]{2,})?$";

        public bool emailValidate(string emailSample)
        {
            var result = Regex.IsMatch(emailSample, Regex_SampleEmails);
            try
            {
                if (result == false)
                {
                    if (emailSample == string.Empty || emailSample == " ")
                    {

                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE,
                                "Enter email address it should not be blank.");
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
            return Regex.IsMatch(emailSample, Regex_SampleEmails);
        }
    }
}

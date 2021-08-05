using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAY_19_UserRegistration
{
    class UsingLambdaExpression : UserRegistration
    {
        public string[] validationRegex = new string[5];
        public string[] userInput = new string[5];
        
        public void ValidationUsingRegex()
        {
            validationRegex[0] = Regex_FirstName;
            validationRegex[1] = Regex_LastName;
            validationRegex[2] = Regex_Email;
            validationRegex[3] = Regex_Number;
            validationRegex[4] = Regex_Password;

            Console.Write("\n1. Enter First Name: ");
            userInput[0] = Console.ReadLine();

            Console.Write("\n2. Enter Last Name: ");
            userInput[1] = Console.ReadLine();

            Console.Write("\n3. Enter your email addresss: ");
            userInput[2] = Console.ReadLine();

            Console.Write("\n4. Enter your mobile number: ");
            userInput[3] = Console.ReadLine();

            Console.Write("\n5. Enter your password: ");
            userInput[4] = Console.ReadLine();

            Console.WriteLine("\nYour input is valid if it is true and invalid if false.");

            for (int i = 0; i < 5; i++)
            {
                Func<string, bool> inputValidater = userinput => Regex.IsMatch(userInput[i], validationRegex[i]);
                bool result = inputValidater(userInput[i]);
                Console.WriteLine($"{i+1} {userInput[i]} : {result}");
            }

        }
    }
}

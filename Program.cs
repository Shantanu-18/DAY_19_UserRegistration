using System;

namespace DAY_19_UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration!");

            string FirstName,LastName;
            Console.Write("Enter First Name: ");
            FirstName = Console.ReadLine();
            UserRegistration.checkFirstName(FirstName);

            Console.Write("Enter Last Name: ");
            LastName = Console.ReadLine();
            UserRegistration.checkLastName(LastName);


        }
    }
}

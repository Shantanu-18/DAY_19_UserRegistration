using System;

namespace DAY_19_UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration!");

            string FirstName;
            Console.Write("Enter First Name: ");
            FirstName = Console.ReadLine();

            UserRegistration.checkFirstName(FirstName);




        }
    }
}

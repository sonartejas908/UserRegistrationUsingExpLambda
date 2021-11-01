using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationUsingExpLambda
{
    class Methods
    {
        public static void FirstNameInput()
        {
            UserInput user = new UserInput();
            Pattern patterns = new Pattern();
            bool status = false;
            while (status != true)
            {
                Console.WriteLine("Please enter your first name :");
                user.fName = Console.ReadLine();
                bool Status = patterns.validateName(user.fName);
                if (Status == true)
                {
                    Console.WriteLine("Accepted");
                    status = true;

                }
                else
                {
                    Console.WriteLine("Please enter valid input");
                }
            }
        }
        public static void LastNameInput()
        {
            UserInput user = new UserInput();
            Pattern patterns = new Pattern();
            bool status = false;
            while (status != true)
            {
                Console.WriteLine("Please enter your last name :");
                user.lName = Console.ReadLine();
                bool Status = patterns.validateName(user.lName);
                if (Status == true)
                {
                    Console.WriteLine("Accepted");
                    status = true;

                }
                else
                {
                    Console.WriteLine("Please enter valid input");
                }
            }
        }
        public static void EmailInput()
        {
            UserInput user = new UserInput();
            Pattern pattern = new Pattern();
            bool status = false;
            while (status != true)
            {
                Console.WriteLine("Please enter Gmail :");
                user.email = Console.ReadLine();
                bool Status = pattern.validateEmail(user.email);
                if (Status == true)
                {
                    Console.WriteLine("Accepted");
                    status = true;
                }
                else
                {
                    Console.WriteLine("Please enter valid input");
                }
            }
        }
        public static void MobileNumInput()
        {
            UserInput user = new UserInput();
            Pattern pattern = new Pattern();
            bool status = false;
            while (status != true)
            {
                Console.WriteLine("Enter your mobile number");
                user.mobileNum = Console.ReadLine();
                bool Status = pattern.validateMobileNum(user.mobileNum);
                if (Status == true)
                {
                    Console.WriteLine("Accepted");
                    status = true;
                }
                else
                {
                    Console.WriteLine("Please enter valid input");
                }
            }
        }
    }
}

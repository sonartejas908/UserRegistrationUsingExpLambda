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
    }
}

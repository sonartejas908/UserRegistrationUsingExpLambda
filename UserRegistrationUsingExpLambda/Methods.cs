using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationUsingExpLambda
{
    public class Methods
    {
        public static string FirstNameInput(string Fname)
        {
            UserInput user = new UserInput();
            Pattern patterns = new Pattern();
            user.fName = Fname;
                bool Status = patterns.validateName(user.fName);
                if (Status == true)
                {
                return "Happy";
                }
                else
                {
                return "Sad";
                }
            
        }
       
        public static string EmailInput(string email)
        {
            UserInput user = new UserInput();
            Pattern pattern = new Pattern();
            user.email = email;
                bool Status = pattern.validateEmail(user.email);
                if (Status == true)
                {
                return "Happy";  
                }
                else
                {
                return "Sad";
                }
            
        }
        public static string MobileNumInput(string mobno)
        {
            UserInput user = new UserInput();
            Pattern pattern = new Pattern();
            user.mobileNum = mobno;
                bool Status = pattern.validateMobileNum(user.mobileNum);
                if (Status == true)
                {
                return "Happy";
                }
                else
                {
                return "Sad";
                }
            
        }
        public static string PasswordInput(string Password)
        {
            Pattern pattern = new Pattern();
            UserInput user = new UserInput();
            user.password = Password;
                bool Status = pattern.validatePassword(user.password);
                if (Status == true)
                {
                return "Happy";   
                }
                else
                {
                return "Sad";
                }

            
        }
    }
}

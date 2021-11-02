using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingExpLambda
{
    public class Methods
    {
        public static string FirstNameInput(string Fname)
        {
                
            try
            {
                UserInput user = new UserInput();
                Pattern patterns = new Pattern();
                user.fName = Fname;
                if (string.IsNullOrEmpty(Fname))
                {
                    throw new RegexException(RegexException.InvalidUserDetails.EMPTY_NAME, "First Name Could not be null");
                }
                if(patterns.validateName(user.fName))
                    return "First Name Validated";
               else
                {
                    throw new RegexException(RegexException.InvalidUserDetails.INVALID_FIRST_NAME, "Name Entered is Invalid");
                }
                
            }
            catch (RegexException e)
            {
                return e.Message;
            }
            catch(Exception e)
            {
                return e.Message;
            }
            
        }

        public static string EmailInput(string Email)
        {

            try
            {
                UserInput user = new UserInput();
                Pattern patterns = new Pattern();
                user.email = Email;
                if (string.IsNullOrEmpty(Email))
                {
                    throw new RegexException(RegexException.InvalidUserDetails.EMPTY_EMAIL, "Email Could not be null");
                }
                if (patterns.validateEmail(user.email))
                    return "Email Validated";
                else
                {
                    throw new RegexException(RegexException.InvalidUserDetails.INVALID_EMAIL, "Email Entered is Invalid");
                }

            }
            catch (RegexException e)
            {
                return e.Message;
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public static string MobileNumInput(string mobile)
        {

            try
            {
                UserInput user = new UserInput();
                Pattern patterns = new Pattern();
                user.mobileNum = mobile;
                if (string.IsNullOrEmpty(mobile))
                {
                    throw new RegexException(RegexException.InvalidUserDetails.EMPTY_PHONE_NO, "Mobile Number Could not be null");
                }
                if (patterns.validateMobileNum(user.mobileNum))
                    return "Mobile Number Validated";
                else
                {
                    throw new RegexException(RegexException.InvalidUserDetails.INVALID_PHONE_NO, "Mobile Number Entered is Invalid");
                }

            }
            catch (RegexException e)
            {
                return e.Message;
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public static string PasswordInput(string password)
        {

            try
            {
                UserInput user = new UserInput();
                Pattern patterns = new Pattern();
                user.password = password;
                if (string.IsNullOrEmpty(password))
                {
                    throw new RegexException(RegexException.InvalidUserDetails.EMPTY_PASSWORD, "Password Could not be null");
                }
                if (patterns.validatePassword(user.password))
                    return "Password Validated";
                else
                {
                    throw new RegexException(RegexException.InvalidUserDetails.INVALID_PASSWORD, "Password Entered is Invalid");
                }

            }
            catch (RegexException e)
            {
                return e.Message;
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        Pattern pattern = new Pattern();
        public string LambdaExpressionFirstnameCheck() => Regex.IsMatch("Tejas", pattern.Regex_Name) ? "FirstName is Validated" : "firstName is Invalid";
        public string LambdaExpressionEmailCheck() => Regex.IsMatch("sonartejas908@gmail.com", pattern.Regex_Email) ? "Email is Validated" : "Email is Invlid"; 
        public string LambdaExpressionMobileCheck() => Regex.IsMatch("9004690046", pattern.Regex_MobileNum) ? "Mobile Number is Validated" : "Mobile Number is Invlid"; 
        public string LambdaExpressionPasswordCheck() => Regex.IsMatch("Tejas@123", pattern.Regex_Password) ? "Password is Validated" : "Password is Invlid"; 

    }

}

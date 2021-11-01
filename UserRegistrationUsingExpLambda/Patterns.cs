using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingExpLambda
{
    public class Pattern
    {
        public string Regex_Name = "^[A-Z][a-z]{2,}$";

        public bool validateName(string name)
        {
            return Regex.IsMatch(name, Regex_Name);
        }
    }
}

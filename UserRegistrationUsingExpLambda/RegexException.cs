using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationUsingExpLambda
{
    public class RegexException : Exception
    {
        public enum InvalidUserDetails
        {
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALID_PHONE_NO,
            INVALID_EMAIL,
            INVALID_PASSWORD,
            EMPTY_NAME,
            EMPTY_PHONE_NO,
            EMPTY_EMAIL,
            EMPTY_PASSWORD

        }
        public readonly InvalidUserDetails error;
        public RegexException(InvalidUserDetails error, string message) : base(message)
        {
            this.error = error;
        }
    }
}

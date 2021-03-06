using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class UserRegistrationException : Exception
    {
        public enum ExceptionType
        {
            INVALID_NAME,
            INVALID_EMAIL,
            INVALID_MOBILE_NUMBER,
            INVALID_PASSWORD,
        }

        private readonly ExceptionType _type;

        public UserRegistrationException(ExceptionType type, string message) : base(message)
        {
            this._type = type;
        }
    }
}
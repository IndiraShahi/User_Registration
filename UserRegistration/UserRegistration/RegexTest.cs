using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace UserRegistration
{
    class RegexTest
    {
        public string firstName = "^[A-Z]{1}[a-zA-z]{2,10}";

        /// <summary>
        /// Method to test First Name
        /// </summary>
        /// <param name="fName"></param>
        /// <returns></returns>
        public bool TestFirstName(string fName)
        {
            return Regex.IsMatch(fName, firstName);
        }
    }
}
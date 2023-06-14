using System;
using System.Text.RegularExpressions;

namespace User_Registration_Problem
{
    public class ValidLastName
    {
        // UC1 - As a user need to enter a valid Last Name
        public static bool LastName(string lastName)
        {
            string namePattern = "[A-Z]{1}[a-z]{2,}";

            Regex regex = new Regex(namePattern);

            return regex.IsMatch(lastName);
        }
    }
}

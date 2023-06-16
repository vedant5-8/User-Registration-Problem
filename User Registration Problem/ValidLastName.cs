using System;
using System.Text.RegularExpressions;

namespace User_Registration_Problem
{
    public class ValidLastName
    {
        // UC2 - As a user need to enter a valid Last Name
        public static bool LastName(string lastName)
        {
            string namePattern = "[A-Z]{1}[a-z]{2,}";

            Regex regex = new Regex(namePattern);

            Func<string, bool> match = (LName) => regex.IsMatch(LName);

            if (!match(lastName))
            {
                throw new InvalidUserDetails("The Lastname is not valid. \nLast Name: " + lastName);
            }
            else
            {
                return regex.IsMatch(lastName);
            }
        }
    }
}

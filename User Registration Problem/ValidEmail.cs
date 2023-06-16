using System;
using System.Text.RegularExpressions;

namespace User_Registration_Problem
{
    public class ValidEmail
    {
        // UC3 - As a User need to enter a valid email
        public static bool Email(string email)
        {

            string emailPattern = "^[0-9a-zA-Z]+[+._-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";

            Regex regex = new Regex(emailPattern);

            if (!regex.IsMatch(email))
            {
                throw new InvalidUserDetails("The email is not valid. \nEmail: " + email);
            }
            else
            {
                return regex.IsMatch(email);
            }

        }
    }
}

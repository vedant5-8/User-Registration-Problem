using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration_Problem
{
    public class ValidPassword
    {
        // UC5 - As a User need to follow pre-defined Password rules.
        // Rule 1 - Contains at least 8 characters.
        // Rule 2 - Contains at least one digit.
        // Rule 3 - Contains at least one lowercase letter.
        // Rule 4 - Contains at least one uppercase letter.
        // Rule 5 - Contains at least one special character.
        public static bool Password(string Password)
        {
            const string PasswordPattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()_+-={}?|:;,.]).{8,32}$";

            Regex regex = new Regex(PasswordPattern);

            return regex.IsMatch(Password);
        }
    }
}

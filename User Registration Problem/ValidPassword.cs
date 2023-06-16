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
        // As a User need to follow pre-defined Password rules.
        // UC5 - Contains at least 8 characters.
        // UC6 - Should have at least 1 Upper Case
        // UC7 - Should have at least 1 numeric number
        // UC8 - Should have at least 1 special character

        public static bool Password(string Password)
        {
            const string PasswordPattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()_+-={}?|:;,.]).{8,32}$";

            Regex regex = new Regex(PasswordPattern);

            Func<string, bool> match = (Password) => regex.IsMatch(Password);

            if (!match(Password))
            {
                throw new InvalidUserDetails("The password is not valid. \nPassword: " + Password);
            }
            else
            {
                return regex.IsMatch(Password);
            }
        }
    }
}

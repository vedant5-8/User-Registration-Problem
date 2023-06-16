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

        public static bool Password(string Password)
        {
            const string PasswordPattern = "^(?=.*[a-z])(?=.*[A-Z]).{8,32}$";

            Regex regex = new Regex(PasswordPattern);

            return regex.IsMatch(Password);
        }
    }
}

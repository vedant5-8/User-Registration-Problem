using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration_Problem
{
    public class ValidFirstName
    {
        // UC1 - As a User need to enter a valid First Name
        public static bool FirstName(string firstName)
        {
            string namePattern = "[A-Z]{1}[a-z]{2,}";

            Regex regex = new Regex(namePattern);

            return regex.IsMatch(firstName);
        }
    }
}

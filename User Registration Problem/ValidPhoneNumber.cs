using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration_Problem
{
    public class ValidPhoneNumber
    {
        // UC4 - As a User need to follow pre-defined Mobile Format
        public static bool IndianPhoneNumber(string number)
        {
            const string mobilePattern = @"^((\+91)|91|0)?[789][0-9]{9}$";

            Regex regex = new Regex(mobilePattern);

            return regex.IsMatch(number);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Registration_Problem
{
    public class InvalidUserDetails : Exception
    {
        public InvalidUserDetails() { }
        public InvalidUserDetails(string message) : base(message) { }
    }
}

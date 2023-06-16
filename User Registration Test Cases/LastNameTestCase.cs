using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Registration_Problem;

namespace User_Registration_Test_Cases
{
    [TestClass]
    public class LastNameTestCase
    {
        // Valid last name test cases

        [TestMethod]
        [DataRow("Patil")]
        [DataRow("Mhatre")]
        public void MultipleValidLastName(string LastName)
        {
            string actual = string.Empty;

            try
            {
                if (ValidLastName.LastName(LastName))
                {
                    actual = "Valid";
                }
            }
            catch (InvalidUserDetails ex)
            {
                actual = "An exception occurred: " + ex.Message;
            }

            string expected = "Valid";

            Assert.AreEqual(actual, expected);
        }

        // Invalid last name test cases

        [TestMethod]
        [DataRow("rathod")]
        [DataRow("kulkarni")]
        public void MultipleInvalidLastName(string LastName)
        {
            InvalidUserDetails ex = new InvalidUserDetails();
            string actual = string.Empty;
            string expected;

            try
            {
                if (ValidLastName.LastName(LastName))
                {
                    actual = "Valid";
                }

            }
            catch
            {
                actual = "An exception occurred: " + ex.Message;
            }

            expected = "An exception occurred: " + ex.Message;

            Assert.AreEqual(actual, expected);
        }
    }
}

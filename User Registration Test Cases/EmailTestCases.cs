using System;
using System.ComponentModel.DataAnnotations;
using User_Registration_Problem;

namespace User_Registration_Test_Cases
{
    [TestClass]
    public class EmailTestCases
    {
        // UC11 - Parameterised Test to validate multiple entry for the Email Address.

        // Valid Email address test cases

        [TestMethod]
        [DataRow("vedantnp200@gmail.com")]
        [DataRow("abc.sdf123@gmail.com")]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void MultipleValidEmails(string Email)
        {
            string actual = string.Empty;

            try
            {
                if (ValidEmail.Email(Email))
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

        // Invalid Email address test cases

        [TestMethod]
        [DataRow("abc")]
        [DataRow("abc@.com.my")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc.@gmail.com")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@gmail.com.aa.au")]
        public void MultipleInvalidEmails(string Email)
        {
            InvalidUserDetails ex = new InvalidUserDetails();
            string actual = string.Empty;
            string expected;

            try
            {
                if (ValidEmail.Email(Email))
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

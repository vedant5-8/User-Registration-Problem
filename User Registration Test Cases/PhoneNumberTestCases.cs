using User_Registration_Problem;

namespace User_Registration_Test_Cases
{
    [TestClass]
    public class PhoneNumberTestCases
    {
        // Valid phone number test cases

        [TestMethod]
        [DataRow("+918390386312")]
        [DataRow("918828777501")]
        [DataRow("09168329883")]
        [DataRow("8655588591")]
        public void MultipleValidPhoneNumber(string PhoneNumber)
        {
            string actual = string.Empty;

            try
            {
                if (ValidPhoneNumber.IndianPhoneNumber(PhoneNumber))
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

        // Invalid phone number test cases

        [TestMethod]
        [DataRow("91845698214")]
        [DataRow("-918264857545")]
        [DataRow("+118695845848")]
        public void MultipleInvalidPhoneNumber(string PhoneNumber)
        {
            InvalidUserDetails ex = new InvalidUserDetails();
            string actual = string.Empty;
            string expected;

            try
            {
                if (ValidPhoneNumber.IndianPhoneNumber(PhoneNumber))
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

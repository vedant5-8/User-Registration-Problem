using User_Registration_Problem;

namespace User_Registration_Test_Cases
{
    [TestClass]
    public class FirstNameTestCase
    {
        // Valid first name test cases

        [TestMethod]
        [DataRow("Sahil")]
        [DataRow("Manish")]
        public void MultipleValidFirstName(string FirstName)
        {
            string actual = string.Empty;

            try
            {
                if (ValidFirstName.FirstName(FirstName))
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

        // Invalid first name test cases

        [TestMethod]
        [DataRow("sumit")]
        [DataRow("shubham")]
        public void MultipleInvalidFirstName(string FirstName)
        {
            InvalidUserDetails ex = new InvalidUserDetails();
            string actual = string.Empty;
            string expected;

            try
            {
                if (ValidFirstName.FirstName(FirstName))
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
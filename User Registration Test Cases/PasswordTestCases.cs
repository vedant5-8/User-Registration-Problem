using User_Registration_Problem;

namespace User_Registration_Test_Cases
{
    [TestClass]
    public class PasswordTestCases
    {
        // Valid password test cases

        [TestMethod]
        [DataRow("IoaBMW,wa5782p.")]
        [DataRow("H!Mnpintd2r!")]
        [DataRow("4%\"Hf^C:U7+X")]
        public void MultipleValidPasswordTestCase(string Password)
        {
            string actual = string.Empty;

            try
            {
                if (ValidPassword.Password(Password))
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

        // Invalid password test cases

        [TestMethod]
        [DataRow("MmhIgammhcIrymmdisammjhmimy")]
        [DataRow("H9_@w2$")]
        [DataRow("A_HBF$KAUH@WB12")]
        [DataRow("al#gnlj6rn4gl7jn_")]
        public void MultipleInvalidPasswordTestCase(string Password)
        {
            InvalidUserDetails ex = new InvalidUserDetails();
            string actual = string.Empty;
            string expected;

            try
            {
                if (ValidPassword.Password(Password))
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

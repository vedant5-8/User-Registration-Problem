using User_Registration_Problem;

namespace User_Registration_Test_Cases
{
    [TestClass]
    public class PasswordTestCases
    {
        // Valid password test cases
        [TestMethod]
        public void TestCase1()
        {
            string Password = "IoaBMW,wa5782p.";
            string actual;

            if (ValidPassword.Password(Password))
            {
                actual = "Valid";
            }
            else
            {
                actual = "Invalid";
            }

            string expected = "Valid";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestCase2()
        {
            string Password = "H!Mnpintd2r!";
            string actual;

            if (ValidPassword.Password(Password))
            {
                actual = "Valid";
            }
            else
            {
                actual = "Invalid";
            }

            string expected = "Valid";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestCase3()
        {
            string Password = "4%\"Hf^C:U7+X";
            string actual;

            if (ValidPassword.Password(Password))
            {
                actual = "Valid";
            }
            else
            {
                actual = "Invalid";
            }

            string expected = "Valid";

            Assert.AreEqual(actual, expected);
        }

        // Invalid password test cases

        [TestMethod]
        public void TestCase4()
        {
            string Password = "MmhIgammhcIrymmdisammjhmimy ";
            string actual;

            if (ValidPassword.Password(Password))
            {
                actual = "Valid";
            }
            else
            {
                actual = "Invalid";
            }

            string expected = "Invalid";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestCase5()
        {
            string Password = "H9_@w2$";
            string actual;

            if (ValidPassword.Password(Password))
            {
                actual = "Valid";
            }
            else
            {
                actual = "Invalid";
            }

            string expected = "Invalid";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestCase6()
        {
            string Password = "A_HBF$KAUH@WB12";
            string actual;

            if (ValidPassword.Password(Password))
            {
                actual = "Valid";
            }
            else
            {
                actual = "Invalid";
            }

            string expected = "Invalid";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestCase7()
        {
            string Password = "al#gnlj6rn4gl7jn_";
            string actual;

            if (ValidPassword.Password(Password))
            {
                actual = "Valid";
            }
            else
            {
                actual = "Invalid";
            }

            string expected = "Invalid";

            Assert.AreEqual(actual, expected);
        }
    }
}

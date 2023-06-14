using User_Registration_Problem;

namespace User_Registration_Test_Cases
{
    [TestClass]
    public class PhoneNumberTestCases
    {
        // Valid phone number test cases
        [TestMethod]
        public void TestCase1()
        {
            string PhoneNumber = "+918390386312";
            string actual;

            if (ValidPhoneNumber.IndianPhoneNumber(PhoneNumber))
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
            string PhoneNumber = "918828777501";
            string actual;

            if (ValidPhoneNumber.IndianPhoneNumber(PhoneNumber))
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
            string PhoneNumber = "09168329883";
            string actual;

            if (ValidPhoneNumber.IndianPhoneNumber(PhoneNumber))
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
        public void TestCase4()
        {
            string PhoneNumber = "8655588591";
            string actual;

            if (ValidPhoneNumber.IndianPhoneNumber(PhoneNumber))
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

        // Invalid phone number test cases

        [TestMethod]
        public void TestCase5()
        {
            string PhoneNumber = "91845698214";
            string actual;

            if (ValidPhoneNumber.IndianPhoneNumber(PhoneNumber))
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
            string PhoneNumber = "-918264857545";
            string actual;

            if (ValidPhoneNumber.IndianPhoneNumber(PhoneNumber))
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
            string PhoneNumber = "+118695845848";
            string actual;

            if (ValidPhoneNumber.IndianPhoneNumber(PhoneNumber))
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

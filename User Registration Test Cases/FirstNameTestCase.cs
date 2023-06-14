using User_Registration_Problem;

namespace User_Registration_Test_Cases
{
    [TestClass]
    public class FirstNameTestCase
    {
        // Valid first name test cases
        [TestMethod]
        public void TestCase1()
        {
            string FirstName = "Sahil";
            string actual;

            if (ValidFirstName.FirstName(FirstName))
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
            string FirstName = "Manish";
            string actual;

            if (ValidFirstName.FirstName(FirstName))
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

        // Invalid first name test cases

        [TestMethod]
        public void TestCase3()
        {
            string FirstName = "shubham";
            string actual;

            if (ValidFirstName.FirstName(FirstName))
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
        public void TestCase4()
        {
            string FirstName = "kunal";
            string actual;

            if (ValidFirstName.FirstName(FirstName))
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
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
        [DataRow("sumit")]
        [DataRow("shubham")]
        public void MultipleInvalidFirstName(string FirstName)
        {
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
using System;
using User_Registration_Problem;

namespace User_Registration_Test_Cases
{
    [TestClass]
    public class EmailTestCases
    {
        // Valid Email address test cases
        [TestMethod]
        public void TestCase1()
        {
            string email = "abc@yahoo.com";
            string actual;

            if (ValidEmail.Email(email))
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
            string email = "abc-100@yahoo.com";
            string actual;

            if (ValidEmail.Email(email))
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
            string email = "abc.100@yahoo.com";
            string actual;

            if (ValidEmail.Email(email))
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
            string email = "abc111@abc.com";
            string actual;

            if (ValidEmail.Email(email))
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
        public void TestCase5()
        {
            string email = "abc-100@abc.net";
            string actual;

            if (ValidEmail.Email(email))
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
        public void TestCase6()
        {
            string email = "abc.100@abc.com.au";
            string actual;

            if (ValidEmail.Email(email))
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
        public void TestCase7()
        {
            string email = "abc@1.com";
            string actual;

            if (ValidEmail.Email(email))
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
        public void TestCase8()
        {
            string email = "abc@gmail.com.com";
            string actual;

            if (ValidEmail.Email(email))
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
        public void TestCase9()
        {
            string email = "abc+100@gmail.com";
            string actual;

            if (ValidEmail.Email(email))
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

        // Invalid Email address test cases

        [TestMethod]
        public void TestCase10()
        {
            string email = "abc";
            string actual;

            if (ValidEmail.Email(email))
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
        public void TestCase11()
        {
            string email = "abc@.com.my";
            string actual;

            if (ValidEmail.Email(email))
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
        public void TestCase12()
        {
            string email = "abc123@gmail.a";
            string actual;

            if (ValidEmail.Email(email))
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
        public void TestCase13()
        {
            string email = "abc123@.com";
            string actual;

            if (ValidEmail.Email(email))
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
        public void TestCase14()
        {
            string email = "abc123@.com.com";
            string actual;

            if (ValidEmail.Email(email))
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
        public void TestCase15()
        {
            string email = ".abc@abc.com";
            string actual;

            if (ValidEmail.Email(email))
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
        public void TestCase16()
        {
            string email = "abc()*@gmail.com";
            string actual;

            if (ValidEmail.Email(email))
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
        public void TestCase17()
        {
            string email = "abc@%*.com";
            string actual;

            if (ValidEmail.Email(email))
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
        public void TestCase18()
        {
            string email = "abc..2002@gmail.com";
            string actual;

            if (ValidEmail.Email(email))
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
        public void TestCase19()
        {
            string email = "abc.@gmail.com";
            string actual;

            if (ValidEmail.Email(email))
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
        public void TestCase20()
        {
            string email = "abc@abc@gmail.com";
            string actual;

            if (ValidEmail.Email(email))
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
        public void TestCase21()
        {
            string email = "abc@gmail.com.1a";
            string actual;

            if (ValidEmail.Email(email))
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
        public void TestCase22()
        {
            string email = "abc@gmail.com.aa.au";
            string actual;

            if (ValidEmail.Email(email))
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

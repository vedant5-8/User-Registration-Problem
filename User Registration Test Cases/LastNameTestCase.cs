﻿using System;
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
            string actual;

            if (ValidLastName.LastName(LastName))
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

        // Invalid last name test cases

        [TestMethod]
        [DataRow("rathod")]
        [DataRow("kulkarni")]
        public void TestCase1(string LastName)
        {
            string actual;

            if (ValidLastName.LastName(LastName))
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

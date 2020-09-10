using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            _Tutor_Demonstration.LeapYear myLeapYear = new _Tutor_Demonstration.LeapYear();
            bool result;

            result = myLeapYear.isLeapYear(2000);

            Assert.AreEqual(result, true);
        }
    }
}

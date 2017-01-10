using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void AddOneAndTwoGivesThree()
        {
            Math1 math = new Math1();

            int actual = math.Add(1, 2);

            Assert.AreEqual(3, actual, "Result not equal to 3");
        }

        [TestMethod]
        public void AddOneAndTwoGivesFour()
        {
            Math1 math = new Math1();
            int actual = math.Add(1, 2);
            Assert.AreEqual(4, actual,"Result is not equal to 4");
        }

    }
}

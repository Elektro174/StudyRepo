using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleTestApp;

namespace ConsoleTestApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMultiply()
        {
            double expected = 10;
            double actual = Program.Multiply(2, 5);
            Assert.AreEqual(expected, actual);
        }
    }
}

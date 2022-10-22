using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caculator;
namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        public Calculator cal;
        [TestInitialize]
        public void setup()
        {
            cal = new Calculator(3, 4);
        }
        [TestMethod]
        public void TestCong()
        {
            Assert.AreEqual(cal.Execute("+"), 7);
        }
        [TestMethod]
        public void TestTru()
        {
            Assert.AreEqual(cal.Execute("-"), -1);
        }
        [TestMethod]
        public void TestNhan()
        {
            Assert.AreEqual(cal.Execute("*"), 12);
        }
        [TestMethod]
        public void TestChia()
        {
            Assert.AreEqual(cal.Execute("/"), 3/4);
        }
        [TestMethod]
        public void TestChiaTron()
        {
            Calculator c = new Calculator(5, 3);
            Assert.AreEqual(c.Execute("/"), 2);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestChia0()
        {
            Calculator c = new Calculator(2, 0);
            c.Execute("/");
        }
    }
}

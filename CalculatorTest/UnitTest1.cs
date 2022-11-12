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
            Assert.AreEqual(c.Execute("/"), 1);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestChia0()
        {
            Calculator c = new Calculator(2, 0);
            c.Execute("/");
        }
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        @"D:\Calculator\CalculatorTest\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());
            string dau = TestContext.DataRow[3].ToString();
            dau = dau.Remove(0, 1);
            Calculator c = new Calculator(a, b);
            int actual = c.Execute(dau);
            Assert.AreEqual(expected, actual);
        }
    }
}

using Caculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestBaiTap
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            double expected = 1;
            double x = 2;
            int n = 0;
            Assert.AreEqual(expected, BaiTap.Power(x, n));
        }

        [TestMethod]
        public void TestMethod2()
        {
            double expected = 2;
            double x = 2;
            int n = 1;
            Assert.AreEqual(expected, BaiTap.Power(x, n));
        }

        [TestMethod]
        public void TestMethod3()
        {
            double expected = 0.5;
            double x = 2;
            int n = -1;
            Assert.AreEqual(expected, BaiTap.Power(x, n));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPolyn1()
        {
            int n = 2;
            List<int> a = new List<int> { 1, 2 };
            BaiTap2 p = new BaiTap2(n, a);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPolyn2()
        {
            int n = 2;
            List<int> a = new List<int> { 1, 2, 3,4 };
            BaiTap2 p = new BaiTap2(n, a);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPolyn3()
        {
            int n = -1;
            List<int> a = new List<int> {};
            BaiTap2 p = new BaiTap2(n, a);
        }

        [TestMethod]
        public void TestPolyn4()
        {
            int n = 2;
            List<int> a = new List<int> { 1, 2, 3 };
            int x = 1;
            int expected = 6;
            BaiTap2 p = new BaiTap2(n, a);
            Assert.AreEqual(expected, p.Cal(x));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRadix1()
        {
            int n = -1;
            Radix r = new Radix(n);
        }
      
        [TestMethod]
        public void TestRadix2()
        {

            int r = 2;
            int n = 6;
            Radix radix = new Radix(n);
            string expected = "110";
            Assert.AreEqual(expected, radix.ConvertDecimalToAnother(r));
        }

        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"D:\Calculator\CalculatorTest\Data\Bai03.csv", "Bai03#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestRadix3()
        {

            int n = int.Parse(TestContext.DataRow[0].ToString());
            int r = int.Parse(TestContext.DataRow[1].ToString()); ;
            Radix radix = new Radix(n);
            string expected = TestContext.DataRow[2].ToString();

           // expected = expected.Remove(0, 1);
            Assert.AreEqual(expected, radix.ConvertDecimalToAnother(r));
        }
    }

}

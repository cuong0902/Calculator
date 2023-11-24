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
    }
}

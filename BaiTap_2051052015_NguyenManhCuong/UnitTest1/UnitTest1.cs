using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest1
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
            Assert.AreEqual(expected, BaiTap.Bai1.Power(x, n));
        }
    }
}

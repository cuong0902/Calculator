using BaiTap_2051052015_NguyenManhCuong;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestBai1
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
            Assert.AreEqual(expected, BaiTap_2051052015_NguyenManhCuong.Bai1.Power(x, n));
        }
        [TestMethod]
        public void TestMethod2()
        {
            double expected = 2;
            double x = 2;
            int n = 1;
            Assert.AreEqual(expected, BaiTap_2051052015_NguyenManhCuong.Bai1.Power(x, n));
        }
        [TestMethod]
        public void TestMethod3()
        {
            double expected = 0.5;
            double x = 2;
            int n = -1;
            Assert.AreEqual(expected, BaiTap_2051052015_NguyenManhCuong.Bai1.Power(x, n));
        }

        //Bai 2
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestArgumentException1()
        {
            
            int n = 1;
            int x = -1;
            List<int> l = new List<int>() { 1, 2, 3 };
            Polynomial p = new Polynomial(n, l);
            p.Cal(x);      
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestArgumentException2()
        {

            int n = 2;
            int x = 1;
            List<int> l = new List<int>() { 3, 4 };
            Polynomial p = new Polynomial(n, l);
            p.Cal(x);
        }

        [TestMethod]
        
        public void TestBai2True()
        {

            int n = 2;
            int x = 1;
            List<int> l = new List<int>() { 1,2, 3 };
            Polynomial p = new Polynomial(n, l);
            int expected = 6;
            Assert.AreEqual(expected, p.Cal(x));
        }

        //Bai 3
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBai3F1()
        {
            int r = 2;
            int n = -1;
            Radix x = new Radix(n);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBai3F2()
        {

            int r = 1;
            int n = 5;
            Radix radix = new Radix(n);
            string expected = "110";
            Assert.AreEqual(expected, radix.ConvertDecimalToAnother(r));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBai3F3()
        {

            int r = 17;
            int n = 5;
            Radix radix = new Radix(n);
            string expected = "110";
            Assert.AreEqual(expected, radix.ConvertDecimalToAnother(r));
        }
        [TestMethod]
        public void TestBai3T1()
        {

            int r = 2;
            int n = 6;
            Radix radix = new Radix(n);
            string expected = "110";
            Assert.AreEqual(expected, radix.ConvertDecimalToAnother(r));
        }

        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"D:\BaiTap_2051052015_NguyenManhCuong\TestBai1\Data\Data.csv", "Data#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestBai3T2()
        {

            int r = int.Parse(TestContext.DataRow[0].ToString());
            int n = int.Parse(TestContext.DataRow[1].ToString()); ;
            Radix radix = new Radix(n);
            string expected = TestContext.DataRow[2].ToString();
           
            expected = expected.Remove(0, 1);
            Assert.AreEqual(expected, radix.ConvertDecimalToAnother(r));
        }
    }
}

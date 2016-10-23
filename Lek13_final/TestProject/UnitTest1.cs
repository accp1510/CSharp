using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lek13;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 s = new Class1();
            double[] rez = s.Korni(1, 2, 3);
            Assert.IsNull(rez);
        }

        [TestMethod]
        public void TestKorni()
        {
            Class1 s = new Class1();
            double[] rez = s.Korni(1, 2, 1);
            Assert.AreEqual(rez[0], 2);
            Assert.AreEqual(rez[1], 1);
        }
    }
}

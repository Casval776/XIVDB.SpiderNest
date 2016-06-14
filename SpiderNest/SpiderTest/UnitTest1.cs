using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpiderNest;

namespace SpiderTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { 
            SpiderNest.SpiderNest.Start();
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebSiteAndUnitTestSample.Lib.UnitTest
{
    [TestClass]
    public class HelloFactory_Test
    {
        [TestMethod]
        public void GetHello_Test()
        {
            var f = new HelloFactory();
            var result = f.GetHello();
            Assert.AreEqual("Hello World", result);
        }
    }
}

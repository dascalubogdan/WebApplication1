using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebApplication1.Tests
{
    using Controllers;
    using Models;

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            HomeController c = new HomeController();
            Assert.IsNotNull(c.Index());
        }

        [TestMethod]
        public void TestMethod3()
        {
            GetViewModel c = new GetViewModel();
            Assert.IsNull(c.Hometown);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using KnockoutSamples.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutSamples.Controllers.Tests123456
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void ContactTest()
        {
            Assert.Fail();
        }
    }
}

namespace KnockoutSamples.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void AboutTest()
        {
            Assert.Fail();
        }
    }
}
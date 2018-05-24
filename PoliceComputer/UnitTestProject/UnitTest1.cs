using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoliceComputer;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConnection()
        {
            Assert.AreEqual("datasource=localhost;" +
                            "port=3307;" +
                            "username=root;" +
                            "password=;" +
                            "database=police_database;" , Methods.Connection());
        }

        [TestMethod]
        public void TestGetInformation()
        {
            Assert.AreEqual("Gabriel", Methods.GetInformation("tbl_civilian", "ID", "0162599M", "Name"));
        }

        [TestMethod]
        public void TestIsDriver()
        {
            Assert.IsTrue(Methods.IsDriver("0035859M"));
        }
    }
}

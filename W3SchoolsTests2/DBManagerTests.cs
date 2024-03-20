using Microsoft.VisualStudio.TestTools.UnitTesting;
using W3Schools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Schools.Tests
{
    [TestClass()]
    public class ConnectionTest
    {
        [TestMethod()]
        public void ConnectTest()
        {
            DBManager manager = new();
            bool result = manager.Connect();
            Assert.IsTrue(result);
        }
    }
}
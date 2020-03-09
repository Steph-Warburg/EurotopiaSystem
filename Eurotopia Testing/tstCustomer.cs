using System;
using EurotopiaClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eurotopia_Testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void InstanceOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }
    }
}

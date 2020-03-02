using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eurotopia_Testing
{
    [TestClass]
    public class tstVendors
    {
        [TestMethod]
        public void InstanceOK()
        {

            //Create an instance of the class we want to create 

            clsVendors VendorName = new clsVendors();

            //Test to see if it exists 

            Assert.IsNotNull(VendorName);

        }
    }
}

using System;
using EurotopiaClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eurotopia_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        {

            //Create an instance of the class we want to create 

            clsStaff StaffName = new clsStaff();

            //Test to see if it exists 

            Assert.IsNotNull(StaffName);

        }
    }
}

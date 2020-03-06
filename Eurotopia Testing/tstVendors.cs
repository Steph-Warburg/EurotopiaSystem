using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EurotopiaClasses;

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

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsVendors AVendor = new clsVendors();
            Boolean TestData = true;
            AVendor.Active = TestData;
            Assert.AreEqual(AVendor.Active, TestData);
        }

        [TestMethod]
        public void DataAddedPropertyOK()
        {
            clsVendors AVendor = new clsVendors();
            DateTime TestData = DateTime.Now.Date;
            AVendor.DateAdded = TestData;
            Assert.AreEqual(AVendor.DateAdded, TestData);
        }
        [TestMethod]
        public void VendorNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AVendor.VendorNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AVendor.VendorNo, TestData);
        }
        [TestMethod]
        public void VendorNameOK()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //create some test data to assign to the property
            string TestData = "Ice Bar";
            //assign the data to the property
            AVendor.VendorName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AVendor.VendorName, TestData);
        }
        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AVendor.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AVendor.HouseNo, TestData);
        }
        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            AVendor.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AVendor.Street, TestData);
        }
        [TestMethod]
        public void CityPropertyOK()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //create some test data to assign to the property
            string TestData = "Rome";
            //assign the data to the property
            AVendor.City = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AVendor.City, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            AVendor.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AVendor.PostCode, TestData);
        }
        [TestMethod]
        public void CountryPropertyOK()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //create some test data to assign to the property
            string TestData = "Italy";
            //assign the data to the property
            AVendor.Country = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AVendor.Country, TestData);
        }



    }
}

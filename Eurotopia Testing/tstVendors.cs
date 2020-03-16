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
            Int32 TestData = 21;
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

        [TestMethod]
        public void VendorTypePropertyOK()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //create some test data to assign to the property
            string TestData = "Food";
            //assign the data to the property
            AVendor.VendorType = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AVendor.VendorType, TestData);
        }

        [TestMethod]
        public void SummaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //create some test data to assign to the property
            string TestData = "A club.";
            //assign the data to the property
            AVendor.Summary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AVendor.Summary, TestData);
        }

        /*
         *   Find Tests
         * 
         * **/

        [TestMethod]
        public void FindMethodOK()
        {
            clsVendors AVendor = new clsVendors();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 VendorNo = 1;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestVendorNoFound()
        {
            clsVendors AVendor = new clsVendors();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data id OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 VendorNo = 21;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the address no
            if (AVendor.VendorNo != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDateAddedFound()
        {
            clsVendors AVendor = new clsVendors();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data id OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 VendorNo = 21;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the address no
            if (AVendor.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHouseNoFound()
        {
            clsVendors AVendor = new clsVendors();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data id OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 VendorNo = 21;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the address no
            if (AVendor.HouseNo != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStreetFound()
        {
            clsVendors AVendor = new clsVendors();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data id OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 VendorNo = 21;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the address no
            if (AVendor.Street != "Test Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCityFound()
        {
            clsVendors AVendor = new clsVendors();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data id OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 VendorNo = 21;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the address no
            if (AVendor.City != "Test City")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPostCodeFound()
        {
            clsVendors AVendor = new clsVendors();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data id OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 VendorNo = 21;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the address no
            if (AVendor.PostCode != "LE1 7DX")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCountryFound()
        {
            clsVendors AVendor = new clsVendors();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data id OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 VendorNo = 21;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the address no
            if (AVendor.Country != "Test Country")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestVendorNameFound()
        {
            clsVendors AVendor = new clsVendors();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data id OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 VendorNo = 21;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the address no
            if (AVendor.VendorName != "Test Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestVendorTypeFound()
        {
            clsVendors AVendor = new clsVendors();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data id OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 VendorNo = 21;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the address no
            if (AVendor.VendorType != "Test Type")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSummaryFound()
        {
            clsVendors AVendor = new clsVendors();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data id OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 VendorNo = 21;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the address no
            if (AVendor.Summary != "Summary")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 VendorNo = 21;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the property
            if (AVendor.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}

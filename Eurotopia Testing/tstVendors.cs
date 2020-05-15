using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EurotopiaClasses;

namespace Eurotopia_Testing
{
    [TestClass]
    public class tstVendors
    {

        //good test data
        string VendorName = "Test Vendor";
        string HouseNo = "12b";
        string Street = "some street";
        string City = "Leicester";
        string Country = "UK";
        string PostCode = "LE1 1AS";
        string DateAdded = DateTime.Now.Date.ToString();
        string VendorType = "Food";
        string Summary = " Ice cream parlour";

        /*
         * *   Validation Tests
         * *
         * * **/
        [TestMethod]
        public void ValidMethodOk()
        {
            //create instance of the new class
            clsVendors AVendor = new clsVendors();
            //string variable to store any error messages
            String Error = "";
            //invoke the method
            Error = AVendor.Valid( HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        /*Validation tests for HouseNo
         * * */

        [TestMethod]
        public void HouseNoMinLessOne()
        {
            clsVendors AVendor = new clsVendors();
            String Error = "";
            string HouseNo = "";
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            Assert.AreNotEqual(Error, "");

        }

        public void HouseNoMin()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "a"; //this should be ok
                                  //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aa"; //this should be ok
                                   //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaaaa"; //this should be ok
                                      //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void HouseNoMax()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMid()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaa"; //this should be ok
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMaxPlusOne()
        {
            clsVendors AVendor = new clsVendors();
            String Error = "";
            string HouseNo = "aaaaaaa";
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void HouseNoExtremeMax()
        {
            clsVendors AVendor = new clsVendors();
            String Error = "";
            //create test data to pass to the method
            string HouseNo = "";
            HouseNo = HouseNo.PadRight(500, 'a');
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            Assert.AreNotEqual(Error, "");

        }

        /*Validation tests for DateAdded
         * */

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsVendors AVendor = new clsVendors();
            String Error = "";
            //create variable to store the test date
            DateTime TestDate;
            //set TestDate to todays date
            TestDate = DateTime.Now.Date;
            //change date to 100 years ago
            TestDate = TestDate.AddYears(-100);
            //convert to string
            string DateAdded = TestDate.ToString();
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsVendors AVendor = new clsVendors();
            String Error = "";
            //create variable to store the test date
            DateTime TestDate;
            //set TestDate to todays date
            TestDate = DateTime.Now.Date;
            //change date to yesterday
            TestDate = TestDate.AddDays(-1);
            //convert to string
            string DateAdded = TestDate.ToString();
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedMin()
        {
            clsVendors AVendor = new clsVendors();
            String Error = "";
            //create variable to store the test date
            DateTime TestDate;
            //set TestDate to todays date
            TestDate = DateTime.Now.Date;
            //convert to string
            string DateAdded = TestDate.ToString();
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsVendors AVendor = new clsVendors();
            String Error = "";
            //create variable to store the test date
            DateTime TestDate;
            //set TestDate to todays date
            TestDate = DateTime.Now.Date;
            //change date to tomorrow
            TestDate = TestDate.AddDays(1);
            //convert to string
            string DateAdded = TestDate.ToString();
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsVendors AVendor = new clsVendors();
            String Error = "";
            //create variable to store the test date
            DateTime TestDate;
            //set TestDate to todays date
            TestDate = DateTime.Now.Date;
            //change date to 100 years in the future
            TestDate = TestDate.AddYears(100);
            //convert to string
            string DateAdded = TestDate.ToString();
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsVendors AVendor = new clsVendors();
            String Error = "";
            //set DateAdded to a non data value
            string DateAdded = "this is not a date!";
            //invoke method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /*Validation tests for VendorName
         * * */

        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PostCode = "";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "a";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aa";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaaaaaa";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaaaaaaa";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PostCode = "aaaaaaaaaa";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaa";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /*Validation tests for Street
         * * */
        [TestMethod]
        public void StreetMinLessOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Street = "";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetMin()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "a";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMinPlusOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "aa";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxLessOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "";
            Street = Street.PadRight(49, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMax()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "";
            Street = Street.PadRight(50, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Street = "";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetMid()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "";
            Street = Street.PadRight(25, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /*Validation tests for City
         * */
        [TestMethod]
        public void CityMinLessOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string City = "";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CityMin()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Town = "a";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string City = "aa";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string City = "";
            City = City.PadRight(49, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMax()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string City = "";
            City = City.PadRight(50, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string City = "";
            City = City.PadRight(51, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CityMid()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string City = "";
            City = City.PadRight(25, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /*Validation tests for Country
         * * */
        [TestMethod]
        public void CountryMinLessOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Country = "";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CountryMin()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Country = "a";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Country = "aa";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CountryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Country = "";
            Country = Country.PadRight(9, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountryMax()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Country = "";
            Country = Country.PadRight(10, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string Country = "";
            Country = Country.PadRight(11, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CountryMid()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Country = "";
            Country = Country.PadRight(5, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        /*Validation tests for VendorName
         * */
        [TestMethod]
        public void VendorNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string VendorName = "";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VendorNameMin()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string VendorName = "a";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VendorNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string VendorName = "aa";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VendorNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string VendorName = "";
            VendorName = VendorName.PadRight(29, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VendorNameMax()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string VendorName = "";
            VendorName = VendorName.PadRight(30, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VendorNamePlusOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string VendorName = "";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VendorNameMid()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string VendorName = "";
            VendorName = VendorName.PadRight(15, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /*Validation tests for VendorType
         * * */
        [TestMethod]
        public void VendorTypeMinLessOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string VendorType = "";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VendorTypeMin()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string VendorType = "a";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VendorTypeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string VendorType = "aa";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void VendorTypeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string VendorType = "";
            VendorType = VendorType.PadRight(9, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VendorTypeMax()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string VendorType = "";
            VendorType = VendorType.PadRight(10, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VendorTypeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string VendorType = "";
            VendorType = VendorType.PadRight(11, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void VendorTypeMid()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string VendorType = "";
            VendorType = VendorType.PadRight(5, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /*Validation tests for Summary
         * * */
        [TestMethod]
        public void SummaryMinLessOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Summary = "";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SummaryMin()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Summary = "a";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SummaryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Summary = "aa";
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SummaryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Summary = "";
            Summary = Summary.PadRight(49, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SummaryMax()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Summary = "";
            Summary = Summary.PadRight(50, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SummaryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string Summary = "";
            Summary = Summary.PadRight(51, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void SummaryMid()
        {
            //create an instance of the class we want to create
            clsVendors AVendor = new clsVendors();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Summary = "";
            Summary = Summary.PadRight(25, 'a');
            //invoke the method
            Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


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
            AVendor.OpenToBookings = TestData;
            Assert.AreEqual(AVendor.OpenToBookings, TestData);
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
            string TestData = "21";
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
            Int32 VendorNo = 32;
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
            Int32 VendorNo = 32;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the address no
            if (AVendor.VendorNo != 32)
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
            Int32 VendorNo = 32;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the address no
            if (AVendor.DateAdded != Convert.ToDateTime("04/12/2009"))
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
            Int32 VendorNo = 32;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the address no
            if (AVendor.HouseNo != "1     ")
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
            Int32 VendorNo = 32;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the address no
            if (AVendor.Street != "Piazza del Colosseo                               ")
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
            Int32 VendorNo = 32;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the address no
            if (AVendor.City != "Rome                ")
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
            Int32 VendorNo = 32;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the address no
            if (AVendor.PostCode != "00184     ")
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
            Boolean OK = false;
            //create some test data to use with the method
            Int32 VendorNo = 32;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the address no
            if (AVendor.Country.Contains("Italy"))
            {
                OK = true;
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
            Boolean OK = false;
            //create some test data to use with the method
            Int32 VendorNo = 32;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the address no
            if (AVendor.VendorName.Contains("Colosseum"))
            {
                OK = true;
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
            Int32 VendorNo = 32;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the address no
            if (AVendor.VendorType != "Historical")
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
            Boolean OK = false;
            //create some test data to use with the method
            Int32 VendorNo = 32;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the address no
            if (AVendor.Summary.Contains("One of the worlds wonders!"))
            {
                OK = true;
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
            Int32 VendorNo = 32;
            //invoke the method
            Found = AVendor.Find(VendorNo);
            //check the property
            if (AVendor.OpenToBookings != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}

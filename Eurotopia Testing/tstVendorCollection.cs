using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EurotopiaClasses;

namespace Eurotopia_Testing { 
 
    [TestClass]
    public class tstVendorCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsVendorCollection AllVendors = new clsVendorCollection();
            //test to see that it exists
            Assert.IsNotNull(AllVendors);
        }
        [TestMethod]
        public void VendorListOK()
        {
            //create instance of class
            clsVendorCollection AllVendors = new clsVendorCollection();
            //create some test data to assign to the property
            List<clsVendors> TestList = new List<clsVendors>();
            //create and add item to list 
            clsVendors TestItem = new clsVendors();
            //set its properties 
            TestItem.OpenToBookings = true;
            TestItem.VendorNo = 1;
            TestItem.VendorName = "Pizza place";
            TestItem.HouseNo = "12a";
            TestItem.Street = "street name";
            TestItem.City = "city name";
            TestItem.Country = "Country name";
            TestItem.PostCode = "PO5 7CO";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.VendorType = "Food";
            TestItem.Summary = "The best pizza place.";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllVendors.VendorList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllVendors.VendorList, TestList);
        }
        
        [TestMethod]
        public void ThisVendorPropertyOk()
        {
            clsVendorCollection AllVendors = new clsVendorCollection();
            clsVendors TestVendor = new clsVendors();
            //set properties pf the test object
            TestVendor.OpenToBookings = true;
            TestVendor.VendorNo = 1;
            TestVendor.VendorName = "Pizza place";
            TestVendor.HouseNo = "12a";
            TestVendor.Street = "street name";
            TestVendor.City = "city name";
            TestVendor.Country = "Country name";
            TestVendor.PostCode = "PO5 7CO";
            TestVendor.DateAdded = DateTime.Now.Date;
            TestVendor.VendorType = "Food";
            TestVendor.Summary = "The best pizza place.";
            //assign the data to the property
            AllVendors.ThisVendor = TestVendor;
            Assert.AreEqual(AllVendors.ThisVendor, TestVendor);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create instance of class
            clsVendorCollection AllVendors = new clsVendorCollection();
            List<clsVendors> TestList = new List<clsVendors>();
            clsVendors TestItem = new clsVendors();
            TestItem.OpenToBookings = true;
            TestItem.VendorNo = 1;
            TestItem.VendorName = "Pizza place";
            TestItem.HouseNo = "12a";
            TestItem.Street = "street name";
            TestItem.City = "city name";
            TestItem.Country = "Country name";
            TestItem.PostCode = "PO5 7CO";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.VendorType = "Food";
            TestItem.Summary = "The best pizza place.";
            TestList.Add(TestItem);
            AllVendors.VendorList = TestList;
            Assert.AreEqual(AllVendors.Count, TestList.Count);
        }
        
        //Methods for ADD, Find...
        [TestMethod]
        public void AddMethodOK()
        {
            clsVendorCollection AllVendors = new clsVendorCollection();
            clsVendors TestItem = new clsVendors();
            Int32 PrimaryKey = 0;
            TestItem.OpenToBookings = true;
            TestItem.VendorNo = 1;
            TestItem.VendorName = "Pizza place";
            TestItem.HouseNo = "12a";
            TestItem.Street = "street name";
            TestItem.City = "city name";
            TestItem.Country = "Country name";
            TestItem.PostCode = "PO5 7CO";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.VendorType = "Food";
            TestItem.Summary = "The best pizza place.";
            //set ThisVendor to the test data
            AllVendors.ThisVendor = TestItem;
            PrimaryKey = AllVendors.Add();
            TestItem.VendorNo = PrimaryKey;
            //find record
            AllVendors.ThisVendor.Find(PrimaryKey);
            Assert.AreEqual(AllVendors.ThisVendor, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsVendorCollection AllVendors = new clsVendorCollection();
            clsVendors TestItem = new clsVendors();
            Int32 PrimaryKey = 0;
            TestItem.OpenToBookings= true;
            TestItem.VendorNo = 1;
            TestItem.VendorName = "Pizza place";
            TestItem.HouseNo = "12a";
            TestItem.Street = "street name";
            TestItem.City = "city name";
            TestItem.Country = "Country name";
            TestItem.PostCode = "PO5 7CO";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.VendorType = "Food";
            TestItem.Summary = "The best pizza place.";
            //set ThisVendor to the test data
            AllVendors.ThisVendor = TestItem;
            PrimaryKey = AllVendors.Add();
            TestItem.VendorNo = PrimaryKey;
            //find the record
            AllVendors.ThisVendor.Find(PrimaryKey);
            //delete record
            AllVendors.Delete();
            //now find record
            Boolean Found = AllVendors.ThisVendor.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsVendorCollection AllVendors = new clsVendorCollection();
            clsVendors TestItem = new clsVendors();
            Int32 PrimaryKey = 0;
            TestItem.OpenToBookings = true;
            TestItem.VendorName = "Pizza place";
            TestItem.HouseNo = "12a";
            TestItem.Street = "street name";
            TestItem.City = "city name";
            TestItem.Country = "Country name";
            TestItem.PostCode = "PO5 7CO";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.VendorType = "Food";
            TestItem.Summary = "The best pizza place.";
            //set ThisVendor to the test data
            AllVendors.ThisVendor = TestItem;
            PrimaryKey = AllVendors.Add();
            TestItem.VendorNo = PrimaryKey;
            //modify the test data
            TestItem.OpenToBookings = false;
            TestItem.VendorName = "Pizza place";
            TestItem.HouseNo = "21a";
            TestItem.Street = "correct street";
            TestItem.City = "correct city";
            TestItem.Country = "Country name";
            TestItem.PostCode = "PO5 7CO";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.VendorType = "Food";
            TestItem.Summary = "The best pizza place.";
            //set the record based on the new test data
            AllVendors.ThisVendor = TestItem;
            AllVendors.Update();
            AllVendors.ThisVendor.Find(PrimaryKey);
            Assert.AreEqual(AllVendors.ThisVendor, TestItem);
        }
        //ReportByCountry Methods filters the records based on full of partial Country
        [TestMethod]
        public void ReportByCountryMethodOK()
        {
            clsVendorCollection AllVendors = new clsVendorCollection();
            clsVendorCollection FilteredVendors = new clsVendorCollection();
            FilteredVendors.ReportByCountry("");
            Assert.AreEqual(AllVendors.Count, FilteredVendors.Count);
        }
        [TestMethod]
        public void ReportByCountryNoneFound()
        {
            
            clsVendorCollection FilteredVendors = new clsVendorCollection();
            FilteredVendors.ReportByCountry("xxxxxx");
            Assert.AreEqual(0, FilteredVendors.Count);
        }
        [TestMethod]
        public void ReportByCountryTestDataFound()
        {

            clsVendorCollection FilteredVendors = new clsVendorCollection();
            Boolean OK = true;
            FilteredVendors.ReportByCountry("Italy");
            //chack that the correst number of records are found
            if (FilteredVendors.VendorList.Count == 4)
            {
                //check that the first record ID 7
                if (FilteredVendors.VendorList[0].VendorNo != 7)
                {
                    OK = false;
                }
                //check that the first record ID 10
                if (FilteredVendors.VendorList[1].VendorNo != 10)
                {
                    OK = false;
                }
                //check that the first record ID 12
                if (FilteredVendors.VendorList[2].VendorNo != 12)
                {
                    OK = false;
                }
                //check that the first record ID 32
                if (FilteredVendors.VendorList[3].VendorNo != 32)
                {
                    OK = false;
                }
            }
        }
    }
}

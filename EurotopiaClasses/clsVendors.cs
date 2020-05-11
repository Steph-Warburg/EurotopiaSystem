using ClassLibrary;
using System;

namespace EurotopiaClasses
{
    public class clsVendors
    {

        //creating of variables
        private Int32 mVendorNo;
        private String mHouseNo;
        private String mStreet;
        private String mCity;
        private String mPostCode;
        private String mCountry;
        private String mVendorName;
        private String mVendorType;
        private String mSummary;
        private bool mOpenToBookings;

        public bool OpenToBookings
        {
            get
            {
                return mOpenToBookings;
            }
            set
            {
                mOpenToBookings = value;
            }
        }
        private DateTime mDateAdded;
        public DateTime DateAdded {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }


        public int VendorNo {
            get
            {
                return mVendorNo;
            }
            set
            {
                mVendorNo = value;
            }
        }
        public string PostCode {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }
        }
        public string HouseNo
        {
            get
            {
                return mHouseNo;
            }
            set
            {
                mHouseNo = value;
            }
        }
        public string Street
        {
            get
            {
                return mStreet;
            }
            set
            {
                mStreet = value;
            }
        }
        public string City
        {
            get
            {
                return mCity;
            }
            set
            {
                mCity = value;
            }
        }
        public string Country
        {
            get
            {
                return mCountry;
            }
            set
            {
                mCountry = value;
            }
        }
        public string VendorName
        {
            get
            {
                return mVendorName;
            }
            set
            {
                mVendorName = value;
            }
        }
        public string VendorType
        {
            get
            {
                return mVendorType;
            }
            set
            {
                mVendorType = value;
            }
        }
        public string Summary
        {
            get
            {
                return mSummary;
            }
            set
            {
                mSummary= value;
            }
        }

        public bool Find(int VendorNo)
        {
            //creating an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add parameter for the Vendor No
            DB.AddParameter("@VendorNo", VendorNo);
            //execute stored procedure
            DB.Execute("sproc_tblVendor_FilterByVendorNumber");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy data from database to private data members
                mHouseNo = Convert.ToString(DB.DataTable.Rows[0]["HouseNo"]);
                mStreet = Convert.ToString(DB.DataTable.Rows[0]["Street"]);
                mCity = Convert.ToString(DB.DataTable.Rows[0]["City"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
                mCountry = Convert.ToString(DB.DataTable.Rows[0]["Country"]);
                mVendorNo = Convert.ToInt32(DB.DataTable.Rows[0]["VendorNo"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mVendorName = Convert.ToString(DB.DataTable.Rows[0]["VendorName"]);
                mVendorType = Convert.ToString(DB.DataTable.Rows[0]["VendorType"]);
                mSummary = Convert.ToString(DB.DataTable.Rows[0]["Summary"]);
                mOpenToBookings = Convert.ToBoolean(DB.DataTable.Rows[0]["OpentoBookings"]);
                //always return true
                return true;
            }
            //if no record is found
            else
            {
                return false;
            }

        }
        //function for the public validation method
        public string Valid(string houseNo, string street, string city, string postCode, string country, string dateAdded, string vendorName, string vendorType, string summary)
            //function accepts several parameters for validation, returns a string containing any error messages
            //if no errors found then it returns a blank string
        {
            //create a string  variable to store the error
            String Error = "";
            //if the HouseNo is Blank
            if(houseNo.Length == 0)
            {
                //record the error
                Error = Error + "The house number may not be blank : ";
            }
            //if houseNo is greater than 6 characters
            if(houseNo.Length > 6)
            {
                Error = Error + " The house no must be less than 6 characters : ";
            }


            try
            {
                DateTime
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The data was not a valid date : ";
            }

            //is the post code blank
            if (postCode.Length == 0)
            {
                //record the error
                Error = Error + "The post code may not be blank : ";
            }
            //if the post code is too long
            if (postCode.Length > 9)
            {
                //record the error
                Error = Error + "The post code must be less than 9 characters : ";
            }
            //is the street blank
            if (street.Length == 0)
            {
                //record the error
                Error = Error + "The street may not be blank : ";
            }
            //if the street is too long
            if (street.Length > 50)
            {
                //record the error
                Error = Error + "The street must be less than 50 characters : ";
            }
            //is the town blank
            if (city.Length == 0)
            {
                //record the error
                Error = Error + "The town may not be blank : ";
            }
            //if the town is too long
            if (city.Length > 50)
            {
                //record the error
                Error = Error + "The town must be less than 50 characters : ";
            }
            //return any error messages
            return Error;
        }
    }
}
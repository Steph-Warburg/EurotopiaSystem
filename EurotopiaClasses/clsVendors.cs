using ClassLibrary;
using System;

namespace EurotopiaClasses
{
    public class clsVendors
    {

        //creating of variables
        private Int32 mVendorNo;
        private Int32 mHouseNo;
        private String mStreet;
        private String mCity;
        private String mPostCode;
        private String mCountry;
        private String mVendorName;
        private String mVendorType;
        private String mSummary;
        private bool mActive;

        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
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
        public Int32 HouseNo
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
                mHouseNo = Convert.ToInt32(DB.DataTable.Rows[0]["HouseNo"]);
                mStreet = Convert.ToString(DB.DataTable.Rows[0]["Street"]);
                mCity = Convert.ToString(DB.DataTable.Rows[0]["City"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
                mCountry = Convert.ToString(DB.DataTable.Rows[0]["Country"]);
                mVendorNo = Convert.ToInt32(DB.DataTable.Rows[0]["VendorNo"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mVendorName = Convert.ToString(DB.DataTable.Rows[0]["VendorName"]);
                mVendorType = Convert.ToString(DB.DataTable.Rows[0]["VendorType"]);
                mSummary = Convert.ToString(DB.DataTable.Rows[0]["Summary"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["OpentoBookings"]);
                //always return true
                return true;
            }
            //if no record is found
            else
            {
                return false;
            }
        }
    }
}
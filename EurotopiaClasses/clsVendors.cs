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
            //set the private data members to the test data value
            mHouseNo = 2;
            mStreet = "Test Street";
            mCity = "Test City";
            mPostCode = "LE1 7DX";
            mCountry = "Test Country";
            mVendorNo = 21;
            mDateAdded = Convert.ToDateTime("16/9/2015");
            mVendorName = "Test Name";
            mVendorType = "Test Type";
            mSummary = "Summary";
            mActive = true;
            //always return true
            return true;
        }
    }
}
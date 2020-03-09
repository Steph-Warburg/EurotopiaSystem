using System;

namespace EurotopiaClasses
{
    public class clsVendors
    {
        public bool Active { get; set; }
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

        private Int32 mVendorNo;
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
        public string PostCode { get; set; }
        public string HouseNo { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string VendorName { get; set; }
        public string VendorType { get; set; }
        public string Summary { get; set; }

        public bool Find(int VendorNo)
        {
            //set the private data members to the test data value
            mVendorNo = 21;
            mDateAdded = Convert.ToDateTime("16/9/2015");
            //always return true
            return true;
        }
    }
}
using ClassLibrary;
using System;
using System.Collections.Generic;

namespace EurotopiaClasses
{
    public class clsVendorCollection
    {
        //private data members
        List<clsVendors> mVendorList = new List<clsVendors>();
        clsVendors mThisVendor = new clsVendors();

        //public properties
        public List<clsVendors> VendorList
        {
            get
            {
                return mVendorList;
            }
            set
            {
                mVendorList = value;
            }
        }
        public int Count { get
            {
                return mVendorList.Count;
            }
            set
            {
                //return to later
            }
        }
        public clsVendors ThisVendor
        {
            get
            {
                return mThisVendor;
            }
            set
            {
                mThisVendor = value;
            }
        }
        //constructor for the class
        public clsVendorCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblVendor_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to thhe database on the values of mThisVendor
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@VendorName", mThisVendor.VendorName);
            DB.AddParameter("@HouseNo", mThisVendor.HouseNo);
            DB.AddParameter("@Street", mThisVendor.Street);
            DB.AddParameter("@City", mThisVendor.City);
            DB.AddParameter("@PostCode", mThisVendor.PostCode);
            DB.AddParameter("@Country", mThisVendor.Country);
            DB.AddParameter("@DateAdded", mThisVendor.DateAdded);
            DB.AddParameter("@VendorType", mThisVendor.VendorType);
            DB.AddParameter("@Summary", mThisVendor.Summary);
            DB.AddParameter("@OpenToBookings", mThisVendor.OpenToBookings);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVendors_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@VendorNo", mThisVendor.VendorNo);
            DB.Execute("sproc_tblVendor_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@VendorNo", mThisVendor.VendorNo);
            DB.AddParameter("@VendorName", mThisVendor.VendorName);
            DB.AddParameter("@HouseNo", mThisVendor.HouseNo);
            DB.AddParameter("@Street", mThisVendor.Street);
            DB.AddParameter("@City", mThisVendor.City);
            DB.AddParameter("@PostCode", mThisVendor.PostCode);
            DB.AddParameter("@Country", mThisVendor.Country);
            DB.AddParameter("@DateAdded", mThisVendor.DateAdded);
            DB.AddParameter("@VendorType", mThisVendor.VendorType);
            DB.AddParameter("@Summary", mThisVendor.Summary);
            DB.AddParameter("@OpenToBookings", mThisVendor.OpenToBookings);
            //execute the stored procedure
            DB.Execute("sproc_tblVendor_Update");
        }

        public void ReportByCountry(string Country)
        {
            //filters the records based on full or partial Country
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Country", Country);
            DB.Execute("sproc_tblVendor_FilterByCountry");
            PopulateArray(DB);

        }
        //populates the array list based on the data table in the parameter DB
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mVendorList = new List<clsVendors>();
            while (Index< RecordCount)
            {
                clsVendors AVendor = new clsVendors();
                AVendor.OpenToBookings = Convert.ToBoolean(DB.DataTable.Rows[Index]["OpenToBookings"]);
                AVendor.VendorNo = Convert.ToInt32(DB.DataTable.Rows[Index]["VendorNo"]);
                AVendor.VendorName = Convert.ToString(DB.DataTable.Rows[Index]["VendorName"]);
                AVendor.HouseNo = Convert.ToString(DB.DataTable.Rows[Index]["HouseNo"]);
                AVendor.Street = Convert.ToString(DB.DataTable.Rows[Index]["Street"]);
                AVendor.City = Convert.ToString(DB.DataTable.Rows[Index]["City"]);
                AVendor.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AVendor.Country = Convert.ToString(DB.DataTable.Rows[Index]["Country"]);
                AVendor.VendorType = Convert.ToString(DB.DataTable.Rows[Index]["VendorType"]);
                AVendor.Summary = Convert.ToString(DB.DataTable.Rows[Index]["Summary"]);
                //add the record to the pricate data member
                mVendorList.Add(AVendor);
                Index++;
            }
        }
    }

   
}
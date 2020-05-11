using EurotopiaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class NewVendor : System.Web.UI.Page
{
    Int32 VendorNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        VendorNo = Convert.ToInt32(Session["VendorNo"]);
        if (IsPostBack == false)
        {
            //if it is not a new record
            if (VendorNo != -1 )
            {
                DisplayVendor();
            }
        }
    }

    void DisplayVendor()
    {
        clsVendorCollection VendorBook = new clsVendorCollection();
        VendorBook.ThisVendor.Find(VendorNo);
        //display data for this record
        txtVendorNo.Text = VendorBook.ThisVendor.VendorNo.ToString();
        txtVendorName.Text = VendorBook.ThisVendor.VendorName;
        txtHouseNo.Text = VendorBook.ThisVendor.HouseNo;
        txtStreet.Text = VendorBook.ThisVendor.Street;
        txtCity.Text = VendorBook.ThisVendor.City;
        txtCountry.Text = VendorBook.ThisVendor.Country;
        txtPostcode.Text = VendorBook.ThisVendor.PostCode;
        txtVendorType.Text = VendorBook.ThisVendor.VendorType;
        txtSummary.Text = VendorBook.ThisVendor.Summary;
        txtDateAdded.Text = VendorBook.ThisVendor.DateAdded.ToString();
        chkOpenToBookings.Checked = VendorBook.ThisVendor.OpenToBookings;
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsVendors AVendor = new clsVendors();
        //variable to store the primary key
        Int32 VendorNo;
        //variable to store the result of the result operation
        Boolean Found = false;
        //get the primary key entered by the user
        VendorNo = Convert.ToInt32(txtVendorNo.Text);
        //find the record
        Found = AVendor.Find(VendorNo);
        //if found
        if (Found == true)
        {
            txtVendorName.Text = AVendor.VendorName;
            txtHouseNo.Text = AVendor.HouseNo;
            txtStreet.Text = AVendor.Street;
            txtCity.Text = AVendor.City;
            txtCountry.Text = AVendor.Country;
            txtPostcode.Text = AVendor.PostCode;
            txtVendorType.Text = AVendor.VendorType;
            txtSummary.Text = AVendor.Summary;
            txtDateAdded.Text = AVendor.DateAdded.ToString();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //create new instance of clsVendors
        clsVendors AVendor = new clsVendors();
        //captures information
        string VendorName = txtVendorName.Text;
        string HouseNo = txtHouseNo.Text;
        string Street = txtStreet.Text;
        string City = txtCity.Text;
        string PostCode = txtPostcode.Text;
        string Country = txtCountry.Text;
        string VendorType = txtVendorType.Text;
        string DateAdded = txtDateAdded.Text;
        string Summary = txtSummary.Text;
        bool OpenToBookings = chkOpenToBookings.Checked;
        //variable to store any error messages 
        string Error = "";
        //validate data
        Error = AVendor.Valid(HouseNo, Street, City, PostCode, Country, DateAdded, VendorName, VendorType, Summary);
        if (Error == "")
        {
            //capture the vendor no
            AVendor.VendorNo = VendorNo;
            //captures information
            AVendor.VendorName = VendorName;
            AVendor.HouseNo = HouseNo;
            AVendor.Street = Street;
            AVendor.City = City;
            AVendor.PostCode = PostCode;
            AVendor.Country = Country;
            AVendor.DateAdded = Convert.ToDateTime(DateAdded);
            AVendor.VendorType = VendorType;
            AVendor.Summary = Summary;
            AVendor.OpenToBookings = chkOpenToBookings.Checked;

            clsVendorCollection VendorList = new clsVendorCollection();
            //if it is a new record
            if(VendorNo == -1)
            {
                VendorList.ThisVendor = AVendor;
                VendorList.Add();
            }
            else //it is an update
            {
                VendorList.ThisVendor.Find(VendorNo);
                VendorList.ThisVendor = AVendor;
                VendorList.Update();
            }

            Response.Redirect("VendorList.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
    }

}
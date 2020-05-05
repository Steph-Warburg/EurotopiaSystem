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
    protected void Page_Load(object sender, EventArgs e)
    {

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
        string Country = txtCountry.Text;
        string VendorType = txtVendorType.Text;
        string PostCode = txtPostcode.Text;
        string DateAdded = txtDateAdded.Text;
        string Summary = txtSummary.Text;
        //variable to store any error messages 
        string Error = "";
        //validate data
        Error = AVendor.Valid(HouseNo, Street, City, PostCode, DateAdded, VendorName, VendorType, Summary);
        if (Error == "")
        {
            //captures information
            AVendor.HouseNo = HouseNo;
            AVendor.Street = Street;
            AVendor.City = City;
            AVendor.PostCode = PostCode;
            AVendor.Country = Country;
            AVendor.DateAdded = Convert.ToDateTime(DateAdded);
            AVendor.VendorName = VendorName;
            AVendor.VendorType = VendorType;
            AVendor.Summary = Summary;


            //store the address in the session object
            Session["AVendor"] = AVendor;
            //redirect to the viewer page
            Response.Write("VendorViewer.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }

    }

}
using EurotopiaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewVendor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsVendors AVendor = new clsVendors();
        AVendor.VendorName = txtVendorName.Text;
        Session["AVendor"] = AVendor;
        Response.Redirect("VendorViewer.aspx");
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
}
using EurotopiaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VendorList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed 
        if (IsPostBack == false)
        {
            //update list box
            DisplayVendors();
        }
        
    }
    void DisplayVendors()
    {
        //create instance of the County Collection
        EurotopiaClasses.clsVendorCollection Vendors = new EurotopiaClasses.clsVendorCollection();
        //set data source to the list of counties in the collection
        lstVendors.DataSource = Vendors.VendorList;
        //set name of primary key
        lstVendors.DataValueField = "VendorNo";
        //set data field to display
        lstVendors.DataTextField = "VendorName";
        lstVendors.DataBind();

    }


    //event handler for Add Button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["VendorNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("AVendor.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 VendorNo;
        //if a record has been selected from the list
        if (lstVendors.SelectedIndex != -1)
        {
            VendorNo = Convert.ToInt32(lstVendors.SelectedValue);
            Session["VendorNo"] = VendorNo;
            Response.Redirect("DeleteVendor.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 VendorNo;
        //if a record has been selected from the list
        if (lstVendors.SelectedIndex != -1)
        {
            VendorNo = Convert.ToInt32(lstVendors.SelectedValue);
            Session["VendorNo"] = VendorNo;
            Response.Redirect("AVendor.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsVendorCollection Vendors = new clsVendorCollection();
        Vendors.ReportByCountry(txtFilter.Text);
        lstVendors.DataSource = Vendors.VendorList;
        //set Name of primary key
        lstVendors.DataValueField = "VendorNo";
        //set Name of the field to display
        lstVendors.DataTextField = "Country";
        //bind data to the list
        lstVendors.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsVendorCollection Vendors = new clsVendorCollection();
        Vendors.ReportByCountry("");
        //clear any existing filter
        txtFilter.Text = "";
        lstVendors.DataSource = Vendors.VendorList;
        //set Name of primary key
        lstVendors.DataValueField = "VendorNo";
        //set Name of the field to display
        lstVendors.DataTextField = "Country";
        //bind data to the list
        lstVendors.DataBind();

    }
}
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
        AVendor.HouseNo = txtHouseNo.Text;
        Session["AVendor"] = AVendor;
        Response.Redirect("VendorViewer.aspx");
    }
}
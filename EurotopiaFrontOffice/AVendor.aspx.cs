using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EurotopiaClasses;

public partial class AVendor : System.Web.UI.Page
{
    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsVendors AVendor = new clsVendors();
        AVendor.HouseNo = txtHouseNo.Text;
        Session["AVendor"] = AVendor;
        Response.Redirect("VendorViewer.aspx");
    }
}
using EurotopiaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VendorViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsVendors AVendor = new clsVendors();
        AVendor = (clsVendors)Session["AVendors"];
        Response.Write(AVendor.HouseNo);
    }
}
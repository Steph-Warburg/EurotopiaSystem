using EurotopiaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteVendor : System.Web.UI.Page
{
    Int32 VendorNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        VendorNo = Convert.ToInt32(Session["VendorNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsVendorCollection VendorBook = new clsVendorCollection();
        VendorBook.ThisVendor.Find(VendorNo);
        VendorBook.Delete();
        Response.Redirect("VendorList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("VendorList.aspx");
    }
}
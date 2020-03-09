<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewVendor.aspx.cs" Inherits="NewVendor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <h1>Vendor details</h1>
            <p>Please fill in these details to add the vendor to the system. </p>
            <hr/>
        <div>
            <asp:Label ID="lblVendorName" runat="server" Text="Vendor Name"></asp:Label>
&nbsp;<asp:TextBox ID="txtVendorName" runat="server"></asp:TextBox>
            <br />
            <br />
            House Number<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Street<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; City<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Country<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Postcode<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            Vendor Type<asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Food</asp:ListItem>
                <asp:ListItem>Drinks</asp:ListItem>
                <asp:ListItem>Historical</asp:ListItem>
                <asp:ListItem>Cultural</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Vendor Summary<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AVendor.aspx.cs" Inherits="NewVendor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <h1>Vendor details</h1>
            <p>Please fill in these details to add to the vendor to the system. </p>
            <hr/>
        <div>
            <asp:Label ID="lblVendorNo" runat="server" Text="Vendor No"></asp:Label>&nbsp;
            <asp:TextBox ID="txtVendorNo" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find"  />
            <br />
            <hr/>
            <br />
            <asp:Label ID="lblVendorName" runat="server" Text="Vendor Name"></asp:Label>&nbsp;
            <asp:TextBox ID="txtVendorName" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblDateAdded" runat="server" Text="Date Added"></asp:Label>&nbsp;
            <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblHouseNo" runat="server" Text="House Number"></asp:Label>&nbsp;
            <asp:TextBox ID="txtHouseNo" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Label ID="lblStreet" runat="server" Text="Street"></asp:Label>&nbsp;
            <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>&nbsp;
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; 
            <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>&nbsp;
            <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Label ID="lblPostcode" runat="server" Text="Postcode"></asp:Label>&nbsp;
            <asp:TextBox ID="txtPostcode" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblVendorType" runat="server" Text="Vendor Type"></asp:Label>&nbsp;
            <asp:DropDownList ID="txtVendorType" runat="server">
                <asp:ListItem>Food</asp:ListItem>
                <asp:ListItem>Drinks</asp:ListItem>
                <asp:ListItem>Historical</asp:ListItem>
                <asp:ListItem>Cultural</asp:ListItem>
                <asp:ListItem>Nightlife</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblSummary" runat="server" Text="Vendor Summary"></asp:Label>&nbsp;
            <asp:TextBox ID="txtSummary" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:CheckBox ID="chkOpenToBookings" runat="server" Text="Open to bookings"/>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="Error"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </div>
    </form>
</body>
</html>

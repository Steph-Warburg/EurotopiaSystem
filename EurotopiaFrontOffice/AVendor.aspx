<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AVendor.aspx.cs" Inherits="AVendor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class = "container">
            <h1>Vendor details</h1>
            <p>Please fill in these details to add the vendor to the system. </p>
            <hr/>

            <label for="VendorName"><b>VendorName</b></label>
            <input type="text" placeholder="Enter name of vendor " name="VendorName" required/>
            <br />  <br />
            <label for="HouseNo"><b>House Number</b></label>
            <input type="text" placeholder="Enter house number" name="HouseNo" />

            <label for="Street"><b>Street</b></label>
            <input type="text" placeholder="Enter street" name="Street" required/>
            
            <label for="City"><b>City</b></label>
            <input type="text" placeholder="Enter city" name="City" required/>
            
            <label for="Country"><b>Country</b></label>
            <input type="text" placeholder="Enter country" name="Country" required/>

            <label for="Postcode"><b>Postcode</b></label>
            <input type="text" placeholder="Enter postcode" name="Postcode" required/>
            <br />  <br />
            <label for="VendorType"><b>VendorType</b></label>
            <select id =" VendorType" required>
                <option value ="Drinks">Drinks</option>
                <option value ="Food">Food</option>
                <option value ="Historical">Historical</option>
                <option value ="Cultural">Cultural</option>
            </select>

             <label for="VendorSummary"><b>Vendor Summary</b></label>
            <input type="text" placeholder="Enter a summary" name="VendorSummary" required/>
            <hr/>

            <p>By selecting submit you are adding the vendors details to the Eurotopia system</p>

            <button type="submit" class="submitbtn">Submit</button>
            
            <button type="reset" class="cancelbtn">Cancel</button>
        </div>
    </form>
</body>
</html>

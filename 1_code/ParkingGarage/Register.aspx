<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>AUTOmatedPARK</title>
</head>
<body>
<h1>
<img id="Img1" runat="server" src="~/Graphics/ParkingGarageLogo.GIF" alt="Parking Logo" />
</h1>
    <form id="form1" runat="server">
    <div class="logcontent">
        <asp:Label ID="LoginIDLabel" runat="server" Text="Enter your email ID:" ></asp:Label> 
        &nbsp;&nbsp;<asp:TextBox ID="UserIDTextBox" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="PasswordLabel" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="PasswordTextBox1" width="145" TextMode="Password" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="PasswordLabel2" runat="server" Text="Confirm Password:"></asp:Label>
        <asp:TextBox ID="PasswordTextBox2" width="145" TextMode="Password" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="LoginBtn" runat="server" Text="Register" />
        <br /><br />
        <a href= "Login.aspx"> Have an account already? Login!</a>
    </div>
    </form>
</body>
</html>
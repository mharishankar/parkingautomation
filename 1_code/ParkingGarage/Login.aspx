<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AUTOmatedPARK</title>
</head>
<body>
<h1>
<img id="Img1" runat="server" src="~/Graphics/ParkingGarageLogo.GIF" alt="Parking Logo" />
</h1>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LoginIDLabel" runat="server" Text=" Login ID:" ></asp:Label> 
        &nbsp;&nbsp;<asp:TextBox ID="UserIDTextBox" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="PasswordLabel" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="PasswordTextBox" width="145" TextMode="Password" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick = "login_Btn" />
        <br /><br />
        <a href> Don't have an account yet? Register now!</a>
    </div>
    </form>
</body>
</html>
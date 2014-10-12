<%@ Page Language="C#" MasterPageFile="~/ParkingGarage.master" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="ContactUs" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="UsaBackground">
<asp:Image ID="UsaImage" runat="server" ImageUrl="~/Graphics/usa.jpg" ImageAlign = "TextTop" />
</div>
<div id="info">
<asp:Image ID="info" runat="server" AlternateText="AutoMatedPark" ImageUrl="~/Graphics/info.gif" />
</div>
<br />
<br />
<font size = "3">
Contact Information
Email AutoMatedPark! <br/>
<asp:HyperLink ID="SankaranHyperLink" runat="server" NavigateUrl="mailto:Sankaran@Saharti.com" >support@automatedpark.com</asp:HyperLink><br />
</font>
</asp:Content>


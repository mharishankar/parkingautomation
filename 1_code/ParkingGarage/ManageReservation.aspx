<%@ Page Language="C#" MasterPageFile="~/ParkingGarage.master" AutoEventWireup="true" CodeFile="ManageReservation.aspx.cs" Inherits="ManageReservation" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
&nbsp <h2> Manage Reservation </h2> <br />
<font size = "2"> Please note that if you are cancelling/editing your reservation on short notice (within 30 minutes of the start time)<br />
then you will be charged the full fee for the reservation. <br /> <br />

Please select a reservation:  <br />
<asp:ListBox ID="RunningReservation" runat="server">
</asp:ListBox>
<br /> <br />
 <asp:RadioButton ID="Edit" runat="server" Text = "Edit" /> <br />
 <asp:RadioButton ID="Cancel" runat="server" Text = "Cancel" /><br /> </font>
<br /> <br /> <br /> <br /> <br /> <br /> <br /> <br /> <br /> <br />
</asp:Content>


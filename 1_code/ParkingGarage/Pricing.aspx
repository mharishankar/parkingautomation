<%@ Page Language="C#" MasterPageFile="~/ParkingGarage.master" AutoEventWireup="true" CodeFile="Pricing.aspx.cs" Inherits="Pricing" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<font size = "4">
Pricing scheme for this garage are as follows: <br /> 
<ul>
<li> Reservation : $5.00/hr </li>
<li> Overstaying a reservation: $10.00/hour </li>
<li> Monthly Contract: $250/month <br /></li>
<li> Walk-ins (without reservation): $7.00/hr</li> <br />
</ul>
</font>
<font size = "3">
Please note that walk-ins will be given a spot to park at only if there are any available unreserved spots<br />
in the garage at that time.
</font>
</asp:Content>


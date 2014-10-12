<%@ Control Language="C#" AutoEventWireup="true" CodeFile="onetimeReservation.ascx.cs" Inherits="onetimeContract" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
&nbsp *Note: You can schedule a reservation only for within the next 2 months. <br />
&nbsp &nbsp &nbsp &nbsp &nbsp &nbsp You can have no more than five pending reservations at a time. <br /> <br />
&nbsp<font size = "2">Enter Reservation Details: <br /> <br />
&nbsp Date: &nbsp &nbsp &nbsp &nbsp <asp:TextBox ID="DateReserve" runat="server"></asp:TextBox> <br />
<asp:CalendarExtender ID="CalendarExtender1" TargetControlID = "DateReserve" runat="server"> </asp:CalendarExtender>
&nbsp Start Time:<asp:TextBox ID="Start" runat="server"></asp:TextBox> <br />
&nbsp End Time:&nbsp<asp:TextBox ID="End" runat="server"></asp:TextBox><br />
 <br /> <br />
&nbsp <asp:Button ID = "Button1" runat ="server" Text = "Confirm" OnClick = "submit"/> </font>
<br /> <br />
<asp:Panel ID = "panel1" runat = "server" CssClass = "modalPopup">
<font size = "3">
 I have read the policies, terms and conditions. <br /> <br />
 </font>
&nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp 
<asp:Button ID = "close" runat = "server" Text = "Yes" OnClick = "yesclicked"/> 
</asp:Panel>

<asp:ModalPopupExtender ID="Modal1" runat="server" TargetControlID = "close" PopupControlID = "panel1" OnOkScript = "yesclicked()" OkControlID = "close">
</asp:ModalPopupExtender>

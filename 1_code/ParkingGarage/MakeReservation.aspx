<%@ Page Language="C#" MasterPageFile="~/ParkingGarage.master" AutoEventWireup="true" CodeFile="MakeReservation.aspx.cs" Inherits="MakeReservation" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register TagPrefix="ot" TagName ="onetime" Src="~/onetimeReservation.ascx" %>
<%@ Register TagPrefix="c" TagName="contract" Src="~/contract.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    &nbsp <h2> Make Reservation </h2> <br />
&nbsp<font size = "2"> *Reservation Type</font> <br />
 <asp:UpdatePanel runat = "server" ID = "updatePanel" UpdateMode = "Conditional">
 <Triggers>
    <asp:PostBackTrigger ControlID = "RadioButtonList1"/>
 </Triggers>
 <ContentTemplate>
 <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged = "chooseContract" AutoPostBack = "true">
 <asp:ListItem Value = "0"> One-time reservation </asp:ListItem>
 <asp:ListItem Value = "1"> Monthly Contract</asp:ListItem>
 </asp:RadioButtonList>
 <ot:onetime id="reserve1" runat="server" MinValue="1" MaxValue="10" Visible = "false" />
 <c:contract id="reserve2" runat="server" MinValue="1" MaxValue="10" Visible ="false" />
 </ContentTemplate>
 </asp:UpdatePanel>
 </asp:Content>
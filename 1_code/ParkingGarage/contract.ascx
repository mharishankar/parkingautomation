<%@ Control Language="C#" AutoEventWireup="true" CodeFile="contract.ascx.cs" Inherits="contract" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
 <font size = "2"> Month </font> <br />
<asp:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="Next" DynamicServicePath="" Enabled="True" BackgroundCssClass="modalBackground"
        PopupControlID="pnlModal" CancelControlID="btnClose" DropShadow="true">
</asp:ModalPopupExtender>
 <asp:XmlDataSource ID = "XMLMonthSource" runat = "server" DataFile = "~/App_Data/MonthSource.xml"></asp:XmlDataSource>
&nbsp <asp:ListBox ID="months" runat="server" DataSourceID = "XMLMonthSource" DataTextField = "Month"></asp:ListBox> <br />
 <br />
&nbsp <asp:Button ID = "Next" runat ="server" Text = "Confirm" OnClick = "clkd"/>
<asp:Panel ID = "panel2" runat = "server" CssClass = "modalPopup">
<font size = "3">
 I have read the policies, terms and conditions. <br /> <br />
 </font>
&nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp 
<asp:Button ID = "close2" runat = "server" Text = "Yes" OnClick = "yesclicked"/> 
</asp:Panel>
<asp:ModalPopupExtender ID="Modal2" runat="server" TargetControlID = "close2" PopupControlID = "panel2" OnOkScript = "yesclicked()" OkControlID = "close2">
</asp:ModalPopupExtender>
<br /><br /><br /><br />


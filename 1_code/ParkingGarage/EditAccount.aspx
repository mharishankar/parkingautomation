<%@ Page Language="C#" MasterPageFile="~/ParkingGarage.master" AutoEventWireup="true" CodeFile="EditAccount.aspx.cs" Inherits="EditAccount" Title="Untitled Page" %>
<%@ Register TagPrefix="bc" TagName ="billing" Src="~/BillingCascade.ascx" %>
<%@ Register TagPrefix="lc" TagName ="license" Src="~/LicenseCascade.ascx" %>
<%@ Register TagPrefix="pb" TagName ="pay" Src="~/paybill.ascx" %>
<%@ Register TagPrefix="cp" TagName ="changepass" Src="~/ChangePass.ascx" %>
<%@ Register TagPrefix="pu" TagName ="pastusage" Src="~/PastUsage.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script type="text/javascript">
        $(document).ready(function() {
            var pan = $(".cpBody").hide();
            var showNext = 0;
             $("#<%= btnShow.ClientID %>").click(function() {
                if (showNext < pan.length) {
                    $(pan[showNext++]).slideDown();
                }
            });
 
             $("#<%= btnHide.ClientID %>").click(function() {
                if (showNext > 0) {
                    $(pan[showNext - 1]).slideUp();
                    showNext--;
                }
            });
 
        });
   
    </script>
<div class="cpHeader">
    <font size = "3"> &nbsp Edit account details : </font>
    <asp:ImageButton ID="btnShow" ImageUrl="~/Graphics/show.png" runat="server" OnClientClick="return false" ImageAlign = "Right" Width = "20px" Height = "20px"/>
    <asp:ImageButton ID="btnHide" ImageUrl="~/Graphics/hide.png" runat="server" OnClientClick="return false" ImageAlign = "Left" Width = "20px" Height = "20px" />            
 </div>  

    <asp:Panel ID="Panel1" runat="server" class='cpBody'>
        <bc:billing id="billing" runat="server" MinValue="1" MaxValue="10" Visible = "true" />
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" class='cpBody'>
        <lc:license id="license1" runat="server" MinValue="1" MaxValue="10" Visible = "true" />
 </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" class='cpBody'>
       <pb:pay id="bill3" runat="server" MinValue="1" MaxValue="10" Visible = "true" />
    </asp:Panel>
     <asp:Panel ID="Panel4" runat="server" class='cpBody'>
       <cp:changepass id="pass" runat="server" MinValue="1" MaxValue="10" Visible = "true" />
  </asp:Panel>
   <asp:Panel ID="Panel5" runat="server" class='cpBody'>
        <pu:pastusage id="past" runat="server" MinValue="1" MaxValue="10" Visible = "true" />
   </asp:Panel>

<br />
<br />
<br />
<br /><br />
<br />
<br />
<br />
<br /><br />
<br />
<br />
<br />

</font>
</asp:Content>

<%@ Control Language="C#" AutoEventWireup="true" CodeFile="paybill.ascx.cs" Inherits="paybill" %>
<script type="text/javascript">
        $(document).ready(function() {
            var pan = $(".cpBody4").hide();
            var showNext = 0;
             $("#<%= show4.ClientID %>").click(function() {
                if (showNext < pan.length) {
                    $(pan[showNext++]).slideDown();
                }
            });
 
             $("#<%= hide4.ClientID %>").click(function() {
                if (showNext > 0) {
                    $(pan[showNext - 1]).slideUp();
                    showNext--;
                }
            });
 
        });
   
    </script> 

<asp:Label ID="Labelb" runat="server" Text="Label">Pay my bill</asp:Label>
<asp:ImageButton ID="show4" ImageUrl="~/Graphics/show.png" runat="server" OnClientClick="return false" ImageAlign = "Right" Width = "15px" Height = "15px"/>
<asp:ImageButton ID="hide4" ImageUrl="~/Graphics/hide.png" runat="server" OnClientClick="return false" ImageAlign = "Right" Width = "15px" Height = "15px" />            
<asp:Panel ID="Panel7" runat="server" class = "cpBody4">
<asp:Label ID="Labelc" runat="server" Text="Label">Amount due: $160.50</asp:Label>
<br />
<asp:Label ID="Labeld" runat="server" Text="Label">Due by: 5/3/2012</asp:Label>

      <asp:Button ID = "submitd" runat = "server" Text = "Pay now" />
</asp:Panel>
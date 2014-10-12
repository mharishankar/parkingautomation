<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BillingCascade.ascx.cs" Inherits="BillingCascade" %>
 <script type="text/javascript">
        $(document).ready(function() {
            var pan = $(".cpBody2").hide();
            var showNext = 0;
             $("#<%= show2.ClientID %>").click(function() {
                if (showNext < pan.length) {
                    $(pan[showNext++]).slideDown();
                }
            });
 
             $("#<%= hide2.ClientID %>").click(function() {
                if (showNext > 0) {
                    $(pan[showNext - 1]).slideUp();
                    showNext--;
                }
            });
 
        });
   
    </script> 

<asp:Label ID="Label1" runat="server" Text="Label">Change Billing Information</asp:Label>
<asp:ImageButton ID="show2" ImageUrl="~/Graphics/show.png" runat="server" OnClientClick="return false" ImageAlign = "Right" Width = "15px" Height = "15px"/>
<asp:ImageButton ID="hide2" ImageUrl="~/Graphics/hide.png" runat="server" OnClientClick="return false" ImageAlign = "Right" Width = "15px" Height = "15px" />            
<asp:Panel ID="Panel6" runat="server" class = "cpBody2">
<asp:Label ID="Label6" runat="server" Text="Label">Please edit your billing information as needed and click Confirm</asp:Label>
<br />
    <asp:Label ID="Label2" runat="server" Text="Label">Name</asp:Label> &nbsp &nbsp &nbsp 
    <asp:TextBox ID="TextBox1"
        runat="server" Text = "Madhumitha Harishankar" Width = "200px"></asp:TextBox>
      <br />
      <asp:Label ID="Label3" runat="server" Text="Address:"></asp:Label>
    <asp:TextBox ID="TextBox2"
        runat="server" Text = "Apt 9101, Meadow Road, Princeton 08540" Width = "250px"></asp:TextBox>
      <br />
      <asp:Label ID="Label4" runat="server" Text="Credit Card:"></asp:Label>&nbsp
    <asp:TextBox ID="TextBox3"
        runat="server" Text = "xxxx-xxxx-xxxx-5667" Width = "200px"></asp:TextBox>
      <br />
      <asp:Button ID = "submit" runat = "server" Text = "Update" />
</asp:Panel>
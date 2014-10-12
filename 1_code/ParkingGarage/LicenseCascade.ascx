<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LicenseCascade.ascx.cs" Inherits="LicenseCascade" %>
<script type="text/javascript">
        $(document).ready(function() {
            var pan = $(".cpBody3").hide();
            var showNext = 0;
             $("#<%= show3.ClientID %>").click(function() {
                if (showNext < pan.length) {
                    $(pan[showNext++]).slideDown();
                }
            });
 
             $("#<%= hide3.ClientID %>").click(function() {
                if (showNext > 0) {
                    $(pan[showNext - 1]).slideUp();
                    showNext--;
                }
            });
 
        });
   
    </script> 

<asp:Label ID="Label1" runat="server" Text="Label">Update License plate numbers:</asp:Label>
<asp:ImageButton ID="show3" ImageUrl="~/Graphics/show.png" runat="server" OnClientClick="return false" ImageAlign = "Right" Width = "15px" Height = "15px"/>
<asp:ImageButton ID="hide3" ImageUrl="~/Graphics/hide.png" runat="server" OnClientClick="return false" ImageAlign = "Right" Width = "15px" Height = "15px" />            
<asp:Panel ID="Panel7" runat="server" class = "cpBody3">
<asp:Label ID="Label7" runat="server" Text="Label">Existing license plate numbers:</asp:Label>
<br />
<ul>
<li> WBB86U</li> &nbsp &nbsp <a href = "Home.aspx">Remove</a>
<li> GHY778</li> &nbsp &nbsp <a href = "Home.aspx">Remove</a>
</ul>

<br />
Add license plate numbers: <br />
    <asp:TextBox ID = "tbt1" runat = "server" /> <br />
    <asp:TextBox ID = "TextBoxa" runat = "server" /><br />
    <asp:TextBox ID = "TextBoxb" runat = "server" /><br />
    
      <asp:Button ID = "submitc" runat = "server" Text = "Update" />
</asp:Panel>
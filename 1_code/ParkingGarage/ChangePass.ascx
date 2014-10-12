<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ChangePass.ascx.cs" Inherits="ChangePass" %>
<script type="text/javascript">
        $(document).ready(function() {
            var pan = $(".cpBody5").hide();
            var showNext = 0;
             $("#<%= show5.ClientID %>").click(function() {
                if (showNext < pan.length) {
                    $(pan[showNext++]).slideDown();
                }
            });
 
             $("#<%= hide5.ClientID %>").click(function() {
                if (showNext > 0) {
                    $(pan[showNext - 1]).slideUp();
                    showNext--;
                }
            });
 
        });
   
    </script> 

<asp:Label ID="Labelf" runat="server" Text="Label">Change email/password</asp:Label>
<asp:ImageButton ID="show5" ImageUrl="~/Graphics/show.png" runat="server" OnClientClick="return false" ImageAlign = "Right" Width = "15px" Height = "15px"/>
<asp:ImageButton ID="hide5" ImageUrl="~/Graphics/hide.png" runat="server" OnClientClick="return false" ImageAlign = "Right" Width = "15px" Height = "15px" />            
<asp:Panel ID="Panelf" runat="server" class = "cpBody5">
<asp:Label ID="Labelk" runat="server" Text="Email: madhumitha.harishankar@gmail.com"></asp:Label>
<br /> <br />
<asp:Label ID = "labelf1" runat = "server" Text = "New email ID: "></asp:Label>
<asp:TextBox ID = "tbf" runat = "server"></asp:TextBox> <br />
<asp:Label ID="Labelg" runat="server" Text="Label">Password: ******</asp:Label>

      <asp:Button ID = "Changepass" runat = "server" Text = "ChangePassword" />
</asp:Panel>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PastUsage.ascx.cs" Inherits="PastUsage" %>
<script type="text/javascript">
        $(document).ready(function() {
            var pan = $(".cpBody6").hide();
            var showNext = 0;
             $("#<%= show6.ClientID %>").click(function() {
                if (showNext < pan.length) {
                    $(pan[showNext++]).slideDown();
                }
            });
 
             $("#<%= hide6.ClientID %>").click(function() {
                if (showNext > 0) {
                    $(pan[showNext - 1]).slideUp();
                    showNext--;
                }
            });
 
        });
   
    </script> 

<asp:Label ID="Labelf" runat="server" Text="Label">View garage usage for last billing period: </asp:Label>
<asp:ImageButton ID="show6" ImageUrl="~/Graphics/show.png" runat="server" OnClientClick="return false" ImageAlign = "Right" Width = "15px" Height = "15px"/>
<asp:ImageButton ID="hide6" ImageUrl="~/Graphics/hide.png" runat="server" OnClientClick="return false" ImageAlign = "Right" Width = "15px" Height = "15px" />            
<asp:Panel ID="Panell" runat="server" class = "cpBody6">
    <asp:Table ID="Table1" runat="server" BorderWidth = "2px" CellPadding = "20">
    <asp:TableRow>
    <asp:TableHeaderCell> Date</asp:TableHeaderCell> 
    <asp:TableHeaderCell> Start-time</asp:TableHeaderCell>
    <asp:TableHeaderCell> End-time </asp:TableHeaderCell>
    </asp:TableRow>
    <asp:TableRow>
    <asp:TableCell> 4/12/2012 </asp:TableCell>
    <asp:TableCell> 04:03 PM </asp:TableCell>
    <asp:TableCell> 05:33 PM </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
    <asp:TableCell> 6/12/2012 </asp:TableCell>
    <asp:TableCell> 06:00 AM </asp:TableCell>
    <asp:TableCell> 07:43 PM </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
    <asp:TableCell> 7/12/2012 </asp:TableCell>
    <asp:TableCell> 01:13 PM </asp:TableCell>
    <asp:TableCell> 05:22 PM </asp:TableCell>
    </asp:TableRow>
        <asp:TableRow>
    <asp:TableCell> 7/12/2012 </asp:TableCell>
    <asp:TableCell> 10:17 PM </asp:TableCell>
    <asp:TableCell> 06:33 PM </asp:TableCell>
    </asp:TableRow>
        <asp:TableRow>
    <asp:TableCell> 8/12/2012 </asp:TableCell>
    <asp:TableCell> 09:10 PM </asp:TableCell>
    <asp:TableCell> 10:20 PM </asp:TableCell>
    </asp:TableRow>
        <asp:TableRow>
    <asp:TableCell> 13/12/2012 </asp:TableCell>
    <asp:TableCell> 10:11 PM </asp:TableCell>
    <asp:TableCell> 09:56 PM </asp:TableCell>
    </asp:TableRow>
        <asp:TableRow>
    <asp:TableCell> 21/12/2012 </asp:TableCell>
    <asp:TableCell> 04:03 PM </asp:TableCell>
    <asp:TableCell> 05:33 PM </asp:TableCell>
    </asp:TableRow>
        <asp:TableRow>
    <asp:TableCell> 22/12/2012 </asp:TableCell>
    <asp:TableCell> 06:03 PM </asp:TableCell>
    <asp:TableCell> 07:33 PM </asp:TableCell>
    </asp:TableRow>
    </asp:Table>


</asp:Panel>
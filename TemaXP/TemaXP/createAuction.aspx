<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createAuction.aspx.cs" Inherits="TemaXP.createAuction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Opret Auktion</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="stylesheet" type="text/css" href="css.css" />
</head>
<body>
    <div class="container" id="auction_main">
        <form id="form1" runat="server">
           
             <div id="left_div" class="pull-left">
                <h3>Opret Auktion</h3>
                 <asp:TextBox ID="artId" runat="server" placeholder="Kunst Id"></asp:TextBox>
                 <asp:Button ID="idCheck" runat="server" Text="Find Kunstværk" OnClick="idCheck_Click" />
                 <br />
                 <br />
                 <asp:TextBox ID="startingBid" runat="server" placeholder="Startpris"></asp:TextBox>
                 <br />
                 <br />
                 <asp:TextBox ID="startDate" runat="server" placeholder="Startdato dd/mm/yy"></asp:TextBox><br />
                 <asp:TextBox ID="endDate" runat="server" placeholder="Startdato dd/mm/yy"></asp:TextBox>
                 <br />
                 <br />
                 <asp:Button ID="saveInfo" runat="server" Text="Start Auktion" OnClick="saveInfo_Click"/>
            </div>
            
            <div id="right_div" class="pull-right">
            </div>
        </form>
    </div>
</body>
</html>
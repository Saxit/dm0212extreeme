<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createAuction.aspx.cs" Inherits="TemaXP.createAuction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
    <link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.0.1/css/bootstrap.min.css" />
    <link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.0.1/js/bootstrap.min.js" />
    <link rel="stylesheet" type="text/css" href="css.css" />

    <title>Opret Auktion</title>

</head>
<body>
    <div class="container" id="main_div">

        <ul class="nav nav-pills">
            <li><a href="index.aspx">Home</a></li>
            <li><a href="createArtwork.aspx">Opret kunstværk</a></li>
            <li class="active">
                <a href="createAuction.aspx">Sælg kunstværk på auktion</a>
            </li>
        </ul>

        <form runat="server">

            <h3>Opret Auktion</h3>

            <div class="input-group">
                <span class="input-group-addon inputBar">ID</span>
                <asp:TextBox runat="server" class="form-control" placeholder="Indsæt ID på kunstværk" ID="artId"/>
            </div><br />

            <asp:Button class="btn btn-primary" ID="idCheck" runat="server" Text="Find Kunstværk" OnClick="idCheck_Click" />
            <br />
            <br />

            <div class="input-group">
                <span class="input-group-addon inputBar">Kr.</span>
                <asp:TextBox runat="server" class="form-control" placeholder="Startbud på auktion" ID="startingBid" />
            </div>
            <br />

            <div class="input-group">
                <span class="input-group-addon inputBar">Startdato</span>
                <asp:TextBox runat="server" class="form-control" placeholder="dd/mm/yy" ID="startDate" />
            </div>
            <br />

            <div class="input-group">
                <span class="input-group-addon inputBar">Slutdato</span>
                <asp:TextBox runat="server" class="form-control" placeholder="dd/mm/yy" ID="endDate" />
            </div>
            <br />
            <asp:Button class="btn btn-primary pull-right" ID="saveInfo" runat="server" Text="Start Auktion" OnClick="saveInfo_Click" />
        </form>
    </div>
</body>
</html>

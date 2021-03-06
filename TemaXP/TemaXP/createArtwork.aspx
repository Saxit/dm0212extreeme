﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createArtwork.aspx.cs" Inherits="TemaXP.createArtwork" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <script type="text/javascript" src="http://code.jquery.com/jquery-latest.min.js"></script>
    <link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.0.1/css/bootstrap.min.css" />
    <link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.0.1/js/bootstrap.min.js" />
    <link rel="stylesheet" type="text/css" href="css.css" />

    <title>Opret kunstværk</title>
</head>
<body>
    <div class="container" id="main_div">

        <ul class="nav nav-pills">
            <li><a href="index.aspx">Home</a></li>
            <li class="active">
                <a href="createArtwork.aspx">Opret kunstværk</a>
            </li>
            <li><a href="createAuction.aspx">Sælg kunstværk på auktion</a></li>
        </ul>

        <form runat="server">
            <h3>Oprettelse af kunstværk</h3>
            <div class="input-group">
                <span class="input-group-addon">-</span>
                <asp:TextBox runat="server" class="form-control" placeholder="Navn på kunstværket" ID="nameOfArt" />
            </div>
            <br />

            <div class="input-group">
                <span class="input-group-addon">-</span>
                <asp:TextBox runat="server" class="form-control" placeholder="Navn på kunstner" ID="nameOfArtist" />
            </div>
            <br />

            <div class="input-group">
                <span class="input-group-addon">-</span>
                <asp:TextBox runat="server" class="form-control" placeholder="Årstal" ID="yearOfArt" />
            </div>
            <br />

            <div class="input-group">
                <span class="input-group-addon">-</span>
                <asp:TextBox runat="server" class="form-control" placeholder="Højde" ID="heightOfArt" />
            </div>
            <br />

            <div class="input-group">
                <span class="input-group-addon">-</span>
                <asp:TextBox runat="server" class="form-control" placeholder="Bredde" ID="widthOfArt" />
            </div>
            <br />

            <div class="input-group">
                <span class="input-group-addon">-</span>
                <asp:TextBox runat="server" class="form-control" placeholder="Galleriadresse" ID="locationOfArt" />
            </div>
            <br />

            <asp:FileUpload ID="uploadArtFile" runat="server" />
            <br />

            <asp:Button class="btn btn-primary pull-right" ID="saveInfo" runat="server" Text="Gem Information" OnClick="saveInfo_Click"></asp:Button>

        </form>
    </div>

</body>
</html>

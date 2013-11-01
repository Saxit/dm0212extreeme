﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createArtwork.aspx.cs" Inherits="TemaXP.createArtwork" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.0.1/css/bootstrap.min.css" />

    <title>Opret kunstværk</title>
</head>
<body>
    <div class="container">
        <form runat="server">
            <h1>Oprettelse af kunstværk</h1>
            <div class="input-group">
                <span class="input-group-addon">-</span>
                <asp:textbox runat="server" class="form-control" placeholder="Navn på kunstværket" ID="nameOfArt"/>
            </div><br />
        
            <div class="input-group">
                <span class="input-group-addon">-</span>
                <asp:textbox runat="server" class="form-control" placeholder="Navn på kunstner" ID="nameOfArtist"/>
            </div><br />

            <div class="input-group">
                <span class="input-group-addon">-</span>
                <asp:textbox runat="server" class="form-control" placeholder="Årstal" ID="yearOfArt"/>
            </div><br />

            <div class="input-group">
                <span class="input-group-addon">-</span>
                <asp:textbox runat="server" class="form-control" placeholder="Højde" ID="heightOfArt"/> 
            </div><br />

            <div class="input-group">
                <span class="input-group-addon">-</span>
                <asp:textbox runat="server" class="form-control" placeholder="Bredde" ID="widthOfArt"/>
            </div><br />
            
            <asp:FileUpload ID="uploadArtFile" runat="server" /> <br />

            <asp:Button class="btn btn-primary" ID="saveInfo" runat="server" Text="Gem Information" OnClick="saveInfo_Click"></asp:Button>

        </form>
    </div>

</body>
</html>

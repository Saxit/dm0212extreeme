<%@ Page Language="C#" AutoEventWireup="false" CodeBehind="index.aspx.cs" Inherits="TemaXP.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <script type="text/javascript" src="http://code.jquery.com/jquery-latest.min.js"></script>
    <link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.0.1/css/bootstrap.min.css" />
    <link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.0.1/js/bootstrap.min.js" />
    <link rel="stylesheet" type="text/css" href="css.css" />

    <title>Forside</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container" id="main_div">
            <ul class="nav nav-pills">
                <li class="active">
                    <a href="#">Home</a>
                </li>
                <li><a href="createArtwork.aspx">Opret kunstværk</a></li>
                <li><a href="createAuction.aspx">Sælg kunstværk på auktion</a></li>
            </ul>

            <div id="index_main">
                <h3>Velkommen til forsiden!</h3>
            </div>

        </div>
    </form>
</body>
</html>

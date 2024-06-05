<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MatchHistory.aspx.cs" Inherits="Jaarwerk_UI.MatchHistory" %>

<!DOCTYPE html> 

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Match history</title>
    <!-- Voeg Bootstrap CSS toe -->
<link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
<!-- Voeg Bootstrap en jQuery toe -->
<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.4/dist/umd/popper.min.js"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <style>
    body {
    background-image: url('achtergrond.jpg');
    background-size: cover;
    background-position: center;
    width: 100%;
    height: 110vh;
    position: relative;
    overflow: hidden;
}
    #tblContainer {
    margin: 50px auto;
    max-height: 300px;
    overflow-y: auto;
    position: relative;
}
            .testtest {
    margin: 50px auto;
    max-height: 300px;
    overflow-y: auto;
    position: relative;
    font-weight: bold;
    font-size: larger;
}


    #tblContainer table td {
    padding-left: 50px; /* Adjust the left padding to create more space */
    position: relative;
    z-index: 1;
    overflow: visible;
}
    .fixed-header {
    margin-top: 100px;
    position: sticky; /* Maakt de header vast */
    top: 0; /* Blijft bovenaan de tabelcontainer */
    z-index: 2; /* Zorgt ervoor dat de header boven andere inhoud wordt weergegeven */
    background-color: pink; /* Achtergrondkleur voor de vaste header */
}
     .fixed-header th {
     padding-left: 50px; /* Adjust the left padding to create more space */
     position: sticky;
     top: 0;
     background-color: #f2f2f2; /* Match the background color of the fixed header */
     z-index: 2;
 }
     .sticky-top {
    position: sticky;
    top: 0;
    z-index: 1020; /* Zorg ervoor dat de navbar bovenaan blijft */
}
.Ruimte {
    margin-top: 20px;
}

.row {
    margin-top: 20px; /* Voeg hier de gewenste bovenmarge toe */
}
.marked-row {
    background-color: #ffffcc; /* Kies een kleur naar wens */
}
        </style>
</head>
<body>
    <nav class="navbar navbar-expand-sm bg-dark navbar-dark">
    <div class="container-fluid">
        <a class="navbar-brand" href="#">
            <img src="../images/Logo-no-removebg-preview.png" style="width: 40px" />
        </a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#collapsibleNavbar">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="collapsibleNavbar">
            <ul class="navbar-nav">
                <li class="nav-item">
                    <a class="nav-link" href="Homepage.aspx">Home</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="default.aspx">Spelers</a>
                </li>
            </ul>
        </div>
    </div>
</nav>
    <form id="form1" runat="server">
                <div class="container ">
            <div class="row">
                <div class="col-md-6">
                    <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control" placeholder="Zoek Team..."></asp:TextBox>
                </div>
                <div class="col-md-2">
                    <asp:Button ID="btnSearch" runat="server" Text="Zoeken" CssClass="btn btn-primary" OnClick="btnSearch_Click"/>
                </div>
                                <div class="col-md-6 Ruimte">
    <asp:TextBox ID="txtSearchGame" runat="server" CssClass="form-control" placeholder="Zoek Games..."></asp:TextBox>
</div>
<div class="col-md-2 Ruimte">
    <asp:Button ID="btnsearch2" runat="server" Text="Zoeken" CssClass="btn btn-primary" OnClick="Button2_Click"  />
</div>
               
            </div>
        </div>
        <div id="tblContainer">
            <asp:Table ID="tblInfoMatches" runat="server" CssClass="table table-striped testtest"></asp:Table>
        </div>
    </form>
</body>
</html>

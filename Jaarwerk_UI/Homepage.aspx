<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Jaarwerk_UI.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Homepage</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
<style>


    .Tijdelijk
    {
        color: white;
        font-size: 50px;
         text-align: center;
         margin-top: 150px;
          margin-top: 100px; 
            position: relative; 
            z-index: 1;
    }
    .navbar {
        position: fixed; /* Fixed position so it stays at the top */
        top: 0; /* Position it at the top of the viewport */
        width: 100%; /* Take up the full width of the viewport */
        z-index: 100; /* Higher z-index to ensure it appears above the background */
        /* Add any other styling you need for your navbar */
    }
    
    body {
        background-image: url('achtergrond.jpg');
        background-size: cover;
        background-position: center top;
        width: 100%;
        height: 100vh;
        position: relative;
        overflow: hidden;
        padding-top: 60px;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
      
       <nav class="navbar navbar-expand-sm bg-dark navbar-dark">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">
      <img src="../images/Logo-no-removebg-preview.png" style="width: 40px"/>
        </a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#collapsibleNavbar">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="collapsibleNavbar">
      <ul class="navbar-nav">
        <li class="nav-item">
          <a class="nav-link" href="default.aspx">Spelers</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="MatchHistory.aspx">Match History</a>
        </li>
      </ul>
    </div>
  </div>
</nav>

<div class="container-fluid mt-12 Tijdelijk">
    <p>Eindwerk 6ITN</p>
    <h3>Sam Bruynseels</h3>
</div>
    </form>
</body>
</html>

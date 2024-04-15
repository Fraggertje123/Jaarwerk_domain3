<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Default.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

    <!-- Latest compiled and minified CSS -->
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">

<!-- Latest compiled JavaScript -->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>

<head runat="server">
   <title>Speler Overzicht</title>
    <style>
        .player-info {
            width: 80%;
            margin: 0 auto;
            overflow-y: scroll;
            height: 300px;
        }
        table {
            width: 100%;
            border-collapse: collapse;
        }
        th, td {
            border: 1px solid #ddd;
            padding: 8px;
            text-align: left;
        }
    </style>
</head>
<body>
   
    <form id="form1" runat="server">
         <asp:Table ID="tblInfoPlayers" runat="server" style="height:400px; overflow:auto"></asp:Table>

        <%--<div class="player-info" overflow="auto-enabled">
            <table>
                <tr>
                    <th>Naam</th>
                    <th>Geboortedatum</th>
                    <th>Nationaliteit</th>
                    <th>Geslacht</th>
                    <th>Team</th>
                </tr>--%>
                
          <%--      <% foreach (var player in Players) { %>
                    <tr>
                        <td><%= player.NaamSpeler %></td>
                        <td><%= player.GeboortedatumSpeler.ToString("dd-MM-yyyy") %></td>
                        <td><%= player.Nationaliteitspeler %></td>
                        <td><%= player.GeslachtSpeler %></td>
                        <td><%= player.Team.NaamTeam %></td>
                    </tr>
                <% } %>--%>
            </table>
        </div>
    </form>

    <div class="container mt-3">
  <h2>Dark Striped Table</h2>
  <p>Combine .table-dark and .table-striped to create a dark, striped table:</p>            
  <table class="table table-dark table-striped">
    <thead>
      <tr>
        <th>Firstname</th>
        <th>Lastname</th>
        <th>Email</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td>John</td>
        <td>Doe</td>
        <td>john@example.com</td>
      </tr>
      <tr>
        <td>Mary</td>
        <td>Moe</td>
        <td>mary@example.com</td>
      </tr>
      <tr>
        <td>July</td>
        <td>Dooley</td>
        <td>july@example.com</td>
      </tr>
    </tbody>
  </table>
</div>

</body>
</html>

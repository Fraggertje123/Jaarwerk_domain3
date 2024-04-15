using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Jaarwerk_domain4.Buisines;
using Jaarwerk_domain4.Buissines;

namespace Jaarwerk_UI
{
    public partial class MatchHistory : System.Web.UI.Page
    {
        private Controller _controller;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                _controller = (Controller)HttpContext.Current.Session["_controller"];
            }
            else
            {
                if (HttpContext.Current.Session["_controller"] == null)
                {
                    _controller = new Controller();
                    HttpContext.Current.Session["_controller"] = _controller;
                }
                else
                {
                    _controller = (Controller)HttpContext.Current.Session["_controller"];
                }
                AddHeaderRow();
                List<Game> games = _controller.GetMatchHistory();
                DisplayGames(games);
            }
        }

        private void AddHeaderRow()
        {
            TableHeaderRow headerRow = new TableHeaderRow();
            headerRow.CssClass = "fixed-header";

            // Voeg de kolomkoppen toe
            AddHeaderCell("Game", headerRow);
            AddHeaderCell("Datum", headerRow);
            AddHeaderCell("Winnaar", headerRow);
            AddHeaderCell("Score", headerRow);
            AddHeaderCell("Verliezer", headerRow);
            AddHeaderCell("Score", headerRow);
            AddHeaderCell("Tijdsduur", headerRow);

            // Voeg de headerrij toe aan de tabel
            tblInfoMatches.Rows.Add(headerRow);
        }

        private void AddHeaderCell(string text, TableRow headerRow)
        {
            TableHeaderCell headerCell = new TableHeaderCell();
            headerCell.Text = text;
            headerRow.Cells.Add(headerCell);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString1 = txtSearch.Text;
            SearchTeams(searchString1);
        }

        private void SearchTeams(string searchString1)
        {
            List<Game> games = _controller.GetMatchHistory();

            var filteredGames = games.Where(game =>
                _controller.GetTeamZonderId().Any(t => t.idteam == game.WinnerTeamId && t.naamTeam.Contains(searchString1)) ||
                _controller.GetTeamZonderId().Any(t => t.idteam == game.LoserTeamId && t.naamTeam.Contains(searchString1))
            ).ToList();

            tblInfoMatches.Rows.Clear(); // Wis alle bestaande rijen uit de tabel
            AddHeaderRow();
            DisplayGames(filteredGames);
        }

        

        protected void Button2_Click(object sender, EventArgs e)
        {

            string searchString2 = txtSearchGame.Text;
            SearchGames(searchString2);
        }
        private void SearchGames(string searchString2)
        {
            List<Game> games = _controller.ZoekEenGame(searchString2);

            tblInfoMatches.Rows.Clear(); // Wis alle bestaande rijen uit de tabel
            AddHeaderRow();
            DisplayGames(games);
        }

        private void DisplayGames(List<Game> games)
        {
            List<Team> teams = _controller.GetTeamZonderId();

            foreach (Game game in games)
            {
                TableRow row = new TableRow();
                row.CssClass = "#tblContainer";

                Team winningTeam = teams.FirstOrDefault(t => t.idteam == game.WinnerTeamId);
                Team losingTeam = teams.FirstOrDefault(t => t.idteam == game.LoserTeamId);

                // Voeg de eigenschappen van de speler toe aan de rij
                TableCell naamCell = new TableCell();
                naamCell.Text = game.GameName;
                row.Cells.Add(naamCell);

                TableCell datumCell = new TableCell();
                datumCell.Text = game.GameDate.ToShortDateString();
                row.Cells.Add(datumCell);

                string winningTeamName = (winningTeam != null) ? winningTeam.naamTeam : "Unknown";
                TableCell winningteamCell = new TableCell();
                winningteamCell.Text = winningTeamName;
                row.Cells.Add(winningteamCell);

                TableCell scorewinnerCell = new TableCell();
                scorewinnerCell.Text = game.ScoreWinner.ToString();
                row.Cells.Add(scorewinnerCell);

                string losingTeamName = (losingTeam != null) ? losingTeam.naamTeam : "Unknown";
                TableCell losingteamCell = new TableCell();
                losingteamCell.Text = losingTeamName;
                row.Cells.Add(losingteamCell);

                TableCell scoreloserCell = new TableCell();
                scoreloserCell.Text = game.ScoreLoser.ToString();
                row.Cells.Add(scoreloserCell);

                TableCell tijdCell = new TableCell();
                TimeSpan gameTimeSpan = TimeSpan.FromSeconds(game.GameTime);
                tijdCell.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", gameTimeSpan.Hours, gameTimeSpan.Minutes, gameTimeSpan.Seconds);
                row.Cells.Add(tijdCell);

                tblInfoMatches.Rows.Add(row);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Jaarwerk_domain4.Buisines;
using Jaarwerk_domain4.Buissines;

namespace Jaarwerk_UI
{
    public partial class _default : System.Web.UI.Page
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
                // Roep de methode GetSpelers aan om gegevens op te halen
                AddHeaderRow();
                List<Speler> spelers = _controller.GetAlleSpelers();
                List<Team> teams = _controller.GetTeamZonderId();




                // Loop door de lijst met spelers en voeg elke speler toe aan de tabel
                foreach (Speler speler in spelers)
                {
                    TableRow row = new TableRow();
                    row.CssClass = "#tblContainer";

                    // Voeg de eigenschappen van de speler toe aan de rij
                    TableCell naamCell = new TableCell();
                    naamCell.Text = speler.NaamSpeler;
                    row.Cells.Add(naamCell);

                    TableCell leeftijdCell = new TableCell();
                    leeftijdCell.Text = speler.geboortedatumspeler.ToShortDateString();
                    row.Cells.Add(leeftijdCell);

                    TableCell afkomstCell = new TableCell();
                    afkomstCell.Text = speler.nationaliteitspeler;
                    row.Cells.Add(afkomstCell);

                    TableCell geslachtCell = new TableCell();
                    geslachtCell.Text = speler.geslachtspeler;
                    row.Cells.Add(geslachtCell);

                    Team playerTeam = teams.FirstOrDefault(t => t.idteam == speler.FKTeam);

                    // If the player's team is found, add the team name to the table cell
                    // Otherwise, display "Unknown" or handle it according to your requirements
                    string teamName = (playerTeam != null) ? playerTeam.naamTeam : "Unknown";
                    TableCell teamCell = new TableCell();
                    teamCell.Text = teamName;
                    row.Cells.Add(teamCell);

                    string teamNameAfkorting = (playerTeam != null) ? playerTeam.afkortingNaamTeam : "Unknown";
                    TableCell teamAfkorting = new TableCell();
                    teamAfkorting.Text = teamNameAfkorting;
                    row.Cells.Add(teamAfkorting);

                    string wereldDeel = (playerTeam != null) ? playerTeam.werelddeelteam : "Unknown";
                    TableCell teamWereldDeel = new TableCell();
                    teamWereldDeel.Text = wereldDeel;
                    row.Cells.Add(teamWereldDeel);

                    // Voeg de rij toe aan de tabel
                    tblInfoPlayers.Rows.Add(row);
                }

            }

        }


        private void AddHeaderRow()
        {
            TableHeaderRow headerRow = new TableHeaderRow();
            headerRow.CssClass = "fixed-header";

            // Voeg de kolomkoppen toe
            AddHeaderCell("Naam", headerRow);
            AddHeaderCell("Geboortedatum", headerRow);
            AddHeaderCell("Afkomst", headerRow);
            AddHeaderCell("Geslacht", headerRow);
            AddHeaderCell("Team", headerRow);
            AddHeaderCell("Afkorting", headerRow);
            AddHeaderCell("WereldDeel", headerRow);

            // Voeg de headerrij toe aan de tabel
            tblInfoPlayers.Rows.Add(headerRow);
        }

        private void AddHeaderCell(string text, TableRow headerRow)
        {
            TableHeaderCell headerCell = new TableHeaderCell();
            headerCell.Text = text;
            headerRow.Cells.Add(headerCell);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtSearch.Text;
            SearchPlayers(searchString);

        }

        private void SearchPlayers(string searchString)
        {
            List<Speler> spelers = _controller.ZoekSpeler(searchString);
            List<Team> teams = _controller.GetTeamZonderId();

            tblInfoPlayers.Rows.Clear(); // Wis alle bestaande rijen uit de tabel
            AddHeaderRow();
            foreach (Speler speler in spelers)
            {
                TableRow row = new TableRow();

                // Voeg de eigenschappen van de speler toe aan de rij
                TableCell naamCell = new TableCell();
                naamCell.Text = speler.NaamSpeler;
                row.Cells.Add(naamCell);

                TableCell leeftijdCell = new TableCell();
                leeftijdCell.Text = speler.geboortedatumspeler.ToShortDateString();
                row.Cells.Add(leeftijdCell);

                TableCell afkomstCell = new TableCell();
                afkomstCell.Text = speler.nationaliteitspeler;
                row.Cells.Add(afkomstCell);

                TableCell geslachtCell = new TableCell();
                geslachtCell.Text = speler.geslachtspeler;
                row.Cells.Add(geslachtCell);

                Team playerTeam = teams.FirstOrDefault(t => t.idteam == speler.FKTeam);

                // If the player's team is found, add the team name to the table cell
                // Otherwise, display "Unknown" or handle it according to your requirements
                string teamName = (playerTeam != null) ? playerTeam.naamTeam : "Unknown";
                TableCell teamCell = new TableCell();
                teamCell.Text = teamName;
                row.Cells.Add(teamCell);

                string teamNameAfkorting = (playerTeam != null) ? playerTeam.afkortingNaamTeam : "Unknown";
                TableCell teamAfkorting = new TableCell();
                teamAfkorting.Text = teamNameAfkorting;
                row.Cells.Add(teamAfkorting);

                string wereldDeel = (playerTeam != null) ? playerTeam.werelddeelteam : "Unknown";
                TableCell teamWereldDeel = new TableCell();
                teamWereldDeel.Text = wereldDeel;
                row.Cells.Add(teamWereldDeel);

                // Voeg de rij toe aan de tabel
                tblInfoPlayers.Rows.Add(row);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string searchString1 = TextBox2.Text;
            SearchTeams(searchString1);
        }
        private void SearchTeams(string searchString1)
        {
            List<Team> teams = _controller.ZoekTeam(searchString1);
            List<Speler> spelers = _controller.GetAlleSpelers().Where(speler => teams.Any(t => t.idteam == speler.FKTeam)).ToList();
            tblInfoPlayers.Rows.Clear(); // Wis alle bestaande rijen uit de tabel
            AddHeaderRow();
            foreach (Speler speler in spelers)
            {
                TableRow row = new TableRow();

                // Voeg de eigenschappen van de speler toe aan de rij
                TableCell naamCell = new TableCell();
                naamCell.Text = speler.NaamSpeler;
                row.Cells.Add(naamCell);

                TableCell leeftijdCell = new TableCell();
                leeftijdCell.Text = speler.geboortedatumspeler.ToShortDateString();
                row.Cells.Add(leeftijdCell);

                TableCell afkomstCell = new TableCell();
                afkomstCell.Text = speler.nationaliteitspeler;
                row.Cells.Add(afkomstCell);

                TableCell geslachtCell = new TableCell();
                geslachtCell.Text = speler.geslachtspeler;
                row.Cells.Add(geslachtCell);

                Team playerTeam = teams.FirstOrDefault(t => t.idteam == speler.FKTeam);

                // If the player's team is found, add the team name to the table cell
                // Otherwise, display "Unknown" or handle it according to your requirements
                string teamName = (playerTeam != null) ? playerTeam.naamTeam : "Unknown";
                TableCell teamCell = new TableCell();
                teamCell.Text = teamName;
                row.Cells.Add(teamCell);

                string teamNameAfkorting = (playerTeam != null) ? playerTeam.afkortingNaamTeam : "Unknown";
                TableCell teamAfkorting = new TableCell();
                teamAfkorting.Text = teamNameAfkorting;
                row.Cells.Add(teamAfkorting);

                string wereldDeel = (playerTeam != null) ? playerTeam.werelddeelteam : "Unknown";
                TableCell teamWereldDeel = new TableCell();
                teamWereldDeel.Text = wereldDeel;
                row.Cells.Add(teamWereldDeel);

                // Voeg de rij toe aan de tabel
                tblInfoPlayers.Rows.Add(row);
            }
        }
    }
}
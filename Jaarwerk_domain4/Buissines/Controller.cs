using Jaarwerk_domain4.Buissines;
using Jaarwerk_domain4.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jaarwerk_domain4.Buissines;
using MySql.Data.MySqlClient;

namespace Jaarwerk_domain4.Buisines
{
    public class Controller
    {
        //velden
        private Persistence.Controller _PersistController;
        private string _connectionsString;

        public Controller()
        {
            _connectionsString = "server=localhost; user id=root; password=1234;database=eindproject_itn6";
            _PersistController = new Persistence.Controller(_connectionsString);

        }
        public List<Speler> ZoekSpeler(string searchString)
        {
            return _PersistController.GetSpeler(searchString);
        }
        public List<Team> ZoekTeam(string searchString1)
        {
            return _PersistController.ZoekTeam(searchString1);
        }
        public List<Game> ZoekEenGame(string searchString2)
        {
            return _PersistController.ZoekEenGame(searchString2);
        }
        public List<Speler> GetAlleSpelers()
        {
            return _PersistController.GetAlleSpelers();
        }
        public List<Game> GetMatchHistory() 
        {

            return _PersistController.GetMatchHistory();
        }

        public List<Team> GetTeamZonderId() 
        {
            return _PersistController.GetTeams();
        }

      
        //public List<Speler> GetPlayersWithTeams()
        //{
        //    List<Speler> players = ZoekSpeler(null); // Alle spelers ophalen

        //    foreach (var player in players)
        //    {
        //        player.FKTeam = TeamMapper.GetTeam(player.FKTeam); // Team van elke speler ophalen
        //    }
        //    return players;
        //}
    }
}


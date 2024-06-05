using Jaarwerk_domain4.Buissines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Jaarwerk_domain4.Persistence
{
    public class Controller
    {
        private string _connectionString;
        private SpelerMapper _spelerMapper;
        private TeamMapper _teamMapper;
        private GameMapper _gameMapper;


        public Controller(string connString)
        {
            _connectionString = connString;
            _spelerMapper = new SpelerMapper(connString);
            _teamMapper = new TeamMapper(connString);
            _gameMapper = new GameMapper(connString);
        }
        public List<Speler> GetSpeler(string searchString)
        {
            return _spelerMapper.GetSpeler(searchString);
        }

        public List<Team> ZoekTeam(string searchString1)
        {
            return _teamMapper.ZoekTeam(searchString1);
        }
        public List<Game> ZoekEenGame(string searchString2) 
        {
            return _gameMapper.ZoekEenGame(searchString2);
        }
        public List<Speler> GetAlleSpelers()
        {
            return _spelerMapper.GetAlleSpelers();
        }
        public List<Game> GetMatchHistory()
        {

            return _gameMapper.GetMatchHistory();
        }
        public List<Team> GetTeams()
        {
            return _teamMapper.GetTeamZonderId();
        }
       
    }
}

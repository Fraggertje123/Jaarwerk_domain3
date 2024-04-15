using Jaarwerk_domain4.Buissines;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Jaarwerk_domain4.Persistence
{
    public class TeamMapper
    {
        private string _connectionString;

        public TeamMapper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Team> GetTeam()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * from eindproject_itn6.team;", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Team> list = new List<Team>();


            while (reader.Read())
            {
                Team item = new Team(
                      Convert.ToInt32(reader["idteam"]),
                      Convert.ToString(reader["naamteam"]),
                      Convert.ToString(reader["afkortingteamnaam"]),
                      Convert.ToString(reader["werelddeel"])
                      );
                list.Add(item);
            }
            conn.Close();
            return list;
        }
    }
}

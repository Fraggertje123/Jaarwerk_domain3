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
    internal class TeamMapper
    {
        private string _connectionString;

        public TeamMapper(string connectionString)
        {
            _connectionString = connectionString;
        }
        public Team GetTeamMetId(int idteam)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * from eindproject_itn6.team where idteam=@id", conn);
            cmd.Parameters.AddWithValue("id", idteam);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            Team item = null;

            while (reader.Read())
            {
                item = new Team(
                      Convert.ToInt32(reader["idteam"]),
                      Convert.ToString(reader["naamteam"]),
                      Convert.ToString(reader["afkortingteamnaam"]),
                      Convert.ToString(reader["werelddeel"])
                      );
                
            }
            conn.Close();
            return item;
        }
        public List<Team> ZoekTeam(string searchString1)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM eindproject_itn6.team WHERE naamteam LIKE @searchString;", conn);
            cmd.Parameters.AddWithValue("@searchString", $"%{searchString1}%");
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Team> list = new List<Team>();

            // lees in 
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
        public List<Team> GetTeamZonderId()
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
        public Team GetTeam(int idteam)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * from eindproject_itn6.team", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            Team item = null;

            while (reader.Read())
            {
                item = new Team(
                      Convert.ToInt32(reader["idteam"]),
                      Convert.ToString(reader["naamteam"]),
                      Convert.ToString(reader["afkortingteamnaam"]),
                      Convert.ToString(reader["werelddeel"])
                      );

            }
            conn.Close();
            return item;
        }
    }
}

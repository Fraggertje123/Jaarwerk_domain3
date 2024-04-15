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
    public class GameMapper
    {
        private string _connectionString;

        public GameMapper(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<Game> GetSpeler()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * from eindproject_itn6.game;", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Game> list = new List<Game>();

            // lees in 
            while (reader.Read())
            {
                Game item = new Game(
                      Convert.ToInt32(reader["IdGame"]),
                      Convert.ToString(reader["GameName"]),
                      Convert.ToDateTime(reader["DateGame"]),
                      Convert.ToInt32(reader["WinnerTeamId"]),
                      Convert.ToInt32(reader["LoserTeamId"]),
                      Convert.ToInt32(reader["ScoreWinner"]),
                      Convert.ToInt32(reader["ScoreLoser"]),
                      Convert.ToInt32(reader["GameTime"])
                      );
                list.Add(item);
            }
            conn.Close();
            return list;
        }
    }
}

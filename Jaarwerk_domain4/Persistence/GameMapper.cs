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
    internal class GameMapper
    {
        private string _connectionString;

        public GameMapper(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<Game> GetMatchHistory()
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
                      Convert.ToInt64(reader["GameTime"])
                      );
                // Convert.ToDateTime(game.GameTime).ToString();
                list.Add(item);
            }
            conn.Close();
            return list;
        }
        public List<Game> ZoekEenGame(string searchString2)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM eindproject_itn6.Game WHERE GameName LIKE @searchString;", conn);
            cmd.Parameters.AddWithValue("@searchString", $"%{searchString2}%");
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
                      Convert.ToInt64(reader["GameTime"])
                      );
                list.Add(item);
            }
            conn.Close();
            return list;
        }
        public List<Game> ZoekSpelersInHistory(string searchString3)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM eindproject_itn6.speler WHERE naamspeler LIKE @searchString;", conn);
            cmd.Parameters.AddWithValue("@searchString", $"%{searchString3}%");
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
                      Convert.ToInt64(reader["GameTime"])
                      );
                list.Add(item);
            }
            conn.Close();
            return list;
        }
    }
}

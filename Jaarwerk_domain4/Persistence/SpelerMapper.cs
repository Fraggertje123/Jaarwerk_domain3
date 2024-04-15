using Jaarwerk_domain4.Buissines;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace Jaarwerk_domain4.Persistence
{
    internal class SpelerMapper
    {
        private string _connectionString;

        public SpelerMapper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Speler> GetAlleSpelers()
        {
            MySqlConnection conn = new MySqlConnection( _connectionString );
            MySqlCommand cmd = new MySqlCommand("Select * FROM eindproject_itn6.speler", conn);
            conn.Open();
           MySqlDataReader reader = cmd.ExecuteReader();
            List<Speler> list = new List<Speler>();

            //lees in 

            while(reader.Read())
            {
                Speler item = new Speler(
                     Convert.ToInt32(reader["idspeler"]),
                    Convert.ToString(reader["naamspeler"]),
                    Convert.ToDateTime(reader["geboortedatumspeler"]),
                    Convert.ToString(reader["nationaliteitspeler"]),
                    Convert.ToString(reader["geslachtspeler"]),
                    Convert.ToInt32(reader["Fkteam"])
                    );
                list.Add(item);
            }
            conn.Close();
            return list;
        }
        public List<Speler> GetSpeler(string searchString)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM eindproject_itn6.speler WHERE naamspeler LIKE @searchString;", conn);
            cmd.Parameters.AddWithValue("@searchString", $"%{searchString}%");
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Speler> list = new List<Speler>();

            // lees in 
            while (reader.Read())
            {
                Speler item = new Speler(
                    Convert.ToInt32(reader["idspeler"]),
                    Convert.ToString(reader["naamspeler"]),
                    Convert.ToDateTime(reader["geboortedatumspeler"]),
                    Convert.ToString(reader["nationaliteitspeler"]),
                    Convert.ToString(reader["geslachtspeler"]),
                    Convert.ToInt32(reader["Fkteam"])   
                );
                list.Add(item);
            }
            conn.Close();
            return list;
        }
    }
}

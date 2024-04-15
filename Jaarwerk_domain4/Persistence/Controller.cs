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


        public Controller(string connString)
        {
            _connectionString = connString;
            _spelerMapper = new SpelerMapper(connString);
        }
        public List<Speler> GetSpeler(string searchString)
        {
            return _spelerMapper.GetSpeler(searchString);
        }
    }
}

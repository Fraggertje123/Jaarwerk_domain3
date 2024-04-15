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

    }
}


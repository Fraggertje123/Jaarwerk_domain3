using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaarwerk_domain4.Buissines
{
    public class Team
    {
        //prop

        private int _idteam { get; set; }

        public int idteam
        {
            get { return _idteam; }
            set { _idteam = value; }
        }

        //propfull

        private string _naamteam;

        public string naamTeam
        {
            get { return _naamteam; }
            set { _naamteam = value; }
        }

        private string _afkortingNaamTeam;

        public string afkortingNaamTeam
        {
            get { return _afkortingNaamTeam; }
            set { _naamteam = value; }
        }

        private string _werelddeelteam;

        public string werelddeelteam
        {
            get { return _werelddeelteam; }
            set { _werelddeelteam = value; }
        }

        //constructors 

        public Team(int id, string naam, string afkortingnaam, string werelddeel)
        {
            _idteam = id;
            _naamteam = naam;
            _afkortingNaamTeam = afkortingnaam;
            _werelddeelteam = werelddeel;
        }
    }
}

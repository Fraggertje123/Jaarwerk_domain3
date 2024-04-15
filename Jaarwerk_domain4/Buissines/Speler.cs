using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaarwerk_domain4.Buissines
{
    public class Speler
    {
        //prop

        private int _idspeler { get; set; }

        public int IdSpeler
        {
            get { return _idspeler; }
            set { _idspeler = value; }
        }


        //propfull

        private string _naamspeler;

        public string NaamSpeler
        {
            get { return _naamspeler; }
            set { _naamspeler = value; }

        }

        private DateTime _geboortedatumspeler;

        public DateTime geboortedatumspeler
        {
            get { return _geboortedatumspeler; }
            set { _geboortedatumspeler = value; }

        }

        private string _nationaliteitspeler;

        public string nationaliteitspeler
        {
            get { return _nationaliteitspeler; }
            set { _nationaliteitspeler = value; }

        }

        private string _geslachtspeler;

        public string geslachtspeler
        {
            get { return _geslachtspeler; }
            set { _geslachtspeler = value; }

        }

        //constructors

        public Speler(int id, string naam, DateTime geboortedatum, string nationaliteit,
        string geslacht)
        {
            _idspeler = id;
            _naamspeler = naam;
            _geboortedatumspeler = geboortedatum;
            _nationaliteitspeler = nationaliteit;
            _geslachtspeler = geslacht;
        }

        //methodes
        public override string ToString()
        {
            return _naamspeler;
        }
    }
}   
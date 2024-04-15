using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaarwerk_domain4.Buissines
{
    public class Game
    {
        //prop
        private int _IdGame { get; set; }

        public int IdGame
        {
            get { return _IdGame; }
            set { _IdGame = value; }
        }

        //propfull

        private string _GameName;

        public string GameName
        {
            get { return _GameName; }
            set { _GameName = value; }
        }


        private DateTime _GameDate;

        public DateTime GameDate
        {
            get { return _GameDate; }
            set { _GameDate = value; }
        }

        private int _winnerTeamId;

        public int WinnerTeamId
        {
            get { return _winnerTeamId; }
            set { _winnerTeamId = value; }
        }

        private int _LoserTeamId;

        public int LoserTeamId
        {
            get { return _LoserTeamId; }
            set { _LoserTeamId = value; }
        }

        private int _ScoreWinner;

        public int ScoreWinner
        {
            get { return _ScoreWinner; }
            set { _ScoreWinner = value; }
        }

        private int _ScoreLoser;

        public int ScoreLoser
        {
            get { return _ScoreLoser; }
            set { _ScoreLoser = value; }
        }

        private long _GameTime;

        public long GameTime
        {
            get { return _GameTime; }
            set { _GameTime = value; }
        }


        //constructors 

        public Game(int id, string naam, DateTime datum, int winnaar, int verliezer, int scorewinnaar, int scoreverliezer, long Tijd)
        {
            _IdGame = id;
            _GameName = naam;
            _GameDate = datum;
            _winnerTeamId = winnaar;
            _LoserTeamId=verliezer;
            _ScoreWinner = scorewinnaar;
            _ScoreLoser = scoreverliezer;
            _GameTime = Tijd;
        }

        //methodes
        public override string ToString()
        {
            return _GameName;
        }
    }
}
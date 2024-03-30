using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefententamen_opgave
{
    abstract class FootballMatch
    {
        public FootballTeam HomeTeam { get; set; }

        public FootballTeam AwayTeam { get; set; }
        protected FootballMatch(FootballTeam homeTeam, FootballTeam awayTeam)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
        }
    }
}

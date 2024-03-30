using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefententamen_opgave
{
    class CompetitionMatch : FootballMatch
    {
        private int roundNumber;

        public CompetitionMatch(FootballTeam homeTeam, FootballTeam awayTeam, int roundNumber) : base(homeTeam, awayTeam)
        {
            this.roundNumber = roundNumber;
        }
    }
}

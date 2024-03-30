using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefententamen_opgave
{
    abstract class ChampionshipMatch : FootballMatch
    {
        protected ChampionshipMatch(FootballTeam homeTeam, FootballTeam awayTeam) : base(homeTeam, awayTeam)
        {
        }
    }
}

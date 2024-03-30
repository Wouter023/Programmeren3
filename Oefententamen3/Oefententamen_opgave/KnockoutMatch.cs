using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefententamen_opgave
{
    class KnockoutMatch : ChampionshipMatch
    {
        KnockoutType knockoutType;

        public KnockoutMatch(FootballTeam homeTeam, FootballTeam awayTeam, KnockoutType knockoutType) : base(homeTeam, awayTeam)
        {
            this.knockoutType = knockoutType;
        }
    }
}

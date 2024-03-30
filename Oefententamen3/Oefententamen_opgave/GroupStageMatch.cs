using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefententamen_opgave
{
    class GroupStageMatch : ChampionshipMatch
    {
        string groupName;

        public GroupStageMatch(FootballTeam homeTeam, FootballTeam awayTeam, string groupName) : base(homeTeam, awayTeam)
        {
            this.groupName = groupName;
        }
    }
}

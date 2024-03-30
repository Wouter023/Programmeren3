using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefententamen_opgave
{
    class FootballMatchResult
    {
        public int HomeTeamGoals { get; }
        public int AwayTeamGoals { get; }

        public int HomeTeamPoints { 
            get
            {
                return CalculatePoints(HomeTeamGoals, AwayTeamGoals);
            } 
        }
        public int AwayTeamPoints
        {
            get
            {
                return CalculatePoints(AwayTeamGoals, AwayTeamGoals);
            }
        }

        private int CalculatePoints(int goalsScored, int goalsConceded)
        {
            if (goalsScored > goalsConceded)
            {
                return 3;
            }
            else if (goalsScored < goalsConceded)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public override string ToString()
        {
            string output = $"footbal match result: {HomeTeamGoals} - {AwayTeamGoals}" +
                $"";
            return output;
        }
    }
}

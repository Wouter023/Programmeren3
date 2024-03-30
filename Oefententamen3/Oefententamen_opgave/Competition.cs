using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefententamen_opgave
{
    class Competition
    {
        private List<FootballMatch> matches;
        private List<FootballTeam> teams;
        private Dictionary<FootballMatch, FootballMatchResult> results;

        public Competition()
        {
            matches = new List<FootballMatch>();
            teams = new List<FootballTeam>();
        }

        private void GenerateMatches()
        {
            foreach(FootballTeam hometeam in teams)
            {
                foreach(FootballTeam awayteam in teams)
                {
                    if (hometeam != awayteam)
                    {
                        matches.Add(new CompetitionMatch(hometeam, awayteam, 1));
                    }
                }
            }
        }

        private void AddPointsToTeam()
        {
            foreach (KeyValuePair<FootballMatch, FootballMatchResult> result in results)
            {
                int homeTeamPoints = result.Value.HomeTeamPoints;
                int awayTeamPoints = result.Value.AwayTeamPoints;
                FootballTeam homeTeam = result.Key.HomeTeam;
                FootballTeam awayTeam = result.Key.AwayTeam;
                homeTeam.TotalPoints += homeTeamPoints;
                awayTeam.TotalPoints += awayTeamPoints;
            }
        }

        public void AddTeamToCompetition(FootballTeam team)
        {
            teams.Add(team);
        }
    }
}

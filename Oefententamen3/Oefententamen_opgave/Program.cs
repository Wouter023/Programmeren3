namespace Oefententamen_opgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Opgave2();
        }

        void Opgave1()
        {
            FootballPlayer footballPlayer = new FootballPlayer("Peter de Groot", 25);
            Console.WriteLine(footballPlayer);
        }

        void Opgave2()
        {
            List<FootballPlayer> footballPlayers = new List<FootballPlayer>();
            InternationalFootballPlayer internationalFootballPlayer = new InternationalFootballPlayer("Donny van de Beek", 23, 9);
            footballPlayers.Add(internationalFootballPlayer);
            footballPlayers.Add(new FootballPlayer("Peter de Groot", 25));
            foreach (FootballPlayer footballPlayer in footballPlayers)
            {
                Console.WriteLine(footballPlayer);
            }
        }

        void Opgave3()
        {
            FootballTeam team = new FootballTeam("trst");
            InternationalFootballPlayer internationalFootballPlayer = new InternationalFootballPlayer("Donny van de Beek", 23, 9);
            //team.Add(internationalFootballPlayer);
            //team.Add(new FootballPlayer("Peter de Groot", 25));
        }

        void Opgave6()
        {
            Competition competition = new Competition();
            competition.AddTeamToCompetition(new FootballTeam("Ajax"));
            competition.AddTeamToCompetition(new FootballTeam("Kakkerlak FC"));
            competition.AddTeamToCompetition(new FootballTeam("PSV"));
            competition
        }
    }
}
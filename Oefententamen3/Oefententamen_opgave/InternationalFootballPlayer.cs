using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefententamen_opgave
{
    class InternationalFootballPlayer : FootballPlayer
    {
        int gamesPlayed;

        public InternationalFootballPlayer(string name, int age, int gamesPlayed) : base(name, age)
        {
            this.gamesPlayed = gamesPlayed;
        }

        public override int CalculateTransferValue()
        {
            return base.CalculateTransferValue() + (int)(0.5 * this.gamesPlayed);
        }

        public override string ToString()
        {
            return base.ToString() + $" ({this.gamesPlayed} int. games)";
        }
    }
}

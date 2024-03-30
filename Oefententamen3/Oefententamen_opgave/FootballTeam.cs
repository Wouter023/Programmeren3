using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefententamen_opgave
{
    class FootballTeam
    {
        private string name;
        public List<FootballPlayer> Players { get; }

        public string Name { get { return name; } }
        
        public int TotalPoints { get; set; }

        public int TotalTransfer { 
            get
            {
                int totalTransferValue = 0;
                foreach(FootballPlayer player in Players)
                {
                    totalTransferValue += player.CalculateTransferValue();
                }
                return totalTransferValue;
            } 
        }

        public FootballTeam(string name)
        {
            this.name = name;
            this.Players = new List<FootballPlayer>();
            this.TotalPoints = 0;
        }

        public override string ToString()
        {
            string output = $"{this.name}\n";
            foreach(FootballPlayer player in Players)
            {
                output += $"{player}\n";
            }
            return output;
        }
    }
}

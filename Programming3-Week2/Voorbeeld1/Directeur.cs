using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbeeld1
{
    class Directeur : Werknemer
    {
        const string Title = "The boss: ";
        public Directeur(string voornaam, string achternaam, float salaris) : base(voornaam, achternaam, salaris)
        {
        }

        public override void VerhoogSalaris(int verhoging)
        {
            base.VerhoogSalaris(verhoging);
            salaris += verhoging;      
        }

        public override string ToString()
        {
            return Title + base.ToString();
        }
    }
}

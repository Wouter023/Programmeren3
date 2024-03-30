using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbeeld1
{
    class Werknemer : Persoon
    {
        public string afdeling;
        public float salaris;
        public int personeelsNummer;

        public Werknemer(string voornaam, string achternaam, float salaris) : base(voornaam, achternaam)
        {
            this.salaris = salaris;
        }



        public virtual void VerhoogSalaris(int verhoging)
        {
            salaris += verhoging;
        }

        public override void CallMe()
        {
            Console.WriteLine($"tre");
        }

        public override string ToString()
        {
            return $"{this.voornaam}";
        }
    }
}

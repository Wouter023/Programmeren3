using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbeeld1
{
    abstract class Persoon
    {
        public string voornaam, achternaam;
        public DateTime geboorteDatum;

        public Persoon(string voornaam, string achternaam)
        {
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.geboorteDatum = geboorteDatum;
        }

        public virtual void CallMe()
        {

        }
    }
}

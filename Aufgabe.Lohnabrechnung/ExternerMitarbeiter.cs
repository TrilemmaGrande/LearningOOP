using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Lohnabrechnung
{
    class ExternerMitarbeiter : Mitarbeiter
    {
        private int projektstunden;
        private const int stundenlohn = 75;

        public ExternerMitarbeiter(string vorname, string name, int projektstunden)
        {
            this.vorname = vorname;
            this.name = name;
            this.projektstunden = projektstunden;
            angestelltAls = "Externer Mitarbeiter";
            CalculateGehalt();
        }

        public void CalculateGehalt()
        {
            gehalt = projektstunden * stundenlohn;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Lohnabrechnung
{
    enum Abteilung
    {
        Vertrieb,
        Produktion,
        Entwicklung
    }
    class Praktikant : Mitarbeiter
    {
        private Abteilung abteilung;
        private const int vertrieb = 820;
        private const int produktion = 710;
        private const int entwicklung = 935;

        public Praktikant(string vorname, string name, Abteilung abteilung) : base(vorname,name)
        {
            this.vorname = vorname;
            this.name = name;
            this.abteilung = abteilung;
            angestelltAls = "Praktikant";
            CalculateGehalt();
        }
        public void CalculateGehalt()
        {
            switch (abteilung)
            {
                case Abteilung.Vertrieb:
                    gehalt = vertrieb;
                    break;
                case Abteilung.Produktion:
                    gehalt = produktion;
                    break;
                case Abteilung.Entwicklung:
                    gehalt = entwicklung;
                    break;
            }
        }
    }
}

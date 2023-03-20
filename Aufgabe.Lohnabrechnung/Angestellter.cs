using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Lohnabrechnung
{
    enum Tarifgruppe
    {
       A,
       B,
       C,
       D
    }
    class Angestellter : Mitarbeiter
    {
        private int alter;        
        private int tarif;
        private Tarifgruppe tarifgruppe;
        private const int tarifA = 2560;
        private const int tarifB = 3000;
        private const int tarifC = 3200;
        private const int tarifD = 5400;

        public Angestellter(string vorname, string name,int alter,Tarifgruppe tarifgruppe) : base(vorname,name)
        {
            this.alter = alter;
            this.tarifgruppe = tarifgruppe;
            this.vorname = vorname;
            this.name = name;
            angestelltAls = "Angestellter";
            CalculateGehalt();
        }
        public void CalculateGehalt()
        {
            switch (tarifgruppe)
            {
                case Tarifgruppe.A:
                    tarif = tarifA;
                    break;
                case Tarifgruppe.B:
                    tarif = tarifB;
                    break;
                case Tarifgruppe.C:
                    tarif = tarifC;
                    break;
                case Tarifgruppe.D:
                    tarif = tarifD;
                    break;
            }
            gehalt = tarif * (1 + ((alter - (double)25) / 100));
        }
    }
}

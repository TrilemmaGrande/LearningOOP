using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Fahrtenbuch
{
    internal class Fahrtenbuch
    {
        protected List<Fahrt> fahrten = new List<Fahrt>();
        protected Fahrer fahrer;

        public Fahrtenbuch(Fahrt fahrt, Fahrer fahrer)
        {
            fahrten.Add(fahrt);
            this.fahrer = fahrer;
        }
        public double PrintGesamtumsatz()
        {
            double gesamtUmsatz = 0.00;
            foreach (Fahrt fahrt in fahrten)
            {
                gesamtUmsatz += fahrt.GetFahrtkosten();
            }
            return gesamtUmsatz;
        }
        public double PrintTagesumsatz(DateOnly date)
        {
            double tagesUmsatz = 0.00;
            foreach(Fahrt fahrt in fahrten)
            {
                if (fahrt.GetDate() == date)
                {
                    tagesUmsatz += fahrt.GetFahrtkosten();
                }
            }
            return tagesUmsatz;
        }
        public double PrintFahrerumsatz(Fahrer fahrer)
        {
            double fahrerUmsatz = 0.00;
            foreach (Fahrt fahrt in fahrten)
            {
                if (this.fahrer == fahrer)
                {
                    fahrerUmsatz += fahrt.GetFahrtkosten();
                }
            }
            return fahrerUmsatz;
        }
    }
}

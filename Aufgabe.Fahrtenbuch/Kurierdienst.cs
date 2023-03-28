using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Fahrtenbuch
{
    internal class Kurierdienst
    {
        List<Fahrtenbuch> fahrtenbuecher = new List<Fahrtenbuch>();
        public Kurierdienst (Fahrtenbuch fahrtenbuch)
        {
            fahrtenbuecher.Add(fahrtenbuch);
        }
        public double BerechneGesamtumsatz()
        {
            double gesamtUmsatz = 0.00;
            foreach (Fahrtenbuch fahrtenbuch in fahrtenbuecher)
            {
                gesamtUmsatz += fahrtenbuch.PrintGesamtumsatz();
            }
            return gesamtUmsatz;
        }
        public double BerechneTagesumsatz(DateOnly date)
        {
            return 2.2;
        }
        public double BerechneFahrerumsatz(Fahrer fahrer)
        {
            return 2.2;
        }

    }
}

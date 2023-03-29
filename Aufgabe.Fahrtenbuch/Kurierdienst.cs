namespace Aufgabe.Fahrtenbuch
{
    internal class Kurierdienst
    {
        List<Fahrtenbuch> fahrtenbuecher = new List<Fahrtenbuch>();
        
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
            double tagesUmsatz = 0.00;
            foreach (Fahrtenbuch fahrtenbuch in fahrtenbuecher)
            {
                tagesUmsatz += fahrtenbuch.PrintTagesumsatz(date);
            }
            return tagesUmsatz;
        }
        public double BerechneFahrerumsatz(Fahrer fahrer)
        {
            double fahrerUmsatz = 0.00;
            foreach (Fahrtenbuch fahrtenbuch in fahrtenbuecher)
            {
                fahrerUmsatz += fahrtenbuch.PrintFahrerumsatz(fahrer);
            }
            return fahrerUmsatz;
        }        
        public void AddFahrtenbuch(Fahrtenbuch fahrtenbuch)
        {
            fahrtenbuecher.Add(fahrtenbuch);
        }

    }
}

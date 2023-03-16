namespace Beispiel.Vererbung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KFZ k1 = new KFZ();
            k1.RestwertBerechnen();
            k1.Auszahlen();

            Immobilie i1 = new Immobilie();
            i1.RestwertBerechnen();
            i1.Auszahlen();

            Versicherungsobjekt vo1 = new Versicherungsobjekt();
            vo1.Auszahlen();
        }
        class Versicherungsobjekt
        {
            protected double neupreis;
            protected int baujahr;
            protected double schadenshoehe;

            public void Auszahlen()
            {
                Console.WriteLine("Auzahlung") ;
            }           
        }
        class KFZ : Versicherungsobjekt
        {
            private string hersteller;
            private string typschluessel;
            private int laufleistung;

            public void RestwertBerechnen()
            {
                Console.WriteLine("Restwert von KFZ");
            }
            public void AusgabeAttribute()
            {
                Console.WriteLine(this.);
            }
        }
        class Immobilie : Versicherungsobjekt
        {
            private double wohnflaeche;
            private double lagebewertung;

            public void RestwertBerechnen()
            {
                Console.WriteLine(  "Restwert von Immobilie");

            }
            public double GetLagebewertung()
            {
                return lagebewertung;
            }
        }
    }
}
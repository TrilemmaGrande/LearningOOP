namespace Aufgabe.Lohnabrechnung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angestellter angestellter = new Angestellter( "heinz", "müller", 60, Tarifgruppe.A);
            ExternerMitarbeiter externerMitarbeiter = new ExternerMitarbeiter("keine", "Ahnung", 60);
            Praktikant praktikant = new Praktikant("hans", "peter", Abteilung.Vertrieb);

            angestellter.PrintInfo();
            externerMitarbeiter.PrintInfo();
            praktikant.PrintInfo();
        }
    }
}
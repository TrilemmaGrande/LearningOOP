namespace Aufgabe.Fahrtenbuch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurierdienst k1 = new Kurierdienst();
            Fahrtenbuch faBu1 = new Fahrtenbuch(new Fahrer("juergen", "müller"));
            Fahrtenbuch faBu2 = new Fahrtenbuch(new Fahrer("peter", "olikowski"));
            Fahrt f1 = new Fahrt(20,new PKW(),new ExpressZustellung(),new DateOnly(2023,03,10));
            Fahrt f2 = new Fahrt(30,new Motorroller(),new StandardZustellung(),new DateOnly(2023, 03, 11));
            
            faBu1.AddFahrt(f1);
            faBu1.AddFahrt(f2);
            k1.AddFahrtenbuch(faBu1);
            k1.AddFahrtenbuch(faBu2);
        }
    }
}
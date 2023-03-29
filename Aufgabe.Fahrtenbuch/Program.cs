namespace Aufgabe.Fahrtenbuch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurierdienst k1 = new Kurierdienst();
            Fahrer fahrer1 = new Fahrer("juergen", "müller");
            Fahrer fahrer2 = new Fahrer("peter", "olikowski");
            Fahrtenbuch faBu1 = new Fahrtenbuch(fahrer1);
            Fahrtenbuch faBu2 = new Fahrtenbuch(fahrer2);
            Fahrt f1 = new Fahrt(20,new PKW(),new ExpressZustellung(),new DateOnly(2023,03,10));
            Fahrt f2 = new Fahrt(30,new Motorroller(),new StandardZustellung(),new DateOnly(2023,03,11));
            
            faBu1.AddFahrt(f1);
            faBu1.AddFahrt(f2);
            k1.AddFahrtenbuch(faBu1);
            k1.AddFahrtenbuch(faBu2);

            Console.WriteLine($"{k1.BerechneFahrerumsatz(fahrer1)}");
            Console.WriteLine($"{k1.BerechneGesamtumsatz()}");
            Console.WriteLine($"{k1.BerechneTagesumsatz(new DateOnly(2023,03,10))}");
        }
    }
}
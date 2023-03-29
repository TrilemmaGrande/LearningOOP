namespace Aufgabe.Fahrtenbuch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurierdienst kurierdienst1 = new Kurierdienst();
            Fahrer fahrer1 = new Fahrer("Jürgen", "Müller");
            Fahrer fahrer2 = new Fahrer("Peter", "Olikowski");
            Fahrtenbuch faBu1 = new Fahrtenbuch(fahrer1);
            Fahrtenbuch faBu2 = new Fahrtenbuch(fahrer2);
            Fahrt fahrt1 = new Fahrt(20,new PKW(),new ExpressZustellung(),new DateOnly(2023,03,10));
            Fahrt fahrt2 = new Fahrt(30,new Motorroller(),new StandardZustellung(),new DateOnly(2023,03,11));
            Fahrt fahrt3 = new Fahrt(20, new Kleintransporter(), new ExpressZustellung(), new DateOnly(2023, 02, 07));

            faBu1.AddFahrt(fahrt1);
            faBu1.AddFahrt(fahrt2);
            faBu2.AddFahrt(fahrt3);
            kurierdienst1.AddFahrtenbuch(faBu1);
            kurierdienst1.AddFahrtenbuch(faBu2);

            Console.WriteLine(
            $"Fahrerumsatz: \t{kurierdienst1.BerechneFahrerumsatz(fahrer1)} EUR\t Fahrer: {fahrer1.GetName()}\n" +
            $"Fahrerumsatz: \t{kurierdienst1.BerechneFahrerumsatz(fahrer2)} EUR\t Fahrer: {fahrer2.GetName()}\n" +
            $"Gesamtumsatz: \t{kurierdienst1.BerechneGesamtumsatz()} EUR\n" +
            $"Tagesumsatz: \t{kurierdienst1.BerechneTagesumsatz(new DateOnly(2023, 03, 10))} EUR\t Tag: {new DateOnly(2023, 03, 10)}");
        }
    }
}
namespace Beispiel.Ueberschreiben
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug[] fahrzeuge = new Fahrzeug[5];

            fahrzeuge[0] = new Fahrzeug("AB-CD 123");
            fahrzeuge[1] = new Auto("XY-Z 987");
            fahrzeuge[2] = new Schiff("Evergiven");
            fahrzeuge[3] = new Ballon("Veltins");
            fahrzeuge[4] = new Fahrzeug("GH-IJ 567");

            foreach (var item in fahrzeuge)
            {
                item.Fahren();
            }

            Fahrzeug f1 = fahrzeuge[0];

            Console.WriteLine(f1);
        }
    }
}
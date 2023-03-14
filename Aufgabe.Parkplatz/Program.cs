namespace Aufgabe.Parkplatz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parkplatz p1 = new Parkplatz("Parkplatz Freier Markt", 4);
            Parkplatz p2 = new Parkplatz("Parkplatz Altes Schloss", 2);
            Auto a1 = new Auto("opel", "corsa");
            Auto a2 = new Auto("Ferrari", "Rot");
            Auto a3 = new Auto("Bat", "Mobil");
            Auto a4 = new Auto("test", "wagen");
            Auto a5 = new Auto("nochEin", "Auto");

            Console.WriteLine($"auf {p1.GetName()} gibt es {p1.GetFreieParkboxen()} freie Parkplätze");
            Console.WriteLine($"auf {p2.GetName()} gibt es {p2.GetFreieParkboxen()} freie Parkplätze");
            a1.Einparken(p1);
            a2.Einparken(p1);
            a3.Einparken(p1);
            a4.Einparken(p1);
            a5.Einparken(p1);   // parking 5 cars in 4 Slots, get error String!
            Console.WriteLine($"auf {p1.GetName()} gibt es {p1.GetFreieParkboxen()} freie Parkplätze"); //should be 0 free Slots
            Console.WriteLine($"auf {p2.GetName()} gibt es {p2.GetFreieParkboxen()} freie Parkplätze");
            a1.Einparken(p2);   // already parked in p1, should get error string!
            a1.Ausparken();
            a1.Einparken(p2);   // should work
            a5.Einparken(p1);   // should work         
        }
    }
}
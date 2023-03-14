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
            p1.Einparken(a1);
            p1.Einparken(a2);
            p1.Einparken(a3);
            p1.Einparken(a4);
            p1.Einparken(a5);   // parking 5 cars in 4 Slots, get error String!
            Console.WriteLine($"auf {p1.GetName()} gibt es {p1.GetFreieParkboxen()} freie Parkplätze"); //should be 0 free Slots
            Console.WriteLine($"auf {p2.GetName()} gibt es {p2.GetFreieParkboxen()} freie Parkplätze");
            p1.Einparken(a1);   // already parked in p1, should get error string!
            p1.Ausparken(a1);
            p1.Einparken(a1);   // should work
            p1.Einparken(a5);   // should work         
        }
    }
}
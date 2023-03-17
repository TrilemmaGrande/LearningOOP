namespace Aufgabe.Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entrance entrance = new Entrance();

            Adult a1 = new Adult();
            Child c1 = new Child();
            Group g1 = new Group(20);
            Group g2 = new Group(10);

            entrance.AddVisitor(a1);
            entrance.AddVisitor(c1);
            entrance.AddVisitor(g1);
            entrance.AddVisitor(g2);

            Console.WriteLine($"Anzahl Besucher: {entrance.GetVisitors()}");
            Console.WriteLine($"Tagesumsatz: {entrance.GetTurnover()}");
        }
    }
}
namespace Aufgabe.Spielerkader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Spieler sp1 = new Spieler("Horst", 20000);
            Spieler sp2 = new Spieler("Dieter", 40000);

            Console.WriteLine(sp1.Name + " " + sp1.Transfergebuehr + " ");
            Console.WriteLine(sp2.Name + " " + sp2.Transfergebuehr + " ");
            Console.WriteLine(Spieler.Gewinn());
            sp1.Marktwert();
            Console.WriteLine(Spieler.Gewinn());
        }
    }
}
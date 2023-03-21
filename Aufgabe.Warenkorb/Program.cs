namespace Aufgabe.Warenkorb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Article a1 = new Article(20.00);
            Book b1 = new Book(40.00, "Marx", "Kapitalmarkt mit Büchern erobern", 1970);
            DVD d1 = new DVD(5.00, "Marx - Wie er den Kapitalmarkt eroberte","Dokumentation");

            //Console.WriteLine(
            //    a1.GetPrice() + "\n" + 
            //    b1.GetPrice() + "\n" +
            //    d1.GetPrice());
            //a1.PrintInfos();
            //b1.PrintInfos();
            //d1.PrintInfos();

            ShoppingCart cart1 = new ShoppingCart();
           
            cart1.InsertArticle(b1);
            cart1.InsertArticle(d1);

            cart1.PrintContent();
        }
    }
}
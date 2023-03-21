namespace Aufgabe.Warenkorb
{
    internal class Book : Article
    {
        private string author;
        private int releaseDate;

        public Book(double price, string author, string title, int releaseDate) : base(price)
        {
            this.author = author;
            this.title = title;
            this.releaseDate = releaseDate;
        }

        public override double GetPrice()
        {
            return Math.Round((base.GetPrice() * 1.07), 2);
        }
        public override void PrintInfos()
        {
            base.PrintInfos();
            Console.WriteLine(
                $"Autor: \t\t{author}\n" +
                $"Titel: \t\t{title}\n" +
                $"Datum: \t\t{releaseDate}");
        }
        public string GetAuthor()
        {
            return author;
        }
    }
}

namespace Beispiel_Abhaengigkeiten {
    internal class Program {
        static void Main(string[] args) {
            Student udo = new Student("udo");
            Book b1 = new Book("SQL", "Alles über SQL und noch viel mehr ...");
            Book b2 = new Book("OOP", "Alles über OOP und noch viel mehr ...");
            Book b3 = new Book("TCP", "Alles über TCP und noch viel mehr ...");

            udo.ReadBook(b1);
            udo.ReadBook(b2);
            udo.ReadBook(b3);
        }
    }
}
namespace Beispiel.Komposition {
    internal class Program {
        static void Main(string[] args) {
            Building b1 = new Building(15, "Trump-Tower");

            b1.PrintInfos();
        }
    }
}
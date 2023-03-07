using System.Dynamic;

namespace Aufgabe_Spielerkader {
    class Spieler {        
        private double marktwert;
        private static double kadermarktwert;
        private static double kadertransfergebuehr;
        private Random random = new Random();

        public string Name{ get; set; }
        public double Transfergebuehr { get; set; }
        
        public Spieler(string name, double transfergebuehr) {
            Name = name;
            Transfergebuehr = transfergebuehr;
            kadertransfergebuehr += Transfergebuehr;          
            marktwert = Transfergebuehr;
            kadermarktwert += marktwert;
        }
        public void Marktwert() {
            kadermarktwert -= marktwert;
            marktwert = random.NextDouble() * 100000;
            kadermarktwert += marktwert;
        }
        public static double Gewinn() {
            return kadermarktwert - kadertransfergebuehr;
        }
    }
}
using System.Dynamic;

namespace AufgabenOOP._2023_03_07_Aufgabe_Spielerkader {
    class Spieler {        
        private double marktwert;
        private static int kadermarktwert;
        private static int moeglicherGewinn;

        public string Name{ get; set; }
        public double Transfergebuehr { get; set; }
        
        public Spieler(string name, double transfergebuehr) {
            this.Name = name;
            this.Transfergebuehr = transfergebuehr;


        }




    }
}
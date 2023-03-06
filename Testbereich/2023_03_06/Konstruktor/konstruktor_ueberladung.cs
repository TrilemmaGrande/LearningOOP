/*
 * Konstruktoren und Überladungen
 */

namespace Testbereich {
    internal class konstruktor_ueberladung {
        static void Main(string[] args) {
            Auto a1 = new Auto("Trabant", 150);
            Auto a2 = new Auto("Goggomobil");
            Auto a3 = new Auto(500);
        }
    }
    class Auto {
        private string marke;
        private int ps;

        public Auto(string marke) : this(marke, 50){
            //marke = m;
            //ps = 50;
        }
        public Auto(int ps) : this("Ferrari", ps){
            //marke = "Ferrari";
            //ps = p;
        }
        public Auto(string marke, int ps) {
            this.marke = marke;
            this.ps = ps;
        }

        public string GetMarke() {
            return marke;
        }
        public int GetPs() {
            return ps;
        }
    }
}
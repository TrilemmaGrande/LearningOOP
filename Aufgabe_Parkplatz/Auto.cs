using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Parkplatz {
    internal class Auto {
        private string marke;
        private string modell;
        private bool geparkt;
        private Parkplatz parkplatz;
        private Parkbox parkbox;

        public Auto(string marke, string modell) {
            this.marke = marke;
            this.modell = modell;
        }
        public bool GetGeparkt() {
            return geparkt;
        }       
        public void Einparken(Parkplatz parkplatz) {
            if (!geparkt) {
                if (parkplatz.GetFreieParkboxen() > 0) {
                    this.parkbox = parkplatz.Einparken(this);
                    this.parkplatz = parkplatz;
                    this.geparkt = true;
                    Console.WriteLine("eingeparkt!");                
                }
                else {
                    Console.WriteLine("Parkplatz voll!");
                }
            }
            else {
                Console.WriteLine("bereits eingeparkt!");
            }
        }
        public void Ausparken() {
            if (geparkt) {
                parkplatz.Ausparken(parkbox);
                this.parkbox = null;
                this.parkplatz = null;
                this.geparkt = false;
                Console.WriteLine("ausgeparkt!");
            }
            else {
                Console.WriteLine("nicht eingeparkt!");
            }
        }
    }
}

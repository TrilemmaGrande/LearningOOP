using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Parkplatz {
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
        private string GetCarInfo() {
            return $"{marke} {modell}";
        }
        public void Einparken(Parkplatz parkplatz) {
            if (!geparkt) {
                if (parkplatz.GetFreieParkboxen() > 0) {
                    this.parkbox = parkplatz.Einparken(this);
                    this.parkplatz = parkplatz;
                    this.geparkt = !geparkt;
                    Console.WriteLine($"{GetCarInfo()} \t erfolgreich auf {parkplatz.GetName()} eingeparkt!");                
                }
                else {
                    Console.WriteLine($"{GetCarInfo()} \t nicht eingeparkt, {parkplatz.GetName()} voll!");
                }
            }
            else {
                Console.WriteLine($"{GetCarInfo()} \t wurde bereits auf {parkplatz.GetName()} eingeparkt!");
            }
        }
        public void Ausparken() {
            if (geparkt) {
                parkplatz.Ausparken(parkbox);                
                this.geparkt = !geparkt;
                this.parkbox = null;
                Console.WriteLine($"{GetCarInfo()} \tvon {parkplatz.GetName()} ausgeparkt!");
                this.parkplatz = null;
            }
            else {
                Console.WriteLine($"{GetCarInfo()} \t auf {parkplatz.GetName()} nicht eingeparkt!");
            }
        }
       
    }
}

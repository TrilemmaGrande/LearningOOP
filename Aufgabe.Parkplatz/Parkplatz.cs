using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Parkplatz {
    internal class Parkplatz {
        private Parkbox[] parkboxen;
        private string name;
        
        public Parkplatz(string name, int anzahlBoxen) {
            parkboxen = new Parkbox[anzahlBoxen];
            this.name = name;
            for (int i = 0; i < anzahlBoxen; i++) {
                parkboxen[i] = new Parkbox();
            }
        }
        public string GetName() {
            return name;
        }
        public int GetFreieParkboxen() {
            int counter = 0;
            for (int i = 0; i < parkboxen.Length; i++) {
                if (!parkboxen[i].GetBelegt()) {
                    counter++;
                }
            }
            return counter;
        }
        public Parkbox Einparken(Auto auto) {
            for (int i = 0; i < parkboxen.Length; i++) {
                if (!parkboxen[i].GetBelegt()) {
                    parkboxen[i].SetBelegt(auto);
                    return parkboxen[i];
                }
            }
            return null;
        }
        public void Ausparken(Parkbox parkbox) {
            for (int i = 0; i < parkboxen.Length; i++) {
                if (parkboxen[i] == parkbox) {
                    parkboxen[i].SetBelegt(null);                   
                }
            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Erstellen Sie eine Klasse Sweatshirt mit den Attributen color, size, isDry
 * und den Operationen IsDry(), Dry(), Wash() und GetInfos().
 * Erstellen Sie einen mehrere Konstruktoren.
 */

namespace AufgabenOOP._2023_03_06_Aufgabe2_Sweatshirt {
    internal class Sweatshirt {
        private string color;
        private int size;
        private bool isDry;

        public Sweatshirt(string color, int size) {
            this.color = color;
            this.size = size;
            isDry = true;
        }
        public Sweatshirt(string color) {
            this.color = color;
            size = 50;
            isDry = true;
        }
        public Sweatshirt(int size) {
            color = "Blue";
            this.size = size;
            isDry = true;
        }

        public string GetColor() {
            return color;
        }
        public int GetSize() {
            return size;
        }
        public bool GetIsDry() {
            return isDry;
        }
        public void SetIsDry(bool isDry) {
            this.isDry = isDry;
        }

        public void Dry() {
            if (!GetIsDry()) {
                SetIsDry(true);
            }
        }
        public void Wash() {
            SetIsDry(false);
        }
        public void GetInfos() {
            const string dry = "trocken";
            const string wet = "nass";
            string isDry;

            if (GetIsDry()) {
                isDry = dry;
            }
            else {
                isDry = wet;
            }
            Console.WriteLine(
                $"Das Sweatshirt in der Farbe {GetColor()} " +
                $"hat die Größe {GetSize()} und ist {isDry}");
        }
    }    
}

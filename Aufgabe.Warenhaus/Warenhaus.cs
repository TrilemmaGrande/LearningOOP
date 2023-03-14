using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Warenhaus {
    internal class Warenhaus {
        private string name;
        private int warenbestand;
        private int kassenbestand;
        private static int warenbestandGesamt;
        private static int kassenbestandGesamt;
        private static int warenhausAnzahl;

        public Warenhaus(string name, int warenbestand, int kassenbestand) {
            warenhausAnzahl++;
            this.name = name;
            this.warenbestand = warenbestand;
            warenbestandGesamt += warenbestand;
            this.kassenbestand = kassenbestand;
            kassenbestandGesamt += kassenbestand;
        }

        public void PrintInfo() {
            Console.WriteLine(
                $"{name}" +
                $"\n warenbestand = \t\t{warenbestand}" +
                $"\n kassenbestand = \t\t{kassenbestand}");            
        }
        public static void PrintInfoAll() {
            Console.WriteLine(
                
                $"anzahl Warenhäuser = \t\t{warenhausAnzahl}" +              
                $"\n warenbestand gesamt = \t\t\t\t{warenbestandGesamt}" +            
                $"\n kassenbestand gesamt = \t\t\t{kassenbestandGesamt}");
        }
        public void Buy(int anzahl) {
            if (kassenbestand - (10*anzahl) >= 0) {
                for (int i = 0; i < anzahl; i++) {
                    kassenbestand -= 10;
                    kassenbestandGesamt -= 10;
                    warenbestand += 1;
                    warenbestandGesamt += 1;
                }
            }
        }
        public void Sell(int anzahl) {
            if (warenbestand - anzahl >= 0) {
                for (int i = 0; i < anzahl; i++) {
                    kassenbestand += 20;
                    kassenbestandGesamt += 20;
                    warenbestand -= 1;
                    warenbestandGesamt -= 1;
                }
            }
        }
    }
}

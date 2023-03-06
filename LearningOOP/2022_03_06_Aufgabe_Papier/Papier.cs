using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Aufgabe Papier:
 * Erstellen Sie die Klasse Papier:
 * - es gibt eine Methode zur Berechnung der Fläche (L x B)
 * - Es gibt eine Methode zur Ausgabe der Fläche im Format:
 * "Das Papier mit der Länge xx.x cm und Breite yy.y cm hat eine Fläche von zz.z Quadratmeter."
 */

namespace LearningOOP._2022_03_06_Aufgabe_Papier
{
    internal class Papier {
        private double length;
        private double width;

        public double GetLength() {
            return length;
        }
        public void SetLength(double length) {
            this.length = length;
        }
        public double GetWidth() {
            return width;
        }
        public void SetWidth(double width) {
            this.width = width;
        }
        public double GetArea() {
            return length * width / 10000;
        }
    }
}

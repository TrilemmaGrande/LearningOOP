/*
 * Aufgabe Papier:
 * Erstellen Sie die Klasse Papier:
 * - es gibt eine Methode zur Berechnung der Fläche (L x B)
 * - Es gibt eine Methode zur Ausgabe der Fläche im Format:
 * "Das Papier mit der Länge xx.x cm und Breite yy.y cm hat eine Fläche von zz.z Quadratmeter."
 */

namespace LearningOOP._2022_03_06_Aufgabe_Papier {
    internal class Papier {
        private double length;
        private double width;

        public Papier(double length, double width) {
            this.length = length;
            this.width = width;
        }
        public double GetLength() {
            return length;
        }
        public double GetWidth() {
            return width;
        }
        public double GetArea() {
            return length * width / 10000;
        }
    }
}

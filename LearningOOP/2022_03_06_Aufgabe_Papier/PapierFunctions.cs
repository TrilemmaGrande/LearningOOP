using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP._2022_03_06_Aufgabe_Papier {
    internal class PapierFunctions {
        private Random random = new Random();
        private Papier[] papiere = new Papier[10];


        public void PrintPaperStats(Papier[] obj) {
            foreach (Papier item in obj) {
            Console.WriteLine(
                $"Das Papier mit der Länge {item.GetLength():F1} cm und Breite {item.GetWidth():F1} cm " +
                $"hat eine Fläche von {item.GetArea():F5} Quadratmeter\n\n");
            }
        }
        public Papier[] CreatePaper() {
            for (int i = 0; i < 10; i++) {
                papiere[i] = new Papier();
                papiere[i].SetLength(random.NextDouble()*100);
                papiere[i].SetWidth(random.NextDouble()*100);
            }
            return papiere;
        }
    }
}

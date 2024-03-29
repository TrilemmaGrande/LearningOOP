﻿namespace Aufgabe.Papier
{
    internal class Functions
    {
        private Random random = new Random();
        private Papier[] papiere = new Papier[10];

        public void PrintPaperStats(Papier[] obj)
        {
            foreach (Papier item in obj)
            {
                Console.WriteLine(
                    $"Das Papier mit der Länge {item.GetLength():F1} cm und Breite {item.GetWidth():F1} cm " +
                    $"hat eine Fläche von {item.GetArea():F5} Quadratmeter\n\n");
            }
        }
        public Papier[] CreatePaper()
        {
            for (int i = 0; i < 10; i++)
            {
                papiere[i] = new Papier(random.NextDouble() * 100, random.NextDouble() * 100);
            }
            return papiere;
        }
    }
}

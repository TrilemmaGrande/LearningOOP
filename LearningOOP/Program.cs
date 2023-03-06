using LearningOOP._2022_03_06_Aufgabe_Papier;

namespace LearningOOP {
    internal class Program {
       static void Main(string[] args) {
            PapierFunctions papier = new PapierFunctions();            
            papier.PrintPaperStats(papier.CreatePaper());
        }
    }
}
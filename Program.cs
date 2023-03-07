using AufgabenOOP._2023_03_06_Aufgabe2_Sweatshirt;

namespace LearningOOP {
    internal class Program {
        static void Main(string[] args) {
            Sweatshirt shirt = new Sweatshirt("green");

            shirt.GetInfos();
            shirt.Wash();
            shirt.GetInfos();
            shirt.Dry();
            shirt.GetInfos();
        }
    }
}
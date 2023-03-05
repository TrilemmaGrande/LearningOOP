using LearningOOP._2022_03_03_Aufgabe_Person;

namespace LearningOOP {
    internal class Program {
       static void Main(string[] args) {
            Functions functions = new Functions();
            Person person = new Person();

            functions.MainMenu(person);
        }
    }
}
namespace LearningOOP {
    internal class Program {
        static void Main(string[] args) {
        }
    }
    class Person {
        private string temp;
        private string gebDate;
        private string name;
        private string middleName;
        private string firstName;
        private DateTime thisday = DateTime.Today;

        public void SetGebDate() {
            if (gebDate is null) {
            Console.WriteLine("Bitte geben Sie Ihr Geburtsdatum ein: dd/mm/yyyy: ");
            gebDate = Console.ReadLine();
            }
            else {
                Console.WriteLine("Geburtsdatum ist bereits eingegeben, Geburtsdatum korrigieren? (Y/N) ");
                temp = Console.ReadLine().ToLower();
                if (temp == "y") {
                    Console.WriteLine("Bitte geben Sie Ihr korrigiertes Geburtsdatum ein: dd/mm/yyyy: ");
                    gebDate = Console.ReadLine();
                }
                temp = null;
            }
        }
        public string GetGebDate() {
            return gebDate;
        }
        public void SetName() {

        }
        public string GetName() {
            return name;
        }
        public string GetMiddleName() {
            return middleName;
        }
        public string GetFirstName() {
            return firstName;
        }
        public string Birthday() {
            return null;
        }
    }
}
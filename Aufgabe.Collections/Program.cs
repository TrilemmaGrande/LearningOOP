namespace Aufgabe.Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollectionMaker cm = new CollectionMaker();
            cm.Splitter();
            cm.StringMaker();
            cm.PrintFinalString();
        }
    }
    class CollectionMaker
    {
        private string inputString =
           "123;Hammer,Dübel,Nägel\n" +
           "223;Fischfutter,Sand,Schlauch\n" +
           "434;Pfanne,Gabel\n" +
           "081;Apfel,Flasche,Tisch\n" +
           "727;Laptop,Kabel,Tapete";

        private string[] inputStringSplitted;
        private Dictionary<string, List<string>> finalDictionary = new Dictionary<string, List<string>>();
        private string customer;
        private int dumpster;

        public void Splitter()
        {
            inputStringSplitted = inputString.Split('\n', ';', ',');
        }
        public void StringMaker()
        {
            foreach (var item in inputStringSplitted)
            {
                if (int.TryParse(item, out dumpster))
                {
                    finalDictionary.Add(item, new List<string>());
                    customer = item;
                }
                else
                {
                    finalDictionary[customer].Add(item);
                }
            }
        }
        public void PrintFinalString()
        {
            foreach (var key in finalDictionary.Keys)
            {
                Console.WriteLine($"Kundennummer: {key}");
                foreach (var item in finalDictionary[key])
                {
                    Console.WriteLine($"-{item}");
                }
            }
        }
    }
}
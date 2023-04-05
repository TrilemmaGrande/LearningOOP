namespace Aufgabe.Collections2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text =
            "15;D;Peter Schmidt;Wuppertal\n" +
            "17;D;Hans Meier;Düsseldorf\n" +
            "23;E;Regina Schulz;Mettmann\n" +
            "31;D;Kathrin Müller;Erkrath\n" +
            "32;E;Rudolf Kramer;Witten\n" +
            "35;E;Anne Kunze;Bremen";
            StringReader sr = new StringReader(text);
            sr.MakeDataSet();
            sr.PrintDataSet();
        }
    }
    class StringReader
    {
        private string[] itemizedSplittedString;
        private string[] splittedString;
        private string dataSetKey;
        private Dictionary<string, string> zimmer = new Dictionary<string, string>();
        private Dictionary<string, string> vorname = new Dictionary<string, string>();
        private Dictionary<string, string> nachname = new Dictionary<string, string>();
        private Dictionary<string, string> wohnort = new Dictionary<string, string>();
        private List<Dictionary<string, string>> dataSet = new List<Dictionary<string, string>>();

        public StringReader(string text)
        {
            splittedString = text.Split('\n');
        }
        public void MakeDataSet()
        {
            foreach (var row in splittedString)
            {
                itemizedSplittedString = row.Split(';', ' ');
                dataSetKey = itemizedSplittedString[0];
                if (itemizedSplittedString[1] == "E")
                {
                    itemizedSplittedString[1] = "Einzelzimmer";
                }
                else
                {
                    itemizedSplittedString[1] = "Doppelzimmer";
                }

                zimmer.Add(dataSetKey, itemizedSplittedString[1]);
                vorname.Add(dataSetKey, itemizedSplittedString[2]);
                nachname.Add(dataSetKey, itemizedSplittedString[3]);
                wohnort.Add(dataSetKey, itemizedSplittedString[4]);

            }

            dataSet.Add(zimmer);
            dataSet.Add(vorname);
            dataSet.Add(nachname);
            dataSet.Add(wohnort);

        }
        public void PrintDataSet()
        {
            foreach (var set in dataSet)
            {
                foreach (var item in set)
                {
                    Console.WriteLine(item.Key + " " + item.Value);
                }
            }

        }
    }
}
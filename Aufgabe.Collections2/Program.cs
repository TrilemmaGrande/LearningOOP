using System.Diagnostics;

namespace Aufgabe.Collections2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            for (int i = 0; i < 1000000; i++)
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
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
    class StringReader
    {
        private string[] itemizedSplittedString;
        private string[] splittedString;
        private string dataSetKey;
        private List<string> dataSetKeys = new List<string>();
        private List<Dictionary<string, string>> dataSet = new List<Dictionary<string, string>>();

        public StringReader(string text)
        {
            splittedString = text.Split('\n');
        }
        public void MakeDataSet()
        {
            Dictionary<string, string> zimmer = new Dictionary<string, string>();
            Dictionary<string, string> vorname = new Dictionary<string, string>();
            Dictionary<string, string> nachname = new Dictionary<string, string>();
            Dictionary<string, string> wohnort = new Dictionary<string, string>();
            dataSet.Add(zimmer);
            dataSet.Add(vorname);
            dataSet.Add(nachname);
            dataSet.Add(wohnort);

            foreach (var row in splittedString)
            {
                itemizedSplittedString = row.Split(';', ' ');
                dataSetKey = itemizedSplittedString[0];
                dataSetKeys.Add(dataSetKey);
                itemizedSplittedString[1].Replace("E", "Einzelzimmer");
                itemizedSplittedString[1].Replace("D", "Doppelzimmer");

                zimmer.Add(dataSetKey, itemizedSplittedString[1]);
                vorname.Add(dataSetKey, itemizedSplittedString[2]);
                nachname.Add(dataSetKey, itemizedSplittedString[3]);
                wohnort.Add(dataSetKey, itemizedSplittedString[4]);
            }
        }
        public void PrintDataSet()
        {
            foreach (var setKey in dataSetKeys)
            {
                Console.WriteLine($"Zimmer {setKey}");

                foreach (var set in dataSet)
                {
                    foreach (var item in set)
                    {
                        if (item.Key == setKey)
                        {
                            Console.WriteLine("  " + item.Value);
                        }
                    }
                }
            }
        }
    }
}
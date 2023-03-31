using System.Diagnostics;
using System.Text;

namespace Beispiel.Stringbuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Beispiel ohne StringBuilder
            Stopwatch stopwatch = new Stopwatch();
            string text = "";
            stopwatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                text += "x";
            }
            stopwatch.Stop();
            Console.WriteLine($"Zeit: {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Reset();

            //Beispiel mit StringBuilder
            StringBuilder sb = new StringBuilder();
            stopwatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                sb.Append("x");
            }
            stopwatch.Stop();
            Console.WriteLine($"Zeit: {stopwatch.ElapsedMilliseconds} ms");
                        
        }
    }
}
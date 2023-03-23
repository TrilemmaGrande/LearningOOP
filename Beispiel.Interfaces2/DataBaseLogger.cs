using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel.Interfaces2
{
    internal class DataBaseLogger : ILogger
    {
        public void LogData(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Der Text \"{text}\" wird in die Datenbank geschrieben.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

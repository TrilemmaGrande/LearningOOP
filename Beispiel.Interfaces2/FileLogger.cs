using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel.Interfaces2
{
    internal class FileLogger : ILogger
    {
        public void LogData(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(  $"Der Text \"{text}\" wird in die Datei geschrieben.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

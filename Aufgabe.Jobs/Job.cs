using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Jobs
{
    internal class Job
    {
        private string bezeichnung;
        private string auftraggeber;
        private int dauer;

        public Job(string bezeichnung, string auftraggeber, int dauer)
        {
            this.bezeichnung = bezeichnung;
            this.auftraggeber = auftraggeber;
            this.dauer = dauer;
        }
        public string GetInfos()
        {
            return $"{bezeichnung} -- {auftraggeber} -- {dauer}";
        }
    }
}

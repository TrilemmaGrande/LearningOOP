using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Parkplatz
{
    internal class Auto
    {
        private string marke;
        private string modell;
        private Parkticket ticket;

        public Auto(string marke, string modell)
        {
            this.marke = marke;
            this.modell = modell;
        }
        public Parkticket GetTicket()
        {
            return ticket;
        }
        public void SetTicket(Parkticket ticket)
        {
            this.ticket = ticket;
        }
        public string GetCarInfo()
        {
            return $"{marke} {modell}";
        }
        public bool GetGeparkt()
        {
            return ticket != null;
        }             
    }
}

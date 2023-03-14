using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Parkplatz
{
    internal class Parkticket
    {
        static int id = 100;
        int ticketID;
        Auto auto;
        Parkbox parkbox;

        public Parkticket(Auto auto, Parkbox parkbox)
        {
            id++;
            this.auto = auto;
            this.parkbox = parkbox;
            this.ticketID = id;
        }
        public int GetTicketID()
        {
            return ticketID;
        }
        public Parkbox GetParkbox()
        {
            return parkbox;
        }
        public void Entwerten()
        {            
            auto = null;
            parkbox = null;
        }
    }
}

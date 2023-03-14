using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Parkplatz
{
    internal class Parkplatz
    {
        private Parkbox[] parkboxen;
        private Parkticket[] parktickets;
        private string name;

        public Parkplatz(string name, int anzahlBoxen)
        {
            parkboxen = new Parkbox[anzahlBoxen];
            parktickets = new Parkticket[anzahlBoxen];
            this.name = name;
            for (int i = 0; i < anzahlBoxen; i++)
            {
                parkboxen[i] = new Parkbox();
            }
        }
        public string GetName()
        {
            return name;
        }
        public int GetFreieParkboxen()
        {
            int counter = 0;
            for (int i = 0; i < parkboxen.Length; i++)
            {
                if (!parkboxen[i].GetBelegt())
                {
                    counter++;
                }
            }
            return counter;
        }
        public void Einparken(Auto auto)
        {            
            for (int i = 0; i < parkboxen.Length; i++)
            {
                if (!parkboxen[i].GetBelegt())
                {
                    parkboxen[i].SetBelegt(auto);
                    parktickets[i] = new Parkticket(auto, parkboxen[i]);
                    auto.SetTicket(parktickets[i].GetTicketID());
                    break;
                }
            }          
        }
        public void Ausparken(int ticketID)
        {
            for (int i = 0; i < parktickets.Length; i++)
            {
                if (parktickets[i].GetTicketID() == ticketID)
                {
                    parktickets[i].GetParkbox().SetBelegt(null);
                    parktickets[i].Entwerten();
                    break;
                }
            }
        }

    }
}

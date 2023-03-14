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
        private Parkplatz parkplatz;     
        private int ticket;

        public Auto(string marke, string modell)
        {
            this.marke = marke;
            this.modell = modell;
        }
        private string GetCarInfo()
        {
            return $"{marke} {modell}";
        }
        public bool GetGeparkt()
        {
            return parkplatz != null;
        }
        public void Einparken(Parkplatz parkplatz)
        {
            if (this.parkplatz == null)
            {
                if (parkplatz.GetFreieParkboxen() > 0)
                {
                    this.parkplatz = parkplatz;
                    parkplatz.Einparken(this);
                    Console.WriteLine(
                        $"{GetCarInfo()} \t erfolgreich auf " +
                        $"{parkplatz.GetName()} eingeparkt!");
                }
                else
                {
                    Console.WriteLine(
                        $"{GetCarInfo()} \t nicht eingeparkt," +
                        $" {parkplatz.GetName()} voll!");
                }
            }
            else
            {
                Console.WriteLine(
                    $"{GetCarInfo()} \t wurde bereits auf " +
                    $"{parkplatz.GetName()} eingeparkt!");
            }
        }
        public void Ausparken()
        {
            if (parkplatz != null)
            {
                parkplatz.Ausparken(GetTicket());                            
                Console.WriteLine(
                    $"{GetCarInfo()} \t von " +
                    $"{parkplatz.GetName()} ausgeparkt!");
                this.parkplatz = null;
            }
            else
            {
                Console.WriteLine(
                    $"{GetCarInfo()} \t nicht eingeparkt!");
            }
        }
        public void SetTicket(int ticket)
        {
            this.ticket = ticket;
        }
        private int GetTicket()
        {
            return ticket;
        }

    }
}

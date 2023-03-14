using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Parkplatz
{
    internal class Parkplatz
    {
        private Parkbox[] parkboxen;
        private string name;

        public Parkplatz(string name, int anzahlBoxen)
        {
            parkboxen = new Parkbox[anzahlBoxen];
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

            if (GetFreieParkboxen() > 0)
            {
                for (int i = 0; i < parkboxen.Length; i++)
                {
                    if (!parkboxen[i].GetBelegt())
                    {
                        parkboxen[i].SetBelegt(auto);
                        Parkticket parkticket = new Parkticket(auto, parkboxen[i], this);
                        auto.SetTicket(parkticket);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(
                            $"{auto.GetCarInfo()} \t nicht eingeparkt," +
                            $" {GetName()} voll!");
                    }
                }
                Console.WriteLine(
                        $"{auto.GetCarInfo()} \t erfolgreich auf " +
                        $"{GetName()} eingeparkt!");
            }
            else
            {
                Console.WriteLine(
                    $"{auto.GetCarInfo()} \t wurde bereits auf " +
                    $"{GetName()} eingeparkt!");
            }
        }
        public void Ausparken(Auto auto)
        {
           
                if (auto.GetTicket() != null)
                {
                    Console.WriteLine(
                        $"{auto.GetCarInfo()} \t von " +
                        $"{auto.GetTicket().GetParkplatz().GetName()} ausgeparkt!");

                auto.GetTicket().GetParkbox().SetBelegt(null);
                auto.GetTicket().Entwerten();
                auto.SetTicket(null);
                }
                else
                {
                    Console.WriteLine(
                        $"{auto.GetCarInfo()} \t nicht eingeparkt!");
                }

            
        }

    }
}

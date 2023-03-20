using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Moped
{
    internal class Moped
    {
        protected string licensePlate;
        protected int kilometres;
        protected int seats;
        public Moped(int seats = 2, string licensePlate = "BIT-LC 1")
        {
            this.licensePlate = licensePlate;
            this.seats = seats <= 2 ? seats : 2;           
        }
        public string GetLicensePlate()
        {
            return licensePlate;
        }
        public int GetOdometer()
        {
            return kilometres;
        }
        public void Drive(int kilometres)
        {
            this.kilometres += kilometres;
            Console.WriteLine(
                $"Das Motorrad ist {kilometres} km gefahren.\n");
        }
        public int GetSeats()
        {
            return seats;
        }
        public string GetInfos()
        {
            return
                $"Kennzeichen:\t {licensePlate} \n" +
                $"Kilometer: \t{kilometres} \n" +
                $"Sitzplätze: \t{seats} \n";
        }
    }
}

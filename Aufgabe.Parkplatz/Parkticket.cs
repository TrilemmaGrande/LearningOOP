namespace Aufgabe.Parkplatz
{
    internal class Parkticket
    {        
        Parkbox parkbox;
        Parkplatz parkplatz;

        public Parkticket(Parkbox parkbox, Parkplatz parkplatz)
        {            
            this.parkbox = parkbox;
            this.parkplatz = parkplatz;
        }       
        public Parkbox GetParkbox()
        {
            return parkbox;
        }
        public Parkplatz GetParkplatz()
        {
            return parkplatz;
        }
        public void Entwerten()
        {            
            parkbox = null;
            parkplatz = null;
        }
    }
}

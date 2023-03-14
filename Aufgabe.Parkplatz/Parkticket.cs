namespace Aufgabe.Parkplatz
{
    internal class Parkticket
    {
        Auto auto;
        Parkbox parkbox;
        Parkplatz parkplatz;

        public Parkticket(Auto auto, Parkbox parkbox, Parkplatz parkplatz)
        {
            this.auto = auto;
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
            auto = null;
            parkbox = null;
            parkplatz = null;
        }
    }
}

namespace Beispiel.Konstruktoren.Vererbung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PKW p1 = new PKW(42);
        }
    }
    class Fahrzeug
    {
        private int id;
        public Fahrzeug()
        { 
            Console.WriteLine("Fahrzeug ohne Parameter");
        }
        public Fahrzeug(int id)
        {
            this.id = id;
            Console.WriteLine("Fahrzeug mit Parameter");
        }
    }
    class PKW : Fahrzeug
    {
        public PKW()
        {
            Console.WriteLine("PKW ohne Paramter");
        }
        public PKW(int id) : base(id)
        {
            Console.WriteLine("PKW mit Parameter");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel.Ueberschreiben
{
    internal class Fahrzeug
    {
        protected string kennzeichen;
        public Fahrzeug(string kennzeichen)
        {
            this.kennzeichen = kennzeichen;
        }
        public virtual void Fahren()
        {
            Console.WriteLine($"Das Fahrzeug {kennzeichen} fährt");
        }
    }
}

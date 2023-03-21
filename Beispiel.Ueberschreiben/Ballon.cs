using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel.Ueberschreiben
{
    internal class Ballon : Fahrzeug
    {
        public Ballon(string kennzeichen) : base(kennzeichen)
        {

        }
        public override void Fahren()
        {
            Console.WriteLine($"Der Ballon {kennzeichen} fährt.");
        }
    }
}

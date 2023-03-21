using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel.Ueberschreiben
{
    internal class Schiff : Fahrzeug
    {
        public Schiff(string kennzeichen) : base(kennzeichen)
        {
           
        }
        public override void Fahren()
        {
            Console.WriteLine($"Das Schiff {kennzeichen} fährt.");
        }
    }
}

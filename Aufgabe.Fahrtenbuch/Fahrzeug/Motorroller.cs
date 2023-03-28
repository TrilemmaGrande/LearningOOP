using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Fahrtenbuch
{
    internal class Motorroller : Fahrzeug
    {
        public Motorroller()
        {
            kilometerPreis = 2.0;
        }
        public override double preisBerechnen(double kilometer)
        {
            return kilometer * kilometerPreis;
        }
    }
}

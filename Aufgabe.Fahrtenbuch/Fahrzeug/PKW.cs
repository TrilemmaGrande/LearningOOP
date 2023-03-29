using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Fahrtenbuch
{
    internal class PKW : Fahrzeug
    {
        public PKW()
        {
            kilometerPreis = 5.0;
        }
        public override double PreisBerechnen(double kilometer)
        {
            return kilometer * kilometerPreis;
        }
    }
}

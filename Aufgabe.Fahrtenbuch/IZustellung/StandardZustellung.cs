using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Fahrtenbuch
{
    internal class StandardZustellung : IZustellung
    {
        private double kilometerPreis = 1.0;
        public double PreisBerechnen(double kilometer)
        {
            return kilometer * kilometerPreis;
        }
    }
}

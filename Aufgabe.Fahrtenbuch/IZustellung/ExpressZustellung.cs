using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Fahrtenbuch
{
    internal class ExpressZustellung : IZustellung
    {
        private double kilometerPreis = 3.0;
        public double PreisBerechnen(double kilometer)
        {
            return kilometer * kilometerPreis;
        }
    }
}

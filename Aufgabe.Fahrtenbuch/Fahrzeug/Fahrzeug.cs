using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Fahrtenbuch
{
    internal abstract class Fahrzeug
    {
        protected double kilometerPreis;

        public virtual double PreisBerechnen(double kilometer)
        {
            return kilometer * kilometerPreis;
        }
    }
}

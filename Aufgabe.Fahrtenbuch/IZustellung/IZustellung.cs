using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Fahrtenbuch
{
    interface IZustellung
    {
        public double preisBerechnen(double kilometer);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Fahrtenbuch
{
    internal class Fahrt
    {
        protected double kilometer;
        protected Fahrzeug fahrzeug;
        protected IZustellung zustellungsArt;
        protected DateOnly datum;

        public Fahrt(double kilometer, Fahrzeug fahrzeug, IZustellung zustellungsArt, DateOnly datum)
        {
            this.kilometer = kilometer;
            this.fahrzeug = fahrzeug;
            this.zustellungsArt = zustellungsArt;
            this.datum = datum;
        }
        public double GetFahrtkosten()
        {
            return fahrzeug.PreisBerechnen(kilometer) + zustellungsArt.PreisBerechnen(kilometer);
        }
        public DateOnly GetDate()
        {
            return datum;
        }
    }
}

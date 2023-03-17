using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Zoo
{
    internal class Visitor
    {
        protected int anzahl;
        protected int eintrittspreis;

        public int GetAnzahl()
        {
            return anzahl;
        }
        public int GetEintrittspreis()
        {
            return eintrittspreis;
        }
    }
}

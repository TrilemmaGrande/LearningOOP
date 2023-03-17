using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Zoo
{
    internal class Group : Visitor
    {
        public Group(int anzahl)
        {
            this.anzahl = anzahl;
            this.eintrittspreis = 50;
        }
    }
}

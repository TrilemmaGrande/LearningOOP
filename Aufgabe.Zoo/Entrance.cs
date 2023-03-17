using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Zoo
{
    internal class Entrance
    {
        private int tagesumsatz;
        private int anzahlBesucher;
        Visitor[] visitors = new Visitor[0];
        Visitor[] temp = new Visitor[0];

        public void AddVisitor(Visitor visitor)
        {
            tagesumsatz += visitor.GetEintrittspreis();
            anzahlBesucher += visitor.GetAnzahl();

            //Variable array starts here.
            temp = new Visitor[visitors.Length + 1];

            for (int i = 0; i < visitors.Length; i++)
            {
                temp[i] = visitors[i];
                visitors[i] = null;
            }

            visitors = new Visitor[temp.Length];

            for (int i = 0; i < temp.Length - 1; i++)
            {
                visitors[i] = temp[i];
                temp[i] = null;
            }
            //Variable array ends here.

            visitors[^1] = visitor;
        }
        public int GetTurnover()
        {
            return tagesumsatz;
        }
        public int GetVisitors()
        {
            return anzahlBesucher;
        }
    }
}

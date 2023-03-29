using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Fahrtenbuch
{
    class Fahrer
    {
        protected string vorname;
        protected string name;

        public Fahrer(string vorname, string name)
        {
            this.vorname = vorname;
            this.name = name;
        }
    }
}

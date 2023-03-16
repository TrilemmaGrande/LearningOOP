using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Schule
{
    internal class Lehrer
    {
        private string name;
        private Schulklasse schulklasse;

        public Lehrer(string name, Schulklasse schulklasse)
        {
            this.name = name;
            if (this.schulklasse == null)
            {
                this.schulklasse = schulklasse;
            }
        }
        public string GetName()
        {
            return name;
        }
    }
}

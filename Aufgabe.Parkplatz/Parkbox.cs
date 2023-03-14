using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Parkplatz
{
    internal class Parkbox
    {
        private Auto auto;
        
        public void SetBelegt(Auto auto)
        {
            this.auto = auto;
        }
        public bool GetBelegt()
        {
            return auto != null;
        }
    }
}

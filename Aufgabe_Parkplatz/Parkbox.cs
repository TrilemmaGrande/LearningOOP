using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Parkplatz {
    internal class Parkbox {        
       
        private Auto auto;
        private bool belegt;

        public void SetBelegt(Auto auto) {
            this.auto = auto;
            belegt = !belegt;
            
        }
        public bool GetBelegt() {
            return belegt;
        }

    }
}

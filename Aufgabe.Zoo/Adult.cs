using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Zoo
{
    internal class Adult : Visitor
    {        
        public Adult()
        {
            anzahl++;
            eintrittspreis = 15;
        }
    }
}

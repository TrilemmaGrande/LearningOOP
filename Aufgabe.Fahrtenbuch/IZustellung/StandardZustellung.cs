﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Fahrtenbuch
{
    internal class StandardZustellung : IZustellung
    {
        public double PreisBerechnen(double kilometer)
        {
            return kilometer;
        }
    }
}